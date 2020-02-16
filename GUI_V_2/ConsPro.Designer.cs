namespace GUI_V_2
{
    partial class ConsPro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreVen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentaPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.Text = "PRODUCTOS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1046, 103);
            // 
            // errorTxtBox1
            // 
            this.filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtro.Location = new System.Drawing.Point(146, 108);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 118);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1216, 9);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(905, 103);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(800, 103);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.NomPro,
            this.DesPro,
            this.PrePro,
            this.PreVen,
            this.PreCom,
            this.VentaPor,
            this.itbis,
            this.CanPro,
            this.Reorden,
            this.TipPro,
            this.estatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 376);
            this.dataGridView1.TabIndex = 113;
            // 
            // CodPro
            // 
            this.CodPro.FillWeight = 75.9566F;
            this.CodPro.HeaderText = "CODIGO";
            this.CodPro.Name = "CodPro";
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPro
            // 
            this.NomPro.FillWeight = 117.7887F;
            this.NomPro.HeaderText = "NOMBRE";
            this.NomPro.Name = "NomPro";
            // 
            // DesPro
            // 
            this.DesPro.FillWeight = 131.5148F;
            this.DesPro.HeaderText = "CATEGORIA";
            this.DesPro.Name = "DesPro";
            // 
            // PrePro
            // 
            this.PrePro.FillWeight = 91.71454F;
            this.PrePro.HeaderText = "FECHA VENCIMIENTO";
            this.PrePro.Name = "PrePro";
            // 
            // PreVen
            // 
            this.PreVen.FillWeight = 90.24084F;
            this.PreVen.HeaderText = "$ VENTA";
            this.PreVen.Name = "PreVen";
            // 
            // PreCom
            // 
            this.PreCom.FillWeight = 93.70741F;
            this.PreCom.HeaderText = "$ COMPRA";
            this.PreCom.Name = "PreCom";
            // 
            // VentaPor
            // 
            this.VentaPor.FillWeight = 125.6611F;
            this.VentaPor.HeaderText = "VENTA POR";
            this.VentaPor.Name = "VentaPor";
            // 
            // itbis
            // 
            this.itbis.FillWeight = 76.79168F;
            this.itbis.HeaderText = "ITBS";
            this.itbis.Name = "itbis";
            // 
            // CanPro
            // 
            this.CanPro.FillWeight = 107.3515F;
            this.CanPro.HeaderText = "CANTIDAD";
            this.CanPro.Name = "CanPro";
            // 
            // Reorden
            // 
            this.Reorden.FillWeight = 82.33041F;
            this.Reorden.HeaderText = "RE-ORDEN";
            this.Reorden.Name = "Reorden";
            // 
            // TipPro
            // 
            this.TipPro.FillWeight = 115.5709F;
            this.TipPro.HeaderText = "TIPO";
            this.TipPro.Name = "TipPro";
            // 
            // estatus
            // 
            this.estatus.FillWeight = 91.37048F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            // 
            // ConsPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 537);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsPro";
            this.Text = "ConsPro";
            this.Controls.SetChildIndex(this.btn_editar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DesPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreVen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}