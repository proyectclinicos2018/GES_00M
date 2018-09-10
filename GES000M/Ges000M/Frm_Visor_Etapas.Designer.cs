namespace Ges003M
{
    partial class Frm_Visor_Etapas
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
            this.label3 = new System.Windows.Forms.Label();
            this.grilla_etapa = new System.Windows.Forms.DataGridView();
            this.NOM_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_SUB_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_FILA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_SUB_ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_etapa)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Ges003M.Properties.Resources.HeaderGV1024;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "LISTADO ETAPAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grilla_etapa
            // 
            this.grilla_etapa.AllowUserToAddRows = false;
            this.grilla_etapa.AllowUserToDeleteRows = false;
            this.grilla_etapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_etapa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOM_ETAPA,
            this.NOM_SUB_ETAPA,
            this.ESTADO,
            this.ID_FILA,
            this.COD_ETAPA,
            this.COD_SUB_ETAPA,
            this.COD_ESTADO});
            this.grilla_etapa.Location = new System.Drawing.Point(3, 37);
            this.grilla_etapa.Name = "grilla_etapa";
            this.grilla_etapa.ReadOnly = true;
            this.grilla_etapa.RowHeadersVisible = false;
            this.grilla_etapa.Size = new System.Drawing.Size(562, 263);
            this.grilla_etapa.TabIndex = 82;
            this.grilla_etapa.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_etapa_CellPainting);
            // 
            // NOM_ETAPA
            // 
            this.NOM_ETAPA.DataPropertyName = "NOM_ETAPA";
            this.NOM_ETAPA.HeaderText = "Etapa";
            this.NOM_ETAPA.Name = "NOM_ETAPA";
            this.NOM_ETAPA.ReadOnly = true;
            this.NOM_ETAPA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOM_ETAPA.Width = 200;
            // 
            // NOM_SUB_ETAPA
            // 
            this.NOM_SUB_ETAPA.DataPropertyName = "NOM_SUB_ETAPA";
            this.NOM_SUB_ETAPA.HeaderText = "Sub Etapa";
            this.NOM_SUB_ETAPA.Name = "NOM_SUB_ETAPA";
            this.NOM_SUB_ETAPA.ReadOnly = true;
            this.NOM_SUB_ETAPA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOM_SUB_ETAPA.Width = 200;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ID_FILA
            // 
            this.ID_FILA.DataPropertyName = "ID_FILA";
            this.ID_FILA.HeaderText = "Id_fila";
            this.ID_FILA.Name = "ID_FILA";
            this.ID_FILA.ReadOnly = true;
            this.ID_FILA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_FILA.Visible = false;
            // 
            // COD_ETAPA
            // 
            this.COD_ETAPA.DataPropertyName = "COD_ETAPA";
            this.COD_ETAPA.HeaderText = "cod_etapa";
            this.COD_ETAPA.Name = "COD_ETAPA";
            this.COD_ETAPA.ReadOnly = true;
            this.COD_ETAPA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ETAPA.Visible = false;
            // 
            // COD_SUB_ETAPA
            // 
            this.COD_SUB_ETAPA.DataPropertyName = "COD_SUB_ETAPA";
            this.COD_SUB_ETAPA.HeaderText = "cod_sub_etapa";
            this.COD_SUB_ETAPA.Name = "COD_SUB_ETAPA";
            this.COD_SUB_ETAPA.ReadOnly = true;
            this.COD_SUB_ETAPA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_SUB_ETAPA.Visible = false;
            // 
            // COD_ESTADO
            // 
            this.COD_ESTADO.DataPropertyName = "COD_ESTADO";
            this.COD_ESTADO.HeaderText = "Cod_estado";
            this.COD_ESTADO.Name = "COD_ESTADO";
            this.COD_ESTADO.ReadOnly = true;
            this.COD_ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ESTADO.Visible = false;
            // 
            // Frm_Visor_Etapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 312);
            this.Controls.Add(this.grilla_etapa);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Visor_Etapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor Etapas";
            this.Load += new System.EventHandler(this.Frm_Visor_Etapas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_etapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla_etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_SUB_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FILA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SUB_ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ESTADO;
    }
}