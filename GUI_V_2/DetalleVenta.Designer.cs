namespace GUI_V_2
{
    partial class DetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleVenta));
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItbPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_totalPro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numfact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AllowUserToAddRows = false;
            this.dataGridViewProducto.AllowUserToDeleteRows = false;
            this.dataGridViewProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.NomPro,
            this.PrePro,
            this.CanPro,
            this.SubPro,
            this.ItbPro,
            this.TotalPro,
            this.id,
            this.cocina});
            this.dataGridViewProducto.EnableHeadersVisualStyles = false;
            this.dataGridViewProducto.Location = new System.Drawing.Point(17, 101);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.ReadOnly = true;
            this.dataGridViewProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridViewProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducto.Size = new System.Drawing.Size(944, 268);
            this.dataGridViewProducto.TabIndex = 1;
            // 
            // CodPro
            // 
            this.CodPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodPro.FillWeight = 61.19339F;
            this.CodPro.Frozen = true;
            this.CodPro.HeaderText = "CÓDIGO";
            this.CodPro.Name = "CodPro";
            this.CodPro.ReadOnly = true;
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodPro.Width = 80;
            // 
            // NomPro
            // 
            this.NomPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomPro.FillWeight = 168.1775F;
            this.NomPro.Frozen = true;
            this.NomPro.HeaderText = "NOMBRE";
            this.NomPro.Name = "NomPro";
            this.NomPro.ReadOnly = true;
            this.NomPro.Width = 250;
            // 
            // PrePro
            // 
            this.PrePro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrePro.FillWeight = 91.37045F;
            this.PrePro.Frozen = true;
            this.PrePro.HeaderText = "PRECIO";
            this.PrePro.Name = "PrePro";
            this.PrePro.ReadOnly = true;
            // 
            // CanPro
            // 
            this.CanPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CanPro.FillWeight = 62.6336F;
            this.CanPro.Frozen = true;
            this.CanPro.HeaderText = "CANTIDAD";
            this.CanPro.Name = "CanPro";
            this.CanPro.ReadOnly = true;
            // 
            // SubPro
            // 
            this.SubPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubPro.FillWeight = 108.3121F;
            this.SubPro.Frozen = true;
            this.SubPro.HeaderText = "SUBTOTAL";
            this.SubPro.Name = "SubPro";
            this.SubPro.ReadOnly = true;
            // 
            // ItbPro
            // 
            this.ItbPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItbPro.Frozen = true;
            this.ItbPro.HeaderText = "ITBIS";
            this.ItbPro.Name = "ItbPro";
            this.ItbPro.ReadOnly = true;
            // 
            // TotalPro
            // 
            this.TotalPro.FillWeight = 108.3121F;
            this.TotalPro.HeaderText = "TOTAL";
            this.TotalPro.Name = "TotalPro";
            this.TotalPro.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cocina
            // 
            this.cocina.HeaderText = "Cocina";
            this.cocina.Name = "cocina";
            this.cocina.ReadOnly = true;
            this.cocina.Visible = false;
            // 
            // txt_totalPro
            // 
            this.txt_totalPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_totalPro.AutoSize = true;
            this.txt_totalPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPro.Location = new System.Drawing.Point(12, 372);
            this.txt_totalPro.Name = "txt_totalPro";
            this.txt_totalPro.Size = new System.Drawing.Size(243, 25);
            this.txt_totalPro.TabIndex = 11;
            this.txt_totalPro.Text = "TOTAL PRODUCTOS: 0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "DETALLE DE VENTA";
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volver.Location = new System.Drawing.Point(756, 12);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(200, 64);
            this.btn_volver.TabIndex = 66;
            this.btn_volver.TabStop = false;
            this.btn_volver.Text = "SALIR [ESC]";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "FACTURA ACTUAL:";
            // 
            // txt_numfact
            // 
            this.txt_numfact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_numfact.AutoSize = true;
            this.txt_numfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numfact.Location = new System.Drawing.Point(175, 78);
            this.txt_numfact.Name = "txt_numfact";
            this.txt_numfact.Size = new System.Drawing.Size(18, 20);
            this.txt_numfact.TabIndex = 68;
            this.txt_numfact.Text = "0";
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 406);
            this.Controls.Add(this.txt_numfact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_totalPro);
            this.Controls.Add(this.dataGridViewProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleVenta";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DetalleVenta_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItbPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txt_totalPro;
        public System.Windows.Forms.Label txt_numfact;
    }
}