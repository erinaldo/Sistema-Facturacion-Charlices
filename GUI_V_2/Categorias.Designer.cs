namespace GUI_V_2
{
    partial class Categorias
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.Text = "CATEGORIAS DE PRODUCTOS";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Location = new System.Drawing.Point(612, 361);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Location = new System.Drawing.Point(612, 426);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(44, 159);
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(125, 154);
            this.estado.SelectedIndexChanged += new System.EventHandler(this.estado_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Size = new System.Drawing.Size(209, 26);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 563);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}