using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using AplicacionFalp;

namespace Ges003M
{
    public partial class Frm_Visor : Form
    {

        ConectarFalp CnnFalp;
        Configuration Config;
        string[] Conexion = { "", "", "" };
        string Db_Usuario;
        int cod_estado = 0;
        int cod_etapa = 0;
        int cod_derivador = 0;
        string PCK = "PCk_GES003M.";
        DataTable Tbl = new DataTable();


        public Frm_Visor()
        {
            InitializeComponent();
        }

        private void Frm_Visor_Load(object sender, EventArgs e)
        {
            if (!(CnnFalp != null))
            {
                ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
                FileMap.ExeConfigFilename = Application.StartupPath + @"\..\WF.config";
                Config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

                CnnFalp = new ConectarFalp(Config.AppSettings.Settings["dbServer"].Value,//ConfigurationManager.AppSettings["dbServer"],
                                           Config.AppSettings.Settings["dbUser"].Value,//ConfigurationManager.AppSettings["dbUser"],
                                           Config.AppSettings.Settings["dbPass"].Value,//ConfigurationManager.AppSettings["dbPass"],
                                           ConectarFalp.TipoBase.Oracle);

                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir(); // abre la conexion
                Conexion[0] = Config.AppSettings.Settings["dbServer"].Value;
                Conexion[1] = Config.AppSettings.Settings["dbUser"].Value;
                Conexion[2] = Config.AppSettings.Settings["dbPass"].Value;

                this.Text = this.Text + " [Versión: " + Application.ProductVersion + "] [Conectado: " + Conexion[0] + "]";

                Db_Usuario = "SICI";
                ck_fecha.Checked = true;
                Carga_Grilla();
           
            }
        }


        private void Carga_Grilla()
        {
            string v_habilitado="";
            if(ck_fecha.Checked==true)
            {
                v_habilitado="S";
            }
            else{
                 v_habilitado="N";
            }
            Tbl.Clear();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_CASO");
            CnnFalp.ParametroBD("PIN_NUM_RECLAMO",traer_valor(txtnum_reclamo.Text) , DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_PACIENTE", txtpaciente.Text.ToUpper(), DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA_DESDE", txtfecha_desde.Text, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA_HASTA", txtfecha_hasta.Text, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_NUM_CASO", traer_valor(txtnum_caso.Text), DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_ESTADO", cod_estado, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_ETAPA", cod_etapa, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_DERIVADOR", cod_derivador, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FOLIO", traer_valor(txtfolio.Text), DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_HABILITA",v_habilitado , DbType.String, ParameterDirection.Input);

            Tbl.Load(CnnFalp.ExecuteReader());

            if(Tbl.Rows.Count > 0 )
            {
                Gv_Casos.AutoGenerateColumns = false;
                Gv_Casos.DataSource = Tbl;
            }      
        }

     private string traer_valor(string valor)
    {
        string var="";
        if (valor != "")
        {
            var = valor;
        }
        else
        {
            var = "0";
        }

        return var;
    }

        private void Gv_Casos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                Int64 reclamo = Convert.ToInt64(Gv_Casos.Rows[e.RowIndex].Cells["N_RECLAMO"].Value.ToString());
                if (Gv_Casos.Columns[e.ColumnIndex].Name == "M")
                {

                    DataGridViewRow row = Gv_Casos.Rows[e.RowIndex];
                    DataGridViewTextBoxCell Id_fila = row.Cells["N_CASO"] as DataGridViewTextBoxCell;
                    Int64 Caso = Convert.ToInt64(Id_fila.Value);
                    Int64 cod_estado= Convert.ToInt64(Gv_Casos.Rows[e.RowIndex].Cells["COD_ESTADOS"].Value.ToString());

                    Ges003M frm = new Ges003M(Caso,reclamo,cod_estado);
                    frm.ShowDialog();
                    Carga_Grilla();

                }

                if (Gv_Casos.Columns[e.ColumnIndex].Name == "V")
                {

                    DataGridViewRow row = Gv_Casos.Rows[e.RowIndex];
                    DataGridViewTextBoxCell Id_fila = row.Cells["N_CASO"] as DataGridViewTextBoxCell;
                    Int64 Caso = Convert.ToInt64(Id_fila.Value);

         
                    Int64 derivador = Convert.ToInt64(Gv_Casos.Rows[e.RowIndex].Cells["DERIVADOR"].Value.ToString());
                    string paciente = Gv_Casos.Rows[e.RowIndex].Cells["NOMBRE_PAC"].Value.ToString();
                    Frm_Etapas frm = new Frm_Etapas(Caso,reclamo,paciente,derivador);
                    frm.ShowDialog();

                }
            }
        }

        #region Cargar Campos

        private void Cargar_estado()
        {
            cod_estado= 0; txtderivador.Text = "";
            Cargar_Parametros(ref Ayuda, 146, txtestado.Text);
            if (!Ayuda.EOF())
            {
                cod_estado = Convert.ToInt32(Ayuda.Fields(0));
                txtestado.Text = Ayuda.Fields(1);
                txtetapa.Focus();
            }
        }

        private void Cargar_etapa()
        {
            cod_etapa = 0; txtetapa.Text = "";
            Cargar_Parametros(ref Ayuda, 143, txtetapa.Text );
            if (!Ayuda.EOF())
            {
                cod_etapa = Convert.ToInt32(Ayuda.Fields(0));
                txtetapa.Text = Ayuda.Fields(1);
                txtderivador.Focus();
            }
        }
        private void Cargar_derivador()
        {
            cod_derivador = 0; txtderivador.Text = "";
            TraeDerivador(ref Ayuda, txtderivador.Text);
            if (!Ayuda.EOF())
            {
                cod_derivador = Convert.ToInt32(Ayuda.Fields(0));
                txtderivador.Text = Ayuda.Fields(1);
                txtfolio.Focus();
            }
        }

        private void Cargar_Parametros(ref AyudaSpreadNet.AyudaSprNet Ayuda, Int32 TIPO, string DESCRIPCION)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = CnnFalp.DBNombre;
            Ayuda.Pass = CnnFalp.DBPass;
            Ayuda.User = CnnFalp.DBUser;
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "CARGAR '" + DESCRIPCION + " '";
            Ayuda.Package = "PCk_GES003M";
            Ayuda.Procedimiento = "P_TRAE_PARAMETROS";
            Ayuda.Generar_ParametroBD("PIN_TIPO", TIPO, DbType.Int32, ParameterDirection.Input);
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", DESCRIPCION.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();
        }


        private void TraeDerivador(ref AyudaSpreadNet.AyudaSprNet Ayuda, string descripcion)
        {
            string[] NomCol = { "ID", "RUT", "Derivador" };
            int[] AnchoCol = { 0, 60, 360 };
            Ayuda.Nombre_BD_Datos = CnnFalp.DBNombre;
            Ayuda.Pass = CnnFalp.DBPass;
            Ayuda.User = CnnFalp.DBUser;
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Derivador GES";
            Ayuda.Package = "PCk_GES003M";
            Ayuda.Procedimiento = "P_TRAE_DERIVADOR";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", descripcion.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();
        }
        #endregion 

        #region Validacion de campos

        private void txtnum_reclamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                        txtpaciente.Focus();
                }
            }
        }

        private void txtpaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                    txtnum_caso.Focus();
                }
              
            }
        }

        private void txtnum_caso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                   txtestado.Focus();
                }
            }
        }

        private void txtestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                    Cargar_estado();
                    if (txtetapa.Text != "")
                    {
                        txtetapa.Focus();
                    }
                    else
                    {
                        txtetapa.Focus();
                    }
                }

            }
        }

        private void txtetapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {

                if (e.KeyChar == (char)13)
                {
                    Cargar_etapa();
                    if (txtetapa.Text != "")
                    {
                        txtderivador.Focus();
                    }
                    else
                    {
                        txtetapa.Focus();
                    }
                }

            }
        }

        private void txtderivador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;

                return;
            }
            else
            {

                if (e.KeyChar == (char)13)
                {
                    Cargar_derivador();
                    if (txtderivador.Text != "")
                    {
                        txtfolio.Focus();
                    }
                    else
                    {
                        txtderivador.Focus();
                    }
                }

            }
        }

        private void txtfolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            else
            {

                if (e.KeyChar == (char)13)
                {
                    if (txtderivador.Text != "")
                    {
                        btn_buscar.Focus();
                    }
                    else
                    {
                        txtfolio.Focus();
                    }
                }
            }
        }

        #endregion 

        #region Cambiar Focos

        private void CambiarBlanco_TextLeave(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.White;

        }

        private void CambiarColor_TextEnter(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void CambiarColor_Enter(object sender, EventArgs e)
        {
            GroupBox GB = (GroupBox)sender;
            GB.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void CambiarBlanco_Leave(object sender, EventArgs e)
        {
            GroupBox GB = (GroupBox)sender;
            GB.BackColor = Color.WhiteSmoke;
        }

        #endregion 

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Carga_Grilla();
            limpiar();
            
        }
        private void limpiar()
        {
            txtnum_reclamo.Text = "";
            txtpaciente.Text = "";
            txtfecha_desde.Text = "";
            txtfecha_hasta.Text = "";
            txtnum_caso.Text = "";
            cod_estado = 0;
            txtestado.Text = "";
            cod_etapa = 0;
            txtetapa.Text = "";
            cod_derivador = 0;
            txtderivador.Text = "";
            txtfolio.Text = "";
            ck_fecha.Checked = true;

        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            txtestado.Text = "";
            cod_estado = 0;
            Cargar_estado();
        }

        private void btn_etapa_Click(object sender, EventArgs e)
        {
            txtetapa.Text = "";
            cod_etapa = 0;
            Cargar_etapa();
        }

        private void btn_derivador_Click(object sender, EventArgs e)
        {
            txtderivador.Text = "";
            cod_derivador = 0;
            Cargar_derivador();

        }

        private void ck_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_fecha.Checked == true)
            {
                txtfecha_desde.Enabled = true;
                txtfecha_hasta.Enabled = true;
            }
            else
            {
                txtfecha_desde.Enabled = false;
                txtfecha_hasta.Enabled = false;
            }
        }

        private void Gv_Casos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                e.PaintBackground(e.ClipBounds, false);
                Font drawFont = new Font("Trebuchet MS", 8, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;
                StrFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawImage(Properties.Resources.HeaderGV1024, e.CellBounds);
                e.Graphics.DrawString(Gv_Casos.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }

  


    }
}
