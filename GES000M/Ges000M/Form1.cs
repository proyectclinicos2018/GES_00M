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
    public partial class Ges003M : Form
    {
        ConectarFalp CnnFalp;
        Configuration Config;
        string[] Conexion = { "", "", "" };
        string Db_Usuario;
        int cod_estado = 0;
        int cod_etapa = 0;
        Int64 cod_sub_etapa = 0;
        Int64 v_correlativo = 0;
        string PCK = "PCk_GES003M.";
        DataTable Tbl = new DataTable();
        DataTable dt_patologias = new DataTable();
        DataTable dt_historial = new DataTable();
        DataTable dt_folio = new DataTable();
        Int64 NCaso=0;
        Int64 Nreclamo=0;
        Int64 estado = 0;
        Int32 min = 0;




        public Ges003M()
        {
            InitializeComponent();
        }


        public Ges003M(Int64 n_caso, Int64 n_reclamo, Int64 v_cod_estado)
        {
            NCaso = n_caso;
            Nreclamo = n_reclamo;
            estado = v_cod_estado;

            InitializeComponent();
        }

        private void Ges002M_Load(object sender, EventArgs e)
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
            }
                Db_Usuario = "SICI";
            txtcaso.Text = NCaso.ToString();
            txtreclamo.Text = Nreclamo.ToString();
            timer1.Start();

            if (estado == 4)
            {
                Lbl_Estado.Text = "CERRADO";
            }
          
          CargaPac();
          Cargar_historial_num_caso();
        }


       private void CargaPac()
        {
           

            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_EXTRAER_DAT_PAC");
            CnnFalp.ParametroBD("PIN_NUM_CASO", NCaso, DbType.Int64, ParameterDirection.Input);
            Tbl.Load(CnnFalp.ExecuteReader());

            CnnFalp.Cerrar();


            foreach (DataRow fila in Tbl.Rows)
            {
                v_correlativo = Convert.ToInt64(fila["CORRELATIVO"].ToString());
                Txt_Ficha.Text = fila["FICHA"].ToString();
                Txt_Tipo_Doc.Text = fila["TIPO_DOC"].ToString();
                Txt_N_Doc.Text = fila["NUMERO_DOC"].ToString();
                Txt_Nombre.Text = fila["NOMBRE"].ToString();
                Txt_Paterno.Text = fila["PATERNO"].ToString();
                Txt_Materno.Text = fila["MATERNO"].ToString();
                Txt_Sexo.Text = fila["SEXO"].ToString();
                Txt_FN.Text = fila["FECHA_NAC"].ToString(); ;
                Txt_Edad.Text = fila["EDAD"].ToString();
                Txt_ECivil.Text = fila["ECIVIL"].ToString();
                txtinstitucion.Text = fila["NOM_INSTITUCION"].ToString();
                txtprevision.Text = fila["NOM_PREVISION"].ToString();
                txtplan.Text = fila["NOM_PLAN"].ToString();
            }
        }


       private void Cargar_Patolologias_Pac()
        {
            dt_patologias.Clear();
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_PATOLOGIAS_PAC");
            CnnFalp.ParametroBD("PIN_NUM_CASO", txtcaso.Text , DbType.Int64, ParameterDirection.Input);
            dt_patologias.Load(CnnFalp.ExecuteReader());
            CnnFalp.Cerrar();
            grilla_patologias.DataSource = dt_patologias;
          

        }

       private void Cargar_historial_num_caso()
       {
           dt_historial.Clear();
           if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

           CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_HIST_N_CASO");
           CnnFalp.ParametroBD("PIN_CORRELATIVO", v_correlativo, DbType.Int64, ParameterDirection.Input);
           dt_historial.Load(CnnFalp.ExecuteReader());

           CnnFalp.Cerrar();

           if (dt_historial.Rows.Count == 0)
           {
               MessageBox.Show("Estimado Usuario, No existen Num Casos Asociados a este Pacientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               Cargar_Patolologias_Pac();
           }
           grilla_historial.DataSource = dt_historial;
       }

       private void btn_cierre_caso_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Esta Seguro(a) de Cerrar el caso N° " + NCaso + "?",
                                        "Ges002M", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               if (Validar_cambio())
               {

                   Cerrar_estado_caso();
                   MessageBox.Show("El Caso N°" + NCaso + ", ha sido Cerrado con Exito");
                   Cargar_historial_num_caso();
                   Lbl_Estado.Text = "CERRADO";
               }
               else
               {
                   MessageBox.Show("El Caso N°" + NCaso + ", No se puede Cerrar, debido a que existen SubEtapas Abiertas");
               }
           }
           else
           {
               return;
           }
       }

       private void btn_revertir_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Esta Seguro(a) de Revertir el caso N° " + NCaso + "?",
                                       "Ges002M", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               if (Validar_cambio())
               {
                   Revertir_estado_caso();
                   MessageBox.Show("El Caso N°" + NCaso + ", ha sido Revertido con Exito");
                   Cargar_historial_num_caso();
                   Lbl_Estado.Text = "ABIERTO";
               }
               else
               {
                   MessageBox.Show("El Caso N°" + NCaso + ", No se puede Cerrar, debido a que existen SubEtapas Abiertas");
               }
           }
           else
           {
               return;
           }
       }


       private Boolean Validar_cambio()
       {
           Boolean var = false;
           DataTable dt = new DataTable();
           dt.Clear();
           if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
           CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_ETAPAS_PAC");
           CnnFalp.ParametroBD("PIN_NUM_CASO", NCaso, DbType.Int64, ParameterDirection.Input);
           dt.Load(CnnFalp.ExecuteReader());
           CnnFalp.Cerrar();


           int contador = 0;
           foreach (DataRow ad in dt.Rows)
           {
               string estado = ad["COD_ESTADO"].ToString();

               if (estado == "3")
               {
                   contador++;
               }
           }

           if (contador == dt.Rows.Count)
           {
               var = true;
           }

           return var;
       }


       private void Cerrar_estado_caso()
       {
          
           if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
           CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CERRAR_ESTADO_CASO");
           CnnFalp.ParametroBD("PIN_NUM_CASO", NCaso, DbType.Int64, ParameterDirection.Input);
           int registro = CnnFalp.ExecuteNonQuery();
           CnnFalp.Cerrar();
       }

       private void Revertir_estado_caso()
       {

           if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
           CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_REVERTIR_ESTADO_CASO");
           CnnFalp.ParametroBD("PIN_NUM_CASO", NCaso, DbType.Int64, ParameterDirection.Input);
           int registro = CnnFalp.ExecuteNonQuery();
           CnnFalp.Cerrar();
       }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            min = min + 1;
            if (min < 3)
            {
                if (min == 1)
                {
                    Lbl_Estado.Visible = false;
                }
                if (min == 2)
                {
                    Lbl_Estado.Visible = true;
                }
            }
            else
            {
                min = 0;
            }
        }

     

        private void grilla_patologias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DialogResult opc = MessageBox.Show("Estimado Usuario, Esta seguro de Seleccionar esta Sub Etapa", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.Yes)
                {
                    cod_sub_etapa = Convert.ToInt64(grilla_patologias.Rows[e.RowIndex].Cells["COD_SUB_ETAPAS"].Value.ToString());
                    Cargar_folio_subetapa();
                }
            }
        }


        private void Cargar_folio_subetapa()
        {

            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_FOLIO");
            CnnFalp.ParametroBD("PIN_NUM_CASO", NCaso, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_SUB_ETAPA", cod_sub_etapa, DbType.Int64, ParameterDirection.Input);
            dt_folio.Load(CnnFalp.ExecuteReader());
            CnnFalp.Cerrar();
            if (dt_folio.Rows.Count > 0)
            {
                grilla_folio.DataSource = dt_folio;
                Ordenar_columnas();
            }
            else
            {
                MessageBox.Show("Estimado Usuario, No existen Folios Aociados al Caso " + NCaso  + " ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Ordenar_columnas()
        {
            grilla_folio.Columns["FOLIO_F"].DisplayIndex = 0;
            grilla_folio.Columns["FECHA_F"].DisplayIndex = 1;
            grilla_folio.Columns["TOTAL_F"].DisplayIndex = 2;
            grilla_folio.Columns["NOM_MOTIVO_F"].DisplayIndex = 3;
            grilla_folio.Columns["MEDICO_F"].DisplayIndex = 4;
            grilla_folio.Columns["CIE_F"].DisplayIndex = 5;
            grilla_folio.Columns["DIAGNOSTICO_F"].DisplayIndex = 6;
            grilla_folio.Columns["ESQUEMA_F"].DisplayIndex = 7;
            grilla_folio.Columns["CICLO_F"].DisplayIndex = 8;

        }

       
        private void grilla_folio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= -1)
            {
                string folio = grilla_folio.Rows[e.RowIndex].Cells["FOLIO_F"].Value.ToString();
                DialogResult opc = MessageBox.Show("Estimado Usuario, Esta seguro de Seleccionar este Folio "+ folio + "", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.Yes)
                {
                    
                    if (folio !="")
                    {
                        System.Diagnostics.Process MiProceso = new System.Diagnostics.Process();
                        MiProceso.StartInfo.WorkingDirectory = Application.StartupPath + @"\..\CONSULTAS\";
                        MiProceso.StartInfo.FileName = "ADM001C.exe"; // nombre del archivo a ejecutar con su extension
                        MiProceso.StartInfo.Arguments = folio; // esto es opcional en caso que el ejecutablee reciba parametros
                        MiProceso.Start(); // inicia el ejecutable
                        MiProceso.WaitForExit(); // esta opción indica que el programa solo podra seguir cuando se cierre el ejecutable
                        MiProceso.Close(); // cierra el ejecutable
                        MiProceso.Dispose(); // libera memoria en la aplicacion

                        //   }

                    }
                }
            }

        }

        private void grilla_patologias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                e.Graphics.DrawString(grilla_patologias.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }

        private void grilla_folio_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                e.Graphics.DrawString(grilla_folio.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }

        private void grilla_examen_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                e.Graphics.DrawString(grilla_examen.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }

        }

    
    }
}
