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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.Text = "CLIENTES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(142, 33);
            this.filtro.Margin = new System.Windows.Forms.Padding(4);
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(13, 43);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(916, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.Location = new System.Drawing.Point(439, 28);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // nro_registros
            // 
            this.nro_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nro_registros.Location = new System.Drawing.Point(878, 55);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 28);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
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
            this.dataGridClientes.Location = new System.Drawing.Point(12, 75);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(934, 458);
            this.dataGridClientes.TabIndex = 113;
            this.dataGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellDoubleClick);
            // 
            // CodCli
            // 
            this.CodCli.FillWeight = 53.67585F;
            this.CodCli.HeaderText = "CÓDIGO";
            this.CodCli.Name = "CodCli";
            this.CodCli.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NomCli
            // 
            this.NomCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCli.FillWeight = 165.4784F;
            this.NomCli.HeaderText = "NOMBRE";
            this.NomCli.Name = "NomCli";
            // 
            // CedCli
            // 
            this.CedCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CedCli.FillWeight = 103.0923F;
            this.CedCli.HeaderText = "CLA/RCN";
            this.CedCli.Name = "CedCli";
            // 
            // TelCli
            // 
            this.TelCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TelCli.FillWeight = 89.90408F;
            this.TelCli.HeaderText = "TELÉFONO";
            this.TelCli.Name = "TelCli";
            // 
            // DirCli
            // 
            this.DirCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirCli.FillWeight = 187.4422F;
            this.DirCli.HeaderText = "DIRECCIÓN";
            this.DirCli.Name = "DirCli";
            // 
            // TipCli
            // 
            this.TipCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipCli.FillWeight = 40.60909F;
            this.TipCli.HeaderText = "TIPO";
            this.TipCli.Name = "TipCli";
            // 
            // CorCli
            // 
            this.CorCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CorCli.FillWeight = 106.5739F;
            this.CorCli.HeaderText = "CORREO";
            this.CorCli.Name = "CorCli";
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estatus.FillWeight = 53.22334F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            // 
            // ConsCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 545);
            this.Controls.Add(this.dataGridClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsCli";
            this.Text = "W";
            this.Load += new System.EventHandler(this.ConsCli_Load);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.nro_registros, 0);
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
        public System.Windows.Forms.DataGridView dataGridClientes;
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