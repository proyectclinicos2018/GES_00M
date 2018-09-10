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
    public partial class Frm_Etapas : Form
    {
        ConectarFalp CnnFalp;
        Configuration Config;
        string[] Conexion = { "", "", "" };
        string PCK = "PCk_GES003M.";
        string Db_Usuario;
        Int64 caso=0;
        Int64 reclamo = 0;
        string paciente = "";
        Int64 derivador = 0;
        DataTable dt = new DataTable();
       
        public Frm_Etapas()
        {
            InitializeComponent();
        }

        public Frm_Etapas(Int64 v_caso, Int64 v_reclamo, string v_paciente,Int64 v_derivador)
        {
            caso=v_caso;
            reclamo=v_reclamo;
            paciente=v_paciente;
            derivador=v_derivador;
            InitializeComponent();
        }


        private void Frm_Etapas_Load(object sender, EventArgs e)
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

                txtreclamo.Text = reclamo.ToString();
                txtcaso.Text = caso.ToString();
                txtpaciente.Text = paciente;
                txtreclamo.Enabled = false;
                txtcaso.Enabled = false;
                txtpaciente.Enabled = false;
           
                Cargar_gilla();
                Validar_estados();
                int etapas_activas = Validar_Estado_sub_etapa();
                int v_etapas = dt.Rows.Count;
        
                v_ac.Text = etapas_activas.ToString();
                v_c.Text= v_etapas.ToString();
                
        }

      

        private void Img_Ingresada_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Datos de esta estapa en un Formulario");
        }

        private void Validar_estados()
        {

            if (derivador > 0)
            {
                Img_Ingresada.Image = global::Ges003M.Properties.Resources.comprobado;
            }
            else
            {
                Img_Ingresada.Image = global::Ges003M.Properties.Resources.cancelar;
            }

            if (Validar_Estado_sub_etapa() == dt.Rows.Count)
            {
                Img_Recep.Image = global::Ges003M.Properties.Resources.comprobado;
                Img_Cien.Image = global::Ges003M.Properties.Resources.advertencia;
            }           
        }

        private void Img_Recep_Click(object sender, EventArgs e)
        {
            Frm_Visor_Etapas frm = new Frm_Visor_Etapas(caso);
            frm.ShowDialog();
        }

        private void Cargar_gilla()
        {
            dt.Clear();
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + "P_CARGA_ETAPAS_PAC");
            CnnFalp.ParametroBD("PIN_NUM_CASO", caso, DbType.Int64, ParameterDirection.Input);
            dt.Load(CnnFalp.ExecuteReader());
            CnnFalp.Cerrar();
  
        }

        private int Validar_Estado_sub_etapa()
        {
            int contador = 0;
            foreach (DataRow ad in dt.Rows)
            {
                string estado = ad["COD_ESTADO"].ToString();

                if (estado =="3")
                {
                    contador++;
                }
            }

            return contador;
        }


    }
}
