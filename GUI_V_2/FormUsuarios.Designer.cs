namespace GUI_V_2
{
    partial class FormUsuarios
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
            this.CedUsu = new GUI_V_2.ErrorTxtBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CorUsu = new GUI_V_2.ErrorTxtBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DirUsu = new GUI_V_2.ErrorTxtBox();
            this.TelUsu = new GUI_V_2.ErrorTxtBox();
            this.TipUsu = new System.Windows.Forms.ComboBox();
            this.UsuNom = new GUI_V_2.ErrorTxtBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UsuPass = new GUI_V_2.ErrorTxtBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.Text = "USUARIO";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Click += new System.EventHandler(this.bnt_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(44, 446);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(125, 438);
            this.estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // Nom
            // 
            this.Nom.Limpiar = true;
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nom.Size = new System.Drawing.Size(262, 26);
            // 
            // Codigo
            // 
            this.Codigo.Limpiar = true;
            this.Codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codigo.Leave += new System.EventHandler(this.Codigo_Leave);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(766, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // CedUsu
            // 
            this.CedUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CedUsu.Limpiar = true;
            this.CedUsu.Location = new System.Drawing.Point(162, 233);
            this.CedUsu.Name = "CedUsu";
            this.CedUsu.Size = new System.Drawing.Size(170, 26);
            this.CedUsu.TabIndex = 126;
            this.CedUsu.Validar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(40, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 125;
            this.label8.Text = "CLA / RNC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(40, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 124;
            this.label7.Text = "CORREO";
            // 
            // CorUsu
            // 
            this.CorUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorUsu.Limpiar = true;
            this.CorUsu.Location = new System.Drawing.Point(125, 399);
            this.CorUsu.MaxLength = 60;
            this.CorUsu.Name = "CorUsu";
            this.CorUsu.Size = new System.Drawing.Size(233, 26);
            this.CorUsu.TabIndex = 123;
            this.CorUsu.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(40, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 122;
            this.label6.Text = "TIPO USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 121;
            this.label4.Text = "DIRECCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "TELÉFONO";
            // 
            // DirUsu
            // 
            this.DirUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirUsu.Limpiar = true;
            this.DirUsu.Location = new System.Drawing.Point(162, 317);
            this.DirUsu.MaxLength = 40;
            this.DirUsu.Name = "DirUsu";
            this.DirUsu.Size = new System.Drawing.Size(334, 26);
            this.DirUsu.TabIndex = 119;
            this.DirUsu.Validar = true;
            // 
            // TelUsu
            // 
            this.TelUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelUsu.Limpiar = true;
            this.TelUsu.Location = new System.Drawing.Point(162, 276);
            this.TelUsu.MaxLength = 15;
            this.TelUsu.Name = "TelUsu";
            this.TelUsu.Size = new System.Drawing.Size(170, 26);
            this.TelUsu.TabIndex = 118;
            this.TelUsu.Validar = true;
            // 
            // TipUsu
            // 
            this.TipUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TipUsu.FormattingEnabled = true;
            this.TipUsu.Items.AddRange(new object[] {
            "CAJERO",
            "ADMINISTRADOR"});
            this.TipUsu.Location = new System.Drawing.Point(170, 357);
            this.TipUsu.Name = "TipUsu";
            this.TipUsu.Size = new System.Drawing.Size(188, 28);
            this.TipUsu.TabIndex = 127;
            // 
            // UsuNom
            // 
            this.UsuNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsuNom.Limpiar = true;
            this.UsuNom.Location = new System.Drawing.Point(132, 145);
            this.UsuNom.Name = "UsuNom";
            this.UsuNom.Size = new System.Drawing.Size(183, 26);
            this.UsuNom.TabIndex = 129;
            this.UsuNom.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(40, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 128;
            this.label9.Text = "USUARIO";
            // 
            // UsuPass
            // 
            this.UsuPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsuPass.Limpiar = true;
            this.UsuPass.Location = new System.Drawing.Point(162, 187);
            this.UsuPass.Name = "UsuPass";
            this.UsuPass.Size = new System.Drawing.Size(183, 26);
            this.UsuPass.TabIndex = 131;
            this.UsuPass.UseSystemPasswordChar = true;
            this.UsuPass.Validar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(40, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 130;
            this.label10.Text = "CONTRASEÑA";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 483);
            this.Controls.Add(this.UsuPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UsuNom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TipUsu);
            this.Controls.Add(this.CedUsu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CorUsu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirUsu);
            this.Controls.Add(this.TelUsu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.Controls.SetChildIndex(this.TelUsu, 0);
            this.Controls.SetChildIndex(this.DirUsu, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.CorUsu, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.CedUsu, 0);
            this.Controls.SetChildIndex(this.TipUsu, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.UsuNom, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.UsuPass, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox CedUsu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ErrorTxtBox CorUsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ErrorTxtBox DirUsu;
        private ErrorTxtBox TelUsu;
        private System.Windows.Forms.ComboBox TipUsu;
        private ErrorTxtBox UsuNom;
        private System.Windows.Forms.Label label9;
        private ErrorTxtBox UsuPass;
        private System.Windows.Forms.Label label10;
    }
}