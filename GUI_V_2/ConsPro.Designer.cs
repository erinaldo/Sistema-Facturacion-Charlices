﻿namespace GUI_V_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocina = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1.Location = new System.Drawing.Point(735, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(196, 44);
            this.filtro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            this.filtro.Leave += new System.EventHandler(this.filtro_Leave);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(17, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1796, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.Location = new System.Drawing.Point(592, 38);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // nro_registros
            // 
            this.nro_registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nro_registros.Location = new System.Drawing.Point(1731, 76);
            this.nro_registros.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridVProducto
            // 
            this.dataGridVProducto.AllowUserToAddRows = false;
            this.dataGridVProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridVProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVProducto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridVProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.estatus,
            this.id,
            this.cocina});
            this.dataGridVProducto.EnableHeadersVisualStyles = false;
            this.dataGridVProducto.Location = new System.Drawing.Point(16, 96);
            this.dataGridVProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridVProducto.Name = "dataGridVProducto";
            this.dataGridVProducto.ReadOnly = true;
            this.dataGridVProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridVProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridVProducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVProducto.Size = new System.Drawing.Size(1529, 550);
            this.dataGridVProducto.TabIndex = 113;
            this.dataGridVProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVProducto_CellDoubleClick);
            // 
            // CodPro
            // 
            this.CodPro.FillWeight = 88.0878F;
            this.CodPro.HeaderText = "CÓDIGO";
            this.CodPro.Name = "CodPro";
            this.CodPro.ReadOnly = true;
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPro
            // 
            this.NomPro.FillWeight = 136.6009F;
            this.NomPro.HeaderText = "NOMBRE";
            this.NomPro.Name = "NomPro";
            this.NomPro.ReadOnly = true;
            // 
            // CatPro
            // 
            this.CatPro.FillWeight = 152.5193F;
            this.CatPro.HeaderText = "CATEGORÍA";
            this.CatPro.Name = "CatPro";
            this.CatPro.ReadOnly = true;
            // 
            // PreNor
            // 
            this.PreNor.FillWeight = 104.6534F;
            this.PreNor.HeaderText = "$NORMAL";
            this.PreNor.Name = "PreNor";
            this.PreNor.ReadOnly = true;
            // 
            // PreEmp
            // 
            this.PreEmp.FillWeight = 115.9712F;
            this.PreEmp.HeaderText = "$EMPLEADO";
            this.PreEmp.Name = "PreEmp";
            this.PreEmp.ReadOnly = true;
            // 
            // PreEmpresa
            // 
            this.PreEmpresa.FillWeight = 115.9712F;
            this.PreEmpresa.HeaderText = "$EMPRESA";
            this.PreEmpresa.Name = "PreEmpresa";
            this.PreEmpresa.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.FillWeight = 145.7307F;
            this.Unidad.HeaderText = "UNIDAD-MEDIDA";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // itbis
            // 
            this.itbis.FillWeight = 57.79596F;
            this.itbis.HeaderText = "ITIBS";
            this.itbis.Name = "itbis";
            this.itbis.ReadOnly = true;
            // 
            // CanPro
            // 
            this.CanPro.FillWeight = 73.98438F;
            this.CanPro.HeaderText = "CANTIDAD";
            this.CanPro.Name = "CanPro";
            this.CanPro.ReadOnly = true;
            // 
            // Reorden
            // 
            this.Reorden.FillWeight = 95.47959F;
            this.Reorden.HeaderText = "RE-ORDEN";
            this.Reorden.Name = "Reorden";
            this.Reorden.ReadOnly = true;
            // 
            // TipPro
            // 
            this.TipPro.FillWeight = 58.12479F;
            this.TipPro.HeaderText = "TIPO";
            this.TipPro.Name = "TipPro";
            this.TipPro.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.FillWeight = 69.65758F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
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
            // ConsPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 661);
            this.Controls.Add(this.dataGridVProducto);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ConsPro";
            this.Text = "ConsPro";
            this.Load += new System.EventHandler(this.ConsPro_Load);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.nro_registros, 0);
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
        public System.Windows.Forms.DataGridView dataGridVProducto;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocina;
    }
}