namespace GUI_V_2
{
    partial class FormComprabantes
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
            this.label3 = new System.Windows.Forms.Label();
            this.ComUsa = new GUI_V_2.ErrorTxtBox();
            this.TipCom = new System.Windows.Forms.ComboBox();
            this.FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComDisp = new GUI_V_2.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NumOrden = new GUI_V_2.ErrorTxtBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.Text = "COMROBANTES";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.Text = "DESCRIPCION";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Location = new System.Drawing.Point(921, 455);
            this.bnt_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Location = new System.Drawing.Point(921, 507);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(44, 285);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(45, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.Text = "CODIGO SERIE";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(132, 282);
            this.estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estado.Size = new System.Drawing.Size(135, 28);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(179, 133);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nom.Size = new System.Drawing.Size(252, 26);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(179, 95);
            this.Codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codigo.Size = new System.Drawing.Size(252, 26);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(44, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "TIPO COMPROBANTE";
            // 
            // ComUsa
            // 
            this.ComUsa.Enabled = false;
            this.ComUsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComUsa.Limpiar = false;
            this.ComUsa.Location = new System.Drawing.Point(132, 250);
            this.ComUsa.Name = "ComUsa";
            this.ComUsa.Size = new System.Drawing.Size(100, 26);
            this.ComUsa.TabIndex = 108;
            this.ComUsa.Text = "0";
            this.ComUsa.Validar = true;
            this.ComUsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComUsa_KeyPress);
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
            this.TipCom.Location = new System.Drawing.Point(222, 55);
            this.TipCom.Name = "TipCom";
            this.TipCom.Size = new System.Drawing.Size(296, 26);
            this.TipCom.TabIndex = 109;
            // 
            // FechaLimite
            // 
            this.FechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaLimite.Location = new System.Drawing.Point(179, 171);
            this.FechaLimite.Name = "FechaLimite";
            this.FechaLimite.Size = new System.Drawing.Size(128, 26);
            this.FechaLimite.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "FECHA LIMITE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(44, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "USADOS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(44, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "DISPONIBLES";
            // 
            // ComDisp
            // 
            this.ComDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComDisp.Limpiar = false;
            this.ComDisp.Location = new System.Drawing.Point(167, 210);
            this.ComDisp.Name = "ComDisp";
            this.ComDisp.Size = new System.Drawing.Size(100, 26);
            this.ComDisp.TabIndex = 113;
            this.ComDisp.Validar = true;
            this.ComDisp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComUsa_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.DesPro,
            this.CanPro,
            this.FechaLim,
            this.estatus});
            this.dataGridView1.Location = new System.Drawing.Point(273, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(640, 349);
            this.dataGridView1.TabIndex = 115;
            // 
            // CodPro
            // 
            this.CodPro.FillWeight = 61.85785F;
            this.CodPro.HeaderText = "ORDEN";
            this.CodPro.Name = "CodPro";
            this.CodPro.ReadOnly = true;
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomPro
            // 
            this.NomPro.FillWeight = 198.0502F;
            this.NomPro.HeaderText = "TIPO";
            this.NomPro.Name = "NomPro";
            this.NomPro.ReadOnly = true;
            // 
            // DesPro
            // 
            this.DesPro.FillWeight = 111.3903F;
            this.DesPro.HeaderText = "SERIE";
            this.DesPro.Name = "DesPro";
            this.DesPro.ReadOnly = true;
            // 
            // CanPro
            // 
            this.CanPro.FillWeight = 67.61398F;
            this.CanPro.HeaderText = "FECHA ORDEN";
            this.CanPro.Name = "CanPro";
            this.CanPro.ReadOnly = true;
            // 
            // FechaLim
            // 
            this.FechaLim.FillWeight = 69.53754F;
            this.FechaLim.HeaderText = "FECHA LIMITE";
            this.FechaLim.Name = "FechaLim";
            this.FechaLim.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.FillWeight = 100.85F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 28);
            this.comboBox1.TabIndex = 116;
            this.comboBox1.Text = "FILTRAR NRO. ORDEN";
            // 
            // NumOrden
            // 
            this.NumOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumOrden.Limpiar = false;
            this.NumOrden.Location = new System.Drawing.Point(640, 55);
            this.NumOrden.Name = "NumOrden";
            this.NumOrden.Size = new System.Drawing.Size(100, 26);
            this.NumOrden.TabIndex = 117;
            this.NumOrden.Validar = true;
            this.NumOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOrden_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(524, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 118;
            this.label8.Text = "NRO. ORDEN";
            // 
            // FormComprabantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 559);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumOrden);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComDisp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaLimite);
            this.Controls.Add(this.TipCom);
            this.Controls.Add(this.ComUsa);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComprabantes";
            this.Text = "Comprabantes";
            this.Load += new System.EventHandler(this.FormComprabantes_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ComUsa, 0);
            this.Controls.SetChildIndex(this.TipCom, 0);
            this.Controls.SetChildIndex(this.FechaLimite, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.ComDisp, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.NumOrden, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private ErrorTxtBox ComUsa;
        private System.Windows.Forms.ComboBox TipCom;
        private System.Windows.Forms.DateTimePicker FechaLimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ErrorTxtBox ComDisp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ErrorTxtBox NumOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLim;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}