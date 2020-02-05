namespace GUI_V_2
{
    partial class FormClientes
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
            this.TelCli = new GUI_V_2.ErrorTxtBox();
            this.DirCli = new GUI_V_2.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TipCli = new System.Windows.Forms.ComboBox();
            this.CorCli = new GUI_V_2.ErrorTxtBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.Text = "CLIENTES";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Location = new System.Drawing.Point(816, 459);
            this.bnt_eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.bnt_eliminar.Click += new System.EventHandler(this.bnt_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Location = new System.Drawing.Point(816, 539);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(59, 414);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // label5
            // 
            this.label5.Text = "CÓDIGO";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(216, 410);
            this.estado.Margin = new System.Windows.Forms.Padding(5);
            this.estado.Size = new System.Drawing.Size(181, 33);
            // 
            // Nom
            // 
            this.Nom.Limpiar = true;
            this.Nom.Location = new System.Drawing.Point(216, 126);
            this.Nom.Margin = new System.Windows.Forms.Padding(5);
            this.Nom.Size = new System.Drawing.Size(299, 30);
            // 
            // Codigo
            // 
            this.Codigo.Limpiar = true;
            this.Codigo.Location = new System.Drawing.Point(216, 71);
            this.Codigo.Margin = new System.Windows.Forms.Padding(5);
            this.Codigo.Size = new System.Drawing.Size(299, 30);
            this.Codigo.Leave += new System.EventHandler(this.Codigo_Leave);
            // 
            // TelCli
            // 
            this.TelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelCli.Limpiar = false;
            this.TelCli.Location = new System.Drawing.Point(216, 175);
            this.TelCli.Margin = new System.Windows.Forms.Padding(4);
            this.TelCli.MaxLength = 15;
            this.TelCli.Name = "TelCli";
            this.TelCli.Size = new System.Drawing.Size(181, 30);
            this.TelCli.TabIndex = 107;
            this.TelCli.Validar = true;
            // 
            // DirCli
            // 
            this.DirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirCli.Limpiar = true;
            this.DirCli.Location = new System.Drawing.Point(216, 231);
            this.DirCli.Margin = new System.Windows.Forms.Padding(4);
            this.DirCli.MaxLength = 40;
            this.DirCli.Name = "DirCli";
            this.DirCli.Size = new System.Drawing.Size(369, 30);
            this.DirCli.TabIndex = 108;
            this.DirCli.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(53, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 110;
            this.label3.Text = "TELÉFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(53, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "DIRECCIÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(53, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 112;
            this.label6.Text = "TIPO CLIENTE";
            // 
            // TipCli
            // 
            this.TipCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TipCli.FormattingEnabled = true;
            this.TipCli.Items.AddRange(new object[] {
            "NORMAL",
            "FAMILIA",
            "Empleado"});
            this.TipCli.Location = new System.Drawing.Point(216, 289);
            this.TipCli.Margin = new System.Windows.Forms.Padding(4);
            this.TipCli.Name = "TipCli";
            this.TipCli.Size = new System.Drawing.Size(181, 33);
            this.TipCli.TabIndex = 113;
            // 
            // CorCli
            // 
            this.CorCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorCli.Limpiar = true;
            this.CorCli.Location = new System.Drawing.Point(216, 350);
            this.CorCli.Margin = new System.Windows.Forms.Padding(4);
            this.CorCli.MaxLength = 60;
            this.CorCli.Name = "CorCli";
            this.CorCli.Size = new System.Drawing.Size(299, 30);
            this.CorCli.TabIndex = 114;
            this.CorCli.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(53, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 115;
            this.label7.Text = "CORREO";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 681);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CorCli);
            this.Controls.Add(this.TipCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirCli);
            this.Controls.Add(this.TelCli);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.TelCli, 0);
            this.Controls.SetChildIndex(this.DirCli, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TipCli, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.CorCli, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox TelCli;
        private ErrorTxtBox DirCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TipCli;
        private ErrorTxtBox CorCli;
        private System.Windows.Forms.Label label7;
    }
}