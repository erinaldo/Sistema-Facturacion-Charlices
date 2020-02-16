namespace GUI_V_2.Consultas
{
    partial class ConsCli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.CodCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.Text = "CLIENTES";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(995, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // filtro
            // 
            this.filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtro.Location = new System.Drawing.Point(189, 145);
            this.filtro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(11, 151);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1221, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(807, 139);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(667, 139);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCli,
            this.NomCli,
            this.CedCli,
            this.TelCli,
            this.DirCli,
            this.TipCli,
            this.CorCli,
            this.estatus});
            this.dataGridClientes.Location = new System.Drawing.Point(12, 195);
            this.dataGridClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(1245, 460);
            this.dataGridClientes.TabIndex = 113;
            // 
            // CodCli
            // 
            this.CodCli.FillWeight = 51.84586F;
            this.CodCli.HeaderText = "CÓDIGO";
            this.CodCli.Name = "CodCli";
            this.CodCli.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomCli
            // 
            this.NomCli.FillWeight = 162.959F;
            this.NomCli.HeaderText = "NOMBRE";
            this.NomCli.Name = "NomCli";
            // 
            // CedCli
            // 
            this.CedCli.FillWeight = 101.5227F;
            this.CedCli.HeaderText = "CLA/RCN";
            this.CedCli.Name = "CedCli";
            // 
            // TelCli
            // 
            this.TelCli.FillWeight = 88.5353F;
            this.TelCli.HeaderText = "TELÉFONO";
            this.TelCli.Name = "TelCli";
            // 
            // DirCli
            // 
            this.DirCli.FillWeight = 184.5884F;
            this.DirCli.HeaderText = "DIRECCIÓN";
            this.DirCli.Name = "DirCli";
            // 
            // TipCli
            // 
            this.TipCli.FillWeight = 53.18349F;
            this.TipCli.HeaderText = "TIPO";
            this.TipCli.Name = "TipCli";
            // 
            // CorCli
            // 
            this.CorCli.FillWeight = 104.9513F;
            this.CorCli.HeaderText = "CORREO";
            this.CorCli.Name = "CorCli";
            // 
            // estatus
            // 
            this.estatus.FillWeight = 52.41302F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            // 
            // ConsCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 671);
            this.Controls.Add(this.dataGridClientes);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ConsCli";
            this.Text = "W";
            this.Load += new System.EventHandler(this.ConsCli_Load);
            this.Controls.SetChildIndex(this.btn_editar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.dataGridClientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}