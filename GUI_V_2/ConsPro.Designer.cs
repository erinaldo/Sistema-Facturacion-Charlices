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
            this.dataGridVProducto = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreNor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.Text = "PRODUCTOS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1395, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // filtro
            // 
            this.filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtro.Location = new System.Drawing.Point(195, 133);
            this.filtro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(16, 145);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Text = "Filtrar búsqueda:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1621, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(1207, 127);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(1067, 127);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dataGridVProducto
            // 
            this.dataGridVProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.NomPro,
            this.CatPro,
            this.PreNor,
            this.PreEmp,
            this.PreEmpresa,
            this.Unidad,
            this.itbis,
            this.CanPro,
            this.Reorden,
            this.TipPro,
            this.estatus});
            this.dataGridVProducto.Location = new System.Drawing.Point(16, 183);
            this.dataGridVProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridVProducto.Name = "dataGridVProducto";
            this.dataGridVProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridVProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVProducto.Size = new System.Drawing.Size(1645, 463);
            this.dataGridVProducto.TabIndex = 113;
            // 
            // CodPro
            // 
            this.CodPro.FillWeight = 75.9566F;
            this.CodPro.HeaderText = "CÓDIGO";
            this.CodPro.Name = "CodPro";
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPro
            // 
            this.NomPro.FillWeight = 117.7887F;
            this.NomPro.HeaderText = "NOMBRE";
            this.NomPro.Name = "NomPro";
            // 
            // CatPro
            // 
            this.CatPro.FillWeight = 131.5148F;
            this.CatPro.HeaderText = "CATEGORÍA";
            this.CatPro.Name = "CatPro";
            // 
            // PreNor
            // 
            this.PreNor.FillWeight = 90.24084F;
            this.PreNor.HeaderText = "$NORMAL";
            this.PreNor.Name = "PreNor";
            // 
            // PreEmp
            // 
            this.PreEmp.HeaderText = "$EMPLEADO";
            this.PreEmp.Name = "PreEmp";
            this.PreEmp.ReadOnly = true;
            // 
            // PreEmpresa
            // 
            this.PreEmpresa.HeaderText = "$EMPRESA";
            this.PreEmpresa.Name = "PreEmpresa";
            this.PreEmpresa.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.FillWeight = 125.6611F;
            this.Unidad.HeaderText = "UNIDAD-MEDIDA";
            this.Unidad.Name = "Unidad";
            // 
            // itbis
            // 
            this.itbis.FillWeight = 76.79168F;
            this.itbis.HeaderText = "ITIBS";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 661);
            this.Controls.Add(this.dataGridVProducto);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ConsPro";
            this.Text = "ConsPro";
            this.Load += new System.EventHandler(this.ConsPro_Load);
            this.Controls.SetChildIndex(this.btn_editar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.dataGridVProducto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreNor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}