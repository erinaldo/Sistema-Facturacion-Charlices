namespace GUI_V_2
{
    partial class Suplidores
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DirSup = new GUI_V_2.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CedSup = new GUI_V_2.ErrorTxtBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelSup = new GUI_V_2.ErrorTxtBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.Text = "SUPLIDORES";
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
            this.label19.Location = new System.Drawing.Point(44, 287);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(151, 279);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(151, 102);
            this.Nom.Size = new System.Drawing.Size(252, 26);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(151, 58);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(168, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 24);
            this.textBox3.TabIndex = 60;
            // 
            // DirSup
            // 
            this.DirSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DirSup.Location = new System.Drawing.Point(151, 237);
            this.DirSup.Name = "DirSup";
            this.DirSup.Size = new System.Drawing.Size(319, 26);
            this.DirSup.TabIndex = 107;
            this.DirSup.Validar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "CLA / RNC";
            // 
            // CedSup
            // 
            this.CedSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CedSup.Location = new System.Drawing.Point(151, 146);
            this.CedSup.Name = "CedSup";
            this.CedSup.Size = new System.Drawing.Size(170, 26);
            this.CedSup.TabIndex = 109;
            this.CedSup.Validar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(40, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "TELEFONO";
            // 
            // TelSup
            // 
            this.TelSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TelSup.Location = new System.Drawing.Point(151, 192);
            this.TelSup.Name = "TelSup";
            this.TelSup.Size = new System.Drawing.Size(170, 26);
            this.TelSup.TabIndex = 111;
            this.TelSup.Validar = false;
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 549);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CedSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirSup);
            this.Name = "Suplidores";
            this.Text = "Suplidores";
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.DirSup, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CedSup, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TelSup, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private ErrorTxtBox DirSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ErrorTxtBox CedSup;
        private System.Windows.Forms.Label label6;
        private ErrorTxtBox TelSup;
    }
}