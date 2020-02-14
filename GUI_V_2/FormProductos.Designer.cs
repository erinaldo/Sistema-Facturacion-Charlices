namespace GUI_V_2
{
    partial class FormProductos
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
            this.PreNormal = new GUI_V_2.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PreCom = new GUI_V_2.ErrorTxtBox();
            this.PreFamilia = new GUI_V_2.ErrorTxtBox();
            this.PreMayor = new GUI_V_2.ErrorTxtBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Unidad = new System.Windows.Forms.ComboBox();
            this.FechaVen = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.reorden = new System.Windows.Forms.NumericUpDown();
            this.itbis = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CatPro = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CanExi = new GUI_V_2.ErrorTxtBox();
            this.TipoPro = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reorden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 105);
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Location = new System.Drawing.Point(624, 430);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Location = new System.Drawing.Point(624, 479);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(38, 485);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(34, 61);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(136, 485);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(125, 99);
            this.Nom.Size = new System.Drawing.Size(232, 26);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(624, 380);
            // 
            // PreNormal
            // 
            this.PreNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PreNormal.Limpiar = false;
            this.PreNormal.Location = new System.Drawing.Point(138, 230);
            this.PreNormal.Name = "PreNormal";
            this.PreNormal.Size = new System.Drawing.Size(80, 26);
            this.PreNormal.TabIndex = 107;
            this.PreNormal.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(34, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "FECHA VENCIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(37, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "$ VENTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(36, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "$ COMPRA";
            // 
            // PreCom
            // 
            this.PreCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PreCom.Limpiar = false;
            this.PreCom.Location = new System.Drawing.Point(138, 270);
            this.PreCom.Name = "PreCom";
            this.PreCom.Size = new System.Drawing.Size(80, 26);
            this.PreCom.TabIndex = 111;
            this.PreCom.Validar = true;
            // 
            // PreFamilia
            // 
            this.PreFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PreFamilia.Limpiar = false;
            this.PreFamilia.Location = new System.Drawing.Point(224, 230);
            this.PreFamilia.Name = "PreFamilia";
            this.PreFamilia.Size = new System.Drawing.Size(80, 26);
            this.PreFamilia.TabIndex = 112;
            this.PreFamilia.Validar = true;
            // 
            // PreMayor
            // 
            this.PreMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PreMayor.Limpiar = false;
            this.PreMayor.Location = new System.Drawing.Point(310, 230);
            this.PreMayor.Name = "PreMayor";
            this.PreMayor.Size = new System.Drawing.Size(80, 26);
            this.PreMayor.TabIndex = 113;
            this.PreMayor.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "NORMAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "FAMILIA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 116;
            this.label9.Text = "MAYOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(36, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 117;
            this.label10.Text = "VENTA POR";
            // 
            // Unidad
            // 
            this.Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Unidad.FormattingEnabled = true;
            this.Unidad.Items.AddRange(new object[] {
            "UNIDAD",
            "LIBRAS",
            "GALONES",
            "CAJA",
            "METROS",
            "QUILOGRAMOS",
            "ONZAS"});
            this.Unidad.Location = new System.Drawing.Point(148, 310);
            this.Unidad.Name = "Unidad";
            this.Unidad.Size = new System.Drawing.Size(166, 28);
            this.Unidad.TabIndex = 118;
            // 
            // FechaVen
            // 
            this.FechaVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FechaVen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVen.Location = new System.Drawing.Point(224, 175);
            this.FechaVen.Name = "FechaVen";
            this.FechaVen.Size = new System.Drawing.Size(133, 26);
            this.FechaVen.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(37, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 120;
            this.label11.Text = "RE-ORDEN:";
            // 
            // reorden
            // 
            this.reorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reorden.Location = new System.Drawing.Point(139, 439);
            this.reorden.Name = "reorden";
            this.reorden.Size = new System.Drawing.Size(73, 26);
            this.reorden.TabIndex = 121;
            // 
            // itbis
            // 
            this.itbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itbis.FormattingEnabled = true;
            this.itbis.Items.AddRange(new object[] {
            "18%",
            "2%"});
            this.itbis.Location = new System.Drawing.Point(138, 354);
            this.itbis.Name = "itbis";
            this.itbis.Size = new System.Drawing.Size(166, 28);
            this.itbis.TabIndex = 123;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(36, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 122;
            this.label12.Text = "ITBIS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(34, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 124;
            this.label13.Text = "CATEGORIA";
            // 
            // CatPro
            // 
            this.CatPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CatPro.FormattingEnabled = true;
            this.CatPro.Location = new System.Drawing.Point(148, 136);
            this.CatPro.Name = "CatPro";
            this.CatPro.Size = new System.Drawing.Size(209, 28);
            this.CatPro.TabIndex = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(38, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 126;
            this.label14.Text = "CANTIDAD";
            // 
            // CanExi
            // 
            this.CanExi.Enabled = false;
            this.CanExi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CanExi.Limpiar = false;
            this.CanExi.Location = new System.Drawing.Point(138, 401);
            this.CanExi.Name = "CanExi";
            this.CanExi.Size = new System.Drawing.Size(119, 26);
            this.CanExi.TabIndex = 127;
            this.CanExi.Validar = true;
            // 
            // TipoPro
            // 
            this.TipoPro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TipoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TipoPro.FormattingEnabled = true;
            this.TipoPro.Items.AddRange(new object[] {
            "INVENTARIO",
            "SERVICIO"});
            this.TipoPro.Location = new System.Drawing.Point(535, 97);
            this.TipoPro.Name = "TipoPro";
            this.TipoPro.Size = new System.Drawing.Size(209, 28);
            this.TipoPro.TabIndex = 129;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(363, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 20);
            this.label15.TabIndex = 130;
            this.label15.Text = "TIPO DE PRODUCTO";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 536);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TipoPro);
            this.Controls.Add(this.CanExi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CatPro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.itbis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reorden);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FechaVen);
            this.Controls.Add(this.Unidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PreMayor);
            this.Controls.Add(this.PreFamilia);
            this.Controls.Add(this.PreCom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreNormal);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.PreNormal, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.PreCom, 0);
            this.Controls.SetChildIndex(this.PreFamilia, 0);
            this.Controls.SetChildIndex(this.PreMayor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.Unidad, 0);
            this.Controls.SetChildIndex(this.FechaVen, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.reorden, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.itbis, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.CatPro, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.CanExi, 0);
            this.Controls.SetChildIndex(this.TipoPro, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            ((System.ComponentModel.ISupportInitialize)(this.reorden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox PreNormal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private ErrorTxtBox PreCom;
        private ErrorTxtBox PreFamilia;
        private ErrorTxtBox PreMayor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Unidad;
        private System.Windows.Forms.DateTimePicker FechaVen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown reorden;
        private System.Windows.Forms.ComboBox itbis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CatPro;
        private System.Windows.Forms.Label label14;
        private ErrorTxtBox CanExi;
        private System.Windows.Forms.ComboBox TipoPro;
        private System.Windows.Forms.Label label15;
    }
}