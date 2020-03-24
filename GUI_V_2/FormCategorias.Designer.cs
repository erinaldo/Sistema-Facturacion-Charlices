namespace GUI_V_2
{
    partial class FormCategorias
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cocina = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.Text = "CATEGORÍAS DE PRODUCTOS";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Location = new System.Drawing.Point(612, 373);
            this.bnt_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_eliminar.Click += new System.EventHandler(this.bnt_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Location = new System.Drawing.Point(612, 426);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(44, 159);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label5
            // 
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Text = "CÓDIGO";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(125, 154);
            this.estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estado.SelectedIndexChanged += new System.EventHandler(this.estado_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Limpiar = true;
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nom.MaxLength = 25;
            this.Nom.Size = new System.Drawing.Size(209, 26);
            // 
            // Codigo
            // 
            this.Codigo.Limpiar = true;
            this.Codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codigo.Leave += new System.EventHandler(this.Codigo_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 107;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // cocina
            // 
            this.cocina.AutoSize = true;
            this.cocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cocina.Location = new System.Drawing.Point(48, 195);
            this.cocina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cocina.Name = "cocina";
            this.cocina.Size = new System.Drawing.Size(89, 24);
            this.cocina.TabIndex = 108;
            this.cocina.Text = "COCINA";
            this.cocina.UseVisualStyleBackColor = true;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 563);
            this.Controls.Add(this.cocina);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCategorias";
            this.Text = "Categorias";
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
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.cocina, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cocina;
    }
}