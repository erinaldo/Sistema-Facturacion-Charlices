namespace GUI_V_2
{
    partial class PanelCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCobro));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pago = new GUI_V_2.ErrorTxtBox();
            this.txt_monto = new GUI_V_2.ErrorTxtBox();
            this.txt_devuelto = new GUI_V_2.ErrorTxtBox();
            this.c_metodopago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_dosmil = new System.Windows.Forms.Panel();
            this.panel_quiniento = new System.Windows.Forms.Panel();
            this.panel_mil = new System.Windows.Forms.Panel();
            this.panel_dociento = new System.Windows.Forms.Panel();
            this.panel_cien = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 94;
            this.label2.Text = "PANEL DE COBRO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_pago);
            this.panel1.Controls.Add(this.txt_monto);
            this.panel1.Controls.Add(this.txt_devuelto);
            this.panel1.Controls.Add(this.c_metodopago);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 333);
            this.panel1.TabIndex = 95;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(708, 142);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(88, 37);
            this.btn_limpiar.TabIndex = 100;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 107;
            this.label6.Text = "Monto a pagar";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 106;
            this.label5.Text = "Pago con";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 105;
            this.label4.Text = "Devuelta";
            // 
            // txt_pago
            // 
            this.txt_pago.BackColor = System.Drawing.Color.Khaki;
            this.txt_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pago.Limpiar = false;
            this.txt_pago.Location = new System.Drawing.Point(198, 130);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.Size = new System.Drawing.Size(504, 62);
            this.txt_pago.TabIndex = 104;
            this.txt_pago.Text = "0";
            this.txt_pago.Validar = true;
            this.txt_pago.TextChanged += new System.EventHandler(this.txt_pago_TextChanged);
            // 
            // txt_monto
            // 
            this.txt_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_monto.Enabled = false;
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Limpiar = false;
            this.txt_monto.Location = new System.Drawing.Point(198, 57);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(504, 62);
            this.txt_monto.TabIndex = 103;
            this.txt_monto.Text = "473";
            this.txt_monto.Validar = true;
            // 
            // txt_devuelto
            // 
            this.txt_devuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_devuelto.Enabled = false;
            this.txt_devuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devuelto.Limpiar = false;
            this.txt_devuelto.Location = new System.Drawing.Point(5, 264);
            this.txt_devuelto.Name = "txt_devuelto";
            this.txt_devuelto.Size = new System.Drawing.Size(414, 62);
            this.txt_devuelto.TabIndex = 102;
            this.txt_devuelto.Text = "0";
            this.txt_devuelto.Validar = true;
            // 
            // c_metodopago
            // 
            this.c_metodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.c_metodopago.ForeColor = System.Drawing.Color.Black;
            this.c_metodopago.FormattingEnabled = true;
            this.c_metodopago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA ",
            "A CRÉDITO"});
            this.c_metodopago.Location = new System.Drawing.Point(198, 15);
            this.c_metodopago.Name = "c_metodopago";
            this.c_metodopago.Size = new System.Drawing.Size(216, 33);
            this.c_metodopago.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 100;
            this.label3.Text = "FORMA DE PAGO";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.button3);
            this.panel8.Location = new System.Drawing.Point(837, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 327);
            this.panel8.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "COBRAR";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 103);
            this.button2.TabIndex = 99;
            this.button2.Text = "SIN TICKET";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 103);
            this.button1.TabIndex = 98;
            this.button1.Text = "CON TICKET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(9, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 58);
            this.button3.TabIndex = 97;
            this.button3.Text = "VOLVER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.panel_dosmil);
            this.panel2.Controls.Add(this.panel_quiniento);
            this.panel2.Controls.Add(this.panel_mil);
            this.panel2.Controls.Add(this.panel_dociento);
            this.panel2.Controls.Add(this.panel_cien);
            this.panel2.Location = new System.Drawing.Point(15, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 128);
            this.panel2.TabIndex = 96;
            // 
            // panel_dosmil
            // 
            this.panel_dosmil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_dosmil.BackgroundImage")));
            this.panel_dosmil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_dosmil.Location = new System.Drawing.Point(846, 3);
            this.panel_dosmil.Name = "panel_dosmil";
            this.panel_dosmil.Size = new System.Drawing.Size(199, 122);
            this.panel_dosmil.TabIndex = 2;
            this.panel_dosmil.Click += new System.EventHandler(this.panel_dosmil_Click);
            // 
            // panel_quiniento
            // 
            this.panel_quiniento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_quiniento.BackgroundImage")));
            this.panel_quiniento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_quiniento.Location = new System.Drawing.Point(427, 3);
            this.panel_quiniento.Name = "panel_quiniento";
            this.panel_quiniento.Size = new System.Drawing.Size(199, 122);
            this.panel_quiniento.TabIndex = 1;
            this.panel_quiniento.Click += new System.EventHandler(this.panel_quiniento_Click);
            // 
            // panel_mil
            // 
            this.panel_mil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_mil.BackgroundImage")));
            this.panel_mil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_mil.Location = new System.Drawing.Point(637, 3);
            this.panel_mil.Name = "panel_mil";
            this.panel_mil.Size = new System.Drawing.Size(199, 122);
            this.panel_mil.TabIndex = 3;
            this.panel_mil.Click += new System.EventHandler(this.panel_mil_Click);
            // 
            // panel_dociento
            // 
            this.panel_dociento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_dociento.BackgroundImage")));
            this.panel_dociento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_dociento.Location = new System.Drawing.Point(215, 3);
            this.panel_dociento.Name = "panel_dociento";
            this.panel_dociento.Size = new System.Drawing.Size(199, 122);
            this.panel_dociento.TabIndex = 1;
            this.panel_dociento.Click += new System.EventHandler(this.panel_dociento_Click);
            // 
            // panel_cien
            // 
            this.panel_cien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_cien.BackgroundImage")));
            this.panel_cien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_cien.Location = new System.Drawing.Point(3, 3);
            this.panel_cien.Name = "panel_cien";
            this.panel_cien.Size = new System.Drawing.Size(199, 122);
            this.panel_cien.TabIndex = 0;
            this.panel_cien.Click += new System.EventHandler(this.panel_cien_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(12, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 100;
            this.label7.Text = "PAGO RÁPIDO";
            // 
            // PanelCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelCobro";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCobro_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_cien;
        private System.Windows.Forms.Panel panel_dosmil;
        private System.Windows.Forms.Panel panel_quiniento;
        private System.Windows.Forms.Panel panel_mil;
        private System.Windows.Forms.Panel panel_dociento;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox c_metodopago;
        private ErrorTxtBox txt_pago;
        private ErrorTxtBox txt_monto;
        private ErrorTxtBox txt_devuelto;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_limpiar;
    }
}