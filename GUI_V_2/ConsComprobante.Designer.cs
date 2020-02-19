namespace GUI_V_2
{
    partial class ConsComprobante
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TipCom = new System.Windows.Forms.ComboBox();
            this.CodSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.Text = "COMPROBANTES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 67);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(144, 72);
            this.filtro.Size = new System.Drawing.Size(218, 35);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(10, 82);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1009, 6);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.Location = new System.Drawing.Point(683, 67);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.Location = new System.Drawing.Point(598, 67);
            this.btn_nuevo.Size = new System.Drawing.Size(79, 40);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodSer,
            this.NomPro,
            this.NumOrden,
            this.DesComp,
            this.FechaOrden,
            this.FechaLimite,
            this.Usados,
            this.CantDisp,
            this.estatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 402);
            this.dataGridView1.TabIndex = 114;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(368, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 28);
            this.comboBox2.TabIndex = 119;
            this.comboBox2.Text = "ORDEN";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "DISPONIBLES",
            "USADOS",
            "VENCIDOS",
            "TODOS"});
            this.comboBox3.Location = new System.Drawing.Point(368, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(146, 28);
            this.comboBox3.TabIndex = 120;
            this.comboBox3.Text = "FILTRAR POR...";
            // 
            // TipCom
            // 
            this.TipCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipCom.FormattingEnabled = true;
            this.TipCom.Items.AddRange(new object[] {
            "Factura de Crédito Fiscal (B01)",
            "Factura de Consumo (B02)",
            "Notas de Débito  (B03)",
            "Notas de Crédito (B04)",
            "Comprobantes de compras (B11)",
            "Registro único de ingresos (B12)",
            "Registro de gastos menores (B13)",
            "Regímenes especiales de tributación (B14)",
            "Comprobantes Gubernamentales (B15)"});
            this.TipCom.Location = new System.Drawing.Point(368, 81);
            this.TipCom.Name = "TipCom";
            this.TipCom.Size = new System.Drawing.Size(224, 26);
            this.TipCom.TabIndex = 121;
            this.TipCom.Text = "TIPO";
            // 
            // CodSer
            // 
            this.CodSer.FillWeight = 75.75062F;
            this.CodSer.HeaderText = "Serie";
            this.CodSer.Name = "CodSer";
            this.CodSer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPro
            // 
            this.NomPro.FillWeight = 135.3797F;
            this.NomPro.HeaderText = "TIPO";
            this.NomPro.Name = "NomPro";
            // 
            // NumOrden
            // 
            this.NumOrden.FillWeight = 97.94966F;
            this.NumOrden.HeaderText = "# ORDEN";
            this.NumOrden.Name = "NumOrden";
            // 
            // DesComp
            // 
            this.DesComp.FillWeight = 88.10159F;
            this.DesComp.HeaderText = "DESCRIPCION";
            this.DesComp.Name = "DesComp";
            // 
            // FechaOrden
            // 
            this.FechaOrden.FillWeight = 101.9623F;
            this.FechaOrden.HeaderText = "FECHA ORDEN";
            this.FechaOrden.Name = "FechaOrden";
            // 
            // FechaLimite
            // 
            this.FechaLimite.FillWeight = 98.91788F;
            this.FechaLimite.HeaderText = "FECHA LIMITE";
            this.FechaLimite.Name = "FechaLimite";
            // 
            // Usados
            // 
            this.Usados.FillWeight = 83.34077F;
            this.Usados.HeaderText = "USADOS";
            this.Usados.Name = "Usados";
            // 
            // CantDisp
            // 
            this.CantDisp.FillWeight = 105.1961F;
            this.CantDisp.HeaderText = "DISPONIBLES";
            this.CantDisp.Name = "CantDisp";
            // 
            // estatus
            // 
            this.estatus.FillWeight = 81.20193F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            // 
            // ConsComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 527);
            this.Controls.Add(this.TipCom);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsComprobante";
            this.Text = "ConsComprobante";
            this.Controls.SetChildIndex(this.btn_editar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.TipCom, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox TipCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}