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
    public partial class Frm_Visor_Etapas : Form
    {
        ConectarFalp CnnFalp;
        Configuration Config;
        string[] Conexion = { "", "", "" };
        string PCK = "PCk_GES003M.";
        string Db_Usuario;
        DataTable dt = new DataTable();
        Int64 caso = 0;


        public Frm_Visor_Etapas(Int64 v_caso)
        {
            caso = v_caso;
            InitializeComponent();
        }

        public Frm_Visor_Etapas()
        {
            InitializeComponent();
        }

        private void Frm_Visor_Etapas_Load(object sender, EventArgs e)
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
            Cargar_gilla();
        }


        private void Cargar_gilla()
        {
            dt.Clear();
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_ETAPAS_PAC");
            CnnFalp.ParametroBD("PIN_NUM_CASO", caso, DbType.Int64, ParameterDirection.Input);
            dt.Load(CnnFalp.ExecuteReader());
            CnnFalp.Cerrar();
            grilla_etapa.DataSource = dt;


        }

        private void grilla_etapa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                e.Graphics.DrawString(grilla_etapa.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }
    }
}
