namespace Ges003M
{
    partial class Frm_Visor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gv_Casos = new System.Windows.Forms.DataGridView();
            this.M = new System.Windows.Forms.DataGridViewImageColumn();
            this.V = new System.Windows.Forms.DataGridViewImageColumn();
            this.N_CASO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_RECLAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_CANASTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_CTACTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DERIVADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ESTADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_fecha = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_derivador = new System.Windows.Forms.Button();
            this.btn_etapa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtderivador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtetapa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnum_caso = new System.Windows.Forms.TextBox();
            this.btn_estado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum_reclamo = new System.Windows.Forms.TextBox();
            this.txtfecha_desde = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Casos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gv_Casos
            // 
            this.Gv_Casos.AllowUserToAddRows = false;
            this.Gv_Casos.AllowUserToDeleteRows = false;
            this.Gv_Casos.AllowUserToResizeColumns = false;
            this.Gv_Casos.AllowUserToResizeRows = false;
            this.Gv_Casos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Casos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Casos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Gv_Casos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M,
            this.V,
            this.N_CASO,
            this.N_RECLAMO,
            this.RUT,
            this.NOMBRE_PAC,
            this.ESTADO,
            this.M_CANASTA,
            this.M_CTACTE,
            this.DERIVADOR,
            this.COD_ESTADOS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_Casos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gv_Casos.Location = new System.Drawing.Point(11, 173);
            this.Gv_Casos.Name = "Gv_Casos";
            this.Gv_Casos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Casos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gv_Casos.RowHeadersVisible = false;
            this.Gv_Casos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Casos.Size = new System.Drawing.Size(881, 336);
            this.Gv_Casos.TabIndex = 0;
            this.Gv_Casos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Casos_CellDoubleClick);
            this.Gv_Casos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Gv_Casos_CellPainting);
            // 
            // M
            // 
            this.M.HeaderText = "M";
            this.M.Image = global::Ges003M.Properties.Resources.llave;
            this.M.Name = "M";
            this.M.ReadOnly = true;
            this.M.Width = 20;
            // 
            // V
            // 
            this.V.HeaderText = "V";
            this.V.Image = global::Ges003M.Properties.Resources.investigacion;
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Width = 20;
            // 
            // N_CASO
            // 
            this.N_CASO.DataPropertyName = "N_CASO";
            this.N_CASO.HeaderText = "N° Caso";
            this.N_CASO.Name = "N_CASO";
            this.N_CASO.ReadOnly = true;
            this.N_CASO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.N_CASO.Width = 70;
            // 
            // N_RECLAMO
            // 
            this.N_RECLAMO.DataPropertyName = "N_RECLAMO";
            this.N_RECLAMO.HeaderText = "N° Reclamo";
            this.N_RECLAMO.Name = "N_RECLAMO";
            this.N_RECLAMO.ReadOnly = true;
            this.N_RECLAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.N_RECLAMO.Width = 80;
            // 
            // RUT
            // 
            this.RUT.DataPropertyName = "DOC";
            this.RUT.HeaderText = "N° Doc";
            this.RUT.Name = "RUT";
            this.RUT.ReadOnly = true;
            this.RUT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RUT.Width = 80;
            // 
            // NOMBRE_PAC
            // 
            this.NOMBRE_PAC.DataPropertyName = "NOMBRE";
            this.NOMBRE_PAC.HeaderText = "Nombre Paciente";
            this.NOMBRE_PAC.Name = "NOMBRE_PAC";
            this.NOMBRE_PAC.ReadOnly = true;
            this.NOMBRE_PAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOMBRE_PAC.Width = 300;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // M_CANASTA
            // 
            this.M_CANASTA.HeaderText = "Monto Canasta";
            this.M_CANASTA.Name = "M_CANASTA";
            this.M_CANASTA.ReadOnly = true;
            this.M_CANASTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // M_CTACTE
            // 
            this.M_CTACTE.HeaderText = "Monto CTA CTE";
            this.M_CTACTE.Name = "M_CTACTE";
            this.M_CTACTE.ReadOnly = true;
            this.M_CTACTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DERIVADOR
            // 
            this.DERIVADOR.DataPropertyName = "DERIVADOR";
            this.DERIVADOR.HeaderText = "Derivador";
            this.DERIVADOR.Name = "DERIVADOR";
            this.DERIVADOR.ReadOnly = true;
            this.DERIVADOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DERIVADOR.Visible = false;
            // 
            // COD_ESTADOS
            // 
            this.COD_ESTADOS.DataPropertyName = "COD_ESTADOS";
            this.COD_ESTADOS.HeaderText = "Cod_estado";
            this.COD_ESTADOS.Name = "COD_ESTADOS";
            this.COD_ESTADOS.ReadOnly = true;
            this.COD_ESTADOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ESTADOS.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ck_fecha);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_derivador);
            this.groupBox1.Controls.Add(this.btn_etapa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtfolio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtderivador);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtfecha_hasta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtetapa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnum_caso);
            this.groupBox1.Controls.Add(this.btn_estado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpaciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnum_reclamo);
            this.groupBox1.Controls.Add(this.txtfecha_desde);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ck_fecha
            // 
            this.ck_fecha.AutoSize = true;
            this.ck_fecha.Location = new System.Drawing.Point(76, 114);
            this.ck_fecha.Name = "ck_fecha";
            this.ck_fecha.Size = new System.Drawing.Size(15, 14);
            this.ck_fecha.TabIndex = 109;
            this.ck_fecha.UseVisualStyleBackColor = true;
            this.ck_fecha.CheckedChanged += new System.EventHandler(this.ck_fecha_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 108;
            this.label12.Text = "Hab. Fecha";
            // 
            // btn_derivador
            // 
            this.btn_derivador.Image = global::Ges003M.Properties.Resources.Search2;
            this.btn_derivador.Location = new System.Drawing.Point(515, 84);
            this.btn_derivador.Name = "btn_derivador";
            this.btn_derivador.Size = new System.Drawing.Size(25, 23);
            this.btn_derivador.TabIndex = 105;
            this.btn_derivador.UseVisualStyleBackColor = true;
            this.btn_derivador.Click += new System.EventHandler(this.btn_derivador_Click);
            // 
            // btn_etapa
            // 
            this.btn_etapa.Image = global::Ges003M.Properties.Resources.Search2;
            this.btn_etapa.Location = new System.Drawing.Point(837, 58);
            this.btn_etapa.Name = "btn_etapa";
            this.btn_etapa.Size = new System.Drawing.Size(25, 23);
            this.btn_etapa.TabIndex = 104;
            this.btn_etapa.UseVisualStyleBackColor = true;
            this.btn_etapa.Click += new System.EventHandler(this.btn_etapa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "N° Folio";
            // 
            // txtfolio
            // 
            this.txtfolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfolio.Location = new System.Drawing.Point(613, 87);
            this.txtfolio.MaxLength = 10;
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(117, 20);
            this.txtfolio.TabIndex = 102;
            this.txtfolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfolio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Derivador";
            // 
            // txtderivador
            // 
            this.txtderivador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtderivador.Location = new System.Drawing.Point(76, 87);
            this.txtderivador.MaxLength = 20;
            this.txtderivador.Name = "txtderivador";
            this.txtderivador.Size = new System.Drawing.Size(433, 20);
            this.txtderivador.TabIndex = 99;
            this.txtderivador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtderivador_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "F. Hasta";
            // 
            // txtfecha_hasta
            // 
            this.txtfecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_hasta.Location = new System.Drawing.Point(779, 34);
            this.txtfecha_hasta.Name = "txtfecha_hasta";
            this.txtfecha_hasta.Size = new System.Drawing.Size(83, 20);
            this.txtfecha_hasta.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Etapas";
            // 
            // txtetapa
            // 
            this.txtetapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtetapa.Location = new System.Drawing.Point(613, 61);
            this.txtetapa.MaxLength = 20;
            this.txtetapa.Name = "txtetapa";
            this.txtetapa.Size = new System.Drawing.Size(218, 20);
            this.txtetapa.TabIndex = 94;
            this.txtetapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtetapa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "N° Caso Falp";
            // 
            // txtnum_caso
            // 
            this.txtnum_caso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum_caso.Location = new System.Drawing.Point(76, 60);
            this.txtnum_caso.MaxLength = 10;
            this.txtnum_caso.Name = "txtnum_caso";
            this.txtnum_caso.Size = new System.Drawing.Size(95, 20);
            this.txtnum_caso.TabIndex = 92;
            this.txtnum_caso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_caso_KeyPress);
            // 
            // btn_estado
            // 
            this.btn_estado.Image = global::Ges003M.Properties.Resources.Search2;
            this.btn_estado.Location = new System.Drawing.Point(515, 58);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(25, 23);
            this.btn_estado.TabIndex = 91;
            this.btn_estado.UseVisualStyleBackColor = true;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestado.Location = new System.Drawing.Point(262, 61);
            this.txtestado.MaxLength = 20;
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(247, 20);
            this.txtestado.TabIndex = 89;
            this.txtestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestado_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Nom. Paciente";
            // 
            // txtpaciente
            // 
            this.txtpaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpaciente.Location = new System.Drawing.Point(262, 35);
            this.txtpaciente.MaxLength = 30;
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.Size = new System.Drawing.Size(278, 20);
            this.txtpaciente.TabIndex = 87;
            this.txtpaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaciente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "F. Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "N° Reclamo";
            // 
            // txtnum_reclamo
            // 
            this.txtnum_reclamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum_reclamo.Location = new System.Drawing.Point(77, 34);
            this.txtnum_reclamo.MaxLength = 10;
            this.txtnum_reclamo.Name = "txtnum_reclamo";
            this.txtnum_reclamo.Size = new System.Drawing.Size(93, 20);
            this.txtnum_reclamo.TabIndex = 84;
            this.txtnum_reclamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_reclamo_KeyPress);
            // 
            // txtfecha_desde
            // 
            this.txtfecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_desde.Location = new System.Drawing.Point(613, 34);
            this.txtfecha_desde.Name = "txtfecha_desde";
            this.txtfecha_desde.Size = new System.Drawing.Size(83, 20);
            this.txtfecha_desde.TabIndex = 82;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::Ges003M.Properties.Resources.user1;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(779, 91);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(83, 38);
            this.btn_buscar.TabIndex = 81;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Ges003M.Properties.Resources.HeaderGV1024;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(879, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "CONSOLIDADO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(13, 117);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(58, 66);
            this.Ayuda.TabIndex = 106;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "M";
            this.dataGridViewImageColumn1.Image = global::Ges003M.Properties.Resources.llave;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "V";
            this.dataGridViewImageColumn2.Image = global::Ges003M.Properties.Resources.investigacion;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 20;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Image = global::Ges003M.Properties.Resources.HeaderGV1024;
            this.label11.Location = new System.Drawing.Point(11, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(879, 25);
            this.label11.TabIndex = 81;
            this.label11.Text = "LISTADO PACIENTE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(903, 520);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gv_Casos);
            this.Controls.Add(this.Ayuda);
            this.MaximizeBox = false;
            this.Name = "Frm_Visor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Visor";
            this.Load += new System.EventHandler(this.Frm_Visor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Casos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gv_Casos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum_reclamo;
        private System.Windows.Forms.DateTimePicker txtfecha_desde;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtfecha_hasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtetapa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnum_caso;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtderivador;
        private System.Windows.Forms.Button btn_derivador;
        private System.Windows.Forms.Button btn_etapa;
        private System.Windows.Forms.Label label11;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.DataGridViewImageColumn M;
        private System.Windows.Forms.DataGridViewImageColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_CASO;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_RECLAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_CANASTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_CTACTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DERIVADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ESTADOS;
        private System.Windows.Forms.CheckBox ck_fecha;
        private System.Windows.Forms.Label label12;
    }
}