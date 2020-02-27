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
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.unidadMedidaCombox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.reorden = new System.Windows.Forms.NumericUpDown();
            this.itbis = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.categoriasCombox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TipoPro = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cantidadPro = new System.Windows.Forms.NumericUpDown();
            this.precio_normal = new System.Windows.Forms.NumericUpDown();
            this.precio_empleado = new System.Windows.Forms.NumericUpDown();
            this.precio_empresa = new System.Windows.Forms.NumericUpDown();
            this.btn_nueva_categoria = new System.Windows.Forms.Button();
            this.btn_nueva_unidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bnt_eliminar.Location = new System.Drawing.Point(612, 380);
            this.bnt_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_eliminar.Click += new System.EventHandler(this.bnt_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_guardar.Location = new System.Drawing.Point(612, 429);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(42, 389);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(34, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Text = "CÓDIGO";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(123, 385);
            this.estado.Margin = new System.Windows.Forms.Padding(4);
            // 
            // Nom
            // 
            this.Nom.Limpiar = true;
            this.Nom.Location = new System.Drawing.Point(125, 96);
            this.Nom.Margin = new System.Windows.Forms.Padding(4);
            this.Nom.Size = new System.Drawing.Size(232, 26);
            // 
            // Codigo
            // 
            this.Codigo.Limpiar = true;
            this.Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Codigo.Leave += new System.EventHandler(this.Codigo_Leave);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(774, 9);
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(34, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "PRECIOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "NORMAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "EMPLEADO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 116;
            this.label9.Text = "EMPRESA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(39, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 117;
            this.label10.Text = "UNIDAD MEDIDA";
            // 
            // unidadMedidaCombox
            // 
            this.unidadMedidaCombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unidadMedidaCombox.FormattingEnabled = true;
            this.unidadMedidaCombox.Items.AddRange(new object[] {
            "UNIDAD",
            "LIBRAS",
            "GALONES",
            "CAJA",
            "METROS",
            "QUILOGRAMOS",
            "ONZAS"});
            this.unidadMedidaCombox.Location = new System.Drawing.Point(185, 339);
            this.unidadMedidaCombox.Name = "unidadMedidaCombox";
            this.unidadMedidaCombox.Size = new System.Drawing.Size(166, 28);
            this.unidadMedidaCombox.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(36, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 120;
            this.label11.Text = "RE-ORDEN:";
            // 
            // reorden
            // 
            this.reorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reorden.Location = new System.Drawing.Point(134, 260);
            this.reorden.Name = "reorden";
            this.reorden.Size = new System.Drawing.Size(73, 26);
            this.reorden.TabIndex = 121;
            // 
            // itbis
            // 
            this.itbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itbis.FormattingEnabled = true;
            this.itbis.Items.AddRange(new object[] {
            "0%",
            "18%",
            "2%"});
            this.itbis.Location = new System.Drawing.Point(125, 186);
            this.itbis.Name = "itbis";
            this.itbis.Size = new System.Drawing.Size(166, 28);
            this.itbis.TabIndex = 123;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(36, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 122;
            this.label12.Text = "ITBIS";
            // 
            // categoriasCombox
            // 
            this.categoriasCombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoriasCombox.FormattingEnabled = true;
            this.categoriasCombox.Location = new System.Drawing.Point(167, 299);
            this.categoriasCombox.Name = "categoriasCombox";
            this.categoriasCombox.Size = new System.Drawing.Size(175, 28);
            this.categoriasCombox.TabIndex = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(34, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 126;
            this.label14.Text = "CANTIDAD";
            // 
            // TipoPro
            // 
            this.TipoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TipoPro.FormattingEnabled = true;
            this.TipoPro.Items.AddRange(new object[] {
            "INVENTARIO",
            "SERVICIO"});
            this.TipoPro.Location = new System.Drawing.Point(536, 91);
            this.TipoPro.Name = "TipoPro";
            this.TipoPro.Size = new System.Drawing.Size(209, 28);
            this.TipoPro.TabIndex = 129;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(364, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 20);
            this.label15.TabIndex = 130;
            this.label15.Text = "TIPO DE PRODUCTO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(36, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 124;
            this.label13.Text = "CATEGORÍA";
            // 
            // cantidadPro
            // 
            this.cantidadPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cantidadPro.Location = new System.Drawing.Point(135, 222);
            this.cantidadPro.Name = "cantidadPro";
            this.cantidadPro.Size = new System.Drawing.Size(73, 26);
            this.cantidadPro.TabIndex = 131;
            // 
            // precio_normal
            // 
            this.precio_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precio_normal.Location = new System.Drawing.Point(125, 152);
            this.precio_normal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.precio_normal.Name = "precio_normal";
            this.precio_normal.Size = new System.Drawing.Size(95, 26);
            this.precio_normal.TabIndex = 132;
            this.precio_normal.ValueChanged += new System.EventHandler(this.precio_normal_ValueChanged);
            this.precio_normal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_normal_KeyPress);
            // 
            // precio_empleado
            // 
            this.precio_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precio_empleado.Location = new System.Drawing.Point(226, 152);
            this.precio_empleado.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.precio_empleado.Name = "precio_empleado";
            this.precio_empleado.Size = new System.Drawing.Size(86, 26);
            this.precio_empleado.TabIndex = 133;
            // 
            // precio_empresa
            // 
            this.precio_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precio_empresa.Location = new System.Drawing.Point(318, 152);
            this.precio_empresa.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.precio_empresa.Name = "precio_empresa";
            this.precio_empresa.Size = new System.Drawing.Size(103, 26);
            this.precio_empresa.TabIndex = 134;
            // 
            // btn_nueva_categoria
            // 
            this.btn_nueva_categoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_nueva_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nueva_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_nueva_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nueva_categoria.Location = new System.Drawing.Point(348, 299);
            this.btn_nueva_categoria.Name = "btn_nueva_categoria";
            this.btn_nueva_categoria.Size = new System.Drawing.Size(73, 28);
            this.btn_nueva_categoria.TabIndex = 135;
            this.btn_nueva_categoria.Text = "NUEVO";
            this.btn_nueva_categoria.UseVisualStyleBackColor = false;
            this.btn_nueva_categoria.Click += new System.EventHandler(this.btn_nueva_categoria_Click);
            // 
            // btn_nueva_unidad
            // 
            this.btn_nueva_unidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_nueva_unidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nueva_unidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_nueva_unidad.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_unidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nueva_unidad.Location = new System.Drawing.Point(357, 338);
            this.btn_nueva_unidad.Name = "btn_nueva_unidad";
            this.btn_nueva_unidad.Size = new System.Drawing.Size(73, 28);
            this.btn_nueva_unidad.TabIndex = 136;
            this.btn_nueva_unidad.Text = "NUEVO";
            this.btn_nueva_unidad.UseVisualStyleBackColor = false;
            this.btn_nueva_unidad.Click += new System.EventHandler(this.btn_nueva_unidad_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 536);
            this.Controls.Add(this.btn_nueva_unidad);
            this.Controls.Add(this.btn_nueva_categoria);
            this.Controls.Add(this.precio_empresa);
            this.Controls.Add(this.precio_empleado);
            this.Controls.Add(this.precio_normal);
            this.Controls.Add(this.cantidadPro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TipoPro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.categoriasCombox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.itbis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reorden);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.unidadMedidaCombox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.unidadMedidaCombox, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.reorden, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.itbis, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.categoriasCombox, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.TipoPro, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.cantidadPro, 0);
            this.Controls.SetChildIndex(this.precio_normal, 0);
            this.Controls.SetChildIndex(this.precio_empleado, 0);
            this.Controls.SetChildIndex(this.precio_empresa, 0);
            this.Controls.SetChildIndex(this.btn_nueva_categoria, 0);
            this.Controls.SetChildIndex(this.btn_nueva_unidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox unidadMedidaCombox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown reorden;
        private System.Windows.Forms.ComboBox itbis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox categoriasCombox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox TipoPro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown cantidadPro;
        private System.Windows.Forms.NumericUpDown precio_normal;
        private System.Windows.Forms.NumericUpDown precio_empleado;
        private System.Windows.Forms.NumericUpDown precio_empresa;
        public System.Windows.Forms.Button btn_nueva_categoria;
        public System.Windows.Forms.Button btn_nueva_unidad;
    }
}