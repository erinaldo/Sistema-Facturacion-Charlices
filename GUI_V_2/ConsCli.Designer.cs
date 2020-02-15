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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.Text = "CLIENTES";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(746, 113);
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorTxtBox1.Location = new System.Drawing.Point(142, 118);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(8, 123);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(916, 9);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.Location = new System.Drawing.Point(605, 113);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.Location = new System.Drawing.Point(500, 113);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.NomPro,
            this.CedCli,
            this.PrePro,
            this.CanPro,
            this.DesPro,
            this.TotalPro,
            this.estatus});
            this.dataGridView1.Location = new System.Drawing.Point(11, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 374);
            this.dataGridView1.TabIndex = 111;
            // 
            // CodPro
            // 
            this.CodPro.FillWeight = 51.84586F;
            this.CodPro.HeaderText = "CODIGO";
            this.CodPro.Name = "CodPro";
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPro
            // 
            this.NomPro.FillWeight = 162.959F;
            this.NomPro.HeaderText = "NOMBRE";
            this.NomPro.Name = "NomPro";
            // 
            // CedCli
            // 
            this.CedCli.FillWeight = 101.5227F;
            this.CedCli.HeaderText = "CLA/RCN";
            this.CedCli.Name = "CedCli";
            // 
            // PrePro
            // 
            this.PrePro.FillWeight = 88.5353F;
            this.PrePro.HeaderText = "TELEFONO";
            this.PrePro.Name = "PrePro";
            // 
            // CanPro
            // 
            this.CanPro.FillWeight = 184.5884F;
            this.CanPro.HeaderText = "DIRECCION";
            this.CanPro.Name = "CanPro";
            // 
            // DesPro
            // 
            this.DesPro.FillWeight = 53.18349F;
            this.DesPro.HeaderText = "TIPO";
            this.DesPro.Name = "DesPro";
            // 
            // TotalPro
            // 
            this.TotalPro.FillWeight = 104.9513F;
            this.TotalPro.HeaderText = "CORREO";
            this.TotalPro.Name = "TotalPro";
            // 
            // estatus
            // 
            this.estatus.FillWeight = 52.41302F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            // 
            // ConsCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 545);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsCli";
            this.Text = "W";
            this.Controls.SetChildIndex(this.btn_editar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.errorTxtBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}