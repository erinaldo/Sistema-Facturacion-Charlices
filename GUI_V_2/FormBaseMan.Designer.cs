﻿namespace GUI_V_2
{
    partial class FormBaseMan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseMan));
            this.bnt_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.Nom = new GUI_V_2.ErrorTxtBox();
            this.Codigo = new GUI_V_2.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.BackColor = System.Drawing.Color.Brown;
            this.bnt_eliminar.Enabled = false;
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_eliminar.ForeColor = System.Drawing.Color.White;
            this.bnt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_eliminar.Image")));
            this.bnt_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_eliminar.Location = new System.Drawing.Point(612, 369);
            this.bnt_eliminar.Name = "bnt_eliminar";
            this.bnt_eliminar.Size = new System.Drawing.Size(180, 45);
            this.bnt_eliminar.TabIndex = 89;
            this.bnt_eliminar.TabStop = false;
            this.bnt_eliminar.Text = "ELIMINAR";
            this.bnt_eliminar.UseVisualStyleBackColor = false;
            this.bnt_eliminar.Click += new System.EventHandler(this.bnt_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(612, 420);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(180, 45);
            this.btn_guardar.TabIndex = 88;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 338);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 100;
            this.label19.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "Form Base";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.AutoSize = true;
            this.btn_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cerrar.Location = new System.Drawing.Point(762, 9);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(30, 29);
            this.btn_cerrar.TabIndex = 103;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.Click += new System.EventHandler(this.label15_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "NOMBRE";
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.estado.Location = new System.Drawing.Point(125, 330);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 28);
            this.estado.TabIndex = 106;
            this.estado.TabStop = false;
            // 
            // Nom
            // 
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Limpiar = false;
            this.Nom.Location = new System.Drawing.Point(125, 102);
            this.Nom.MaxLength = 35;
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(137, 26);
            this.Nom.TabIndex = 105;
            this.Nom.Validar = true;
            // 
            // Codigo
            // 
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Limpiar = false;
            this.Codigo.Location = new System.Drawing.Point(125, 58);
            this.Codigo.MaxLength = 15;
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(137, 26);
            this.Codigo.TabIndex = 101;
            this.Codigo.Validar = true;
            this.Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_KeyPress);
            // 
            // FormBaseMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 544);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaseMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaseMan";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBaseMan_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button bnt_eliminar;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox estado;
        public ErrorTxtBox Nom;
        public ErrorTxtBox Codigo;
        public System.Windows.Forms.Label btn_cerrar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}