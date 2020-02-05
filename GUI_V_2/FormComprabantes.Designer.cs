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
            this.label3 = new System.Windows.Forms.Label();
            this.ComUsa = new GUI_V_2.ErrorTxtBox();
            this.TipCom = new System.Windows.Forms.ComboBox();
            this.FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComDisp = new GUI_V_2.ErrorTxtBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.Text = "COMROBANTES";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.Text = "DESCRIPCION";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(51, 290);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(45, 98);
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.Text = "CODIGO SERIE";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(132, 287);
            this.estado.Size = new System.Drawing.Size(135, 28);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(179, 133);
            this.Nom.Size = new System.Drawing.Size(252, 26);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(179, 95);
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
            this.ComUsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComUsa.Location = new System.Drawing.Point(167, 248);
            this.ComUsa.Name = "ComUsa";
            this.ComUsa.Size = new System.Drawing.Size(100, 26);
            this.ComUsa.TabIndex = 108;
            this.ComUsa.Validar = true;
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
            this.FechaLimite.Location = new System.Drawing.Point(171, 171);
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
            this.label6.Location = new System.Drawing.Point(44, 251);
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
            this.ComDisp.Location = new System.Drawing.Point(167, 210);
            this.ComDisp.Name = "ComDisp";
            this.ComDisp.Size = new System.Drawing.Size(100, 26);
            this.ComDisp.TabIndex = 113;
            this.ComDisp.Validar = true;
            // 
            // Comprabantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComDisp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaLimite);
            this.Controls.Add(this.TipCom);
            this.Controls.Add(this.ComUsa);
            this.Controls.Add(this.label3);
            this.Name = "Comprabantes";
            this.Text = "Comprabantes";
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
    }
}