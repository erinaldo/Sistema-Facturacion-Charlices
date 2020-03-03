namespace GUI_V_2
{
    partial class VentasModoTouch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasModoTouch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Reservar = new System.Windows.Forms.Button();
            this.disponible_pro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_verProductos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxCombrobante = new System.Windows.Forms.ComboBox();
            this.fecha_hora = new System.Windows.Forms.Label();
            this.comboBoxVendedores = new System.Windows.Forms.ComboBox();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItbPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_total_desc = new GUI_V_2.ErrorTxtBox();
            this.txt_total_neto = new GUI_V_2.ErrorTxtBox();
            this.txt_total_itbis = new GUI_V_2.ErrorTxtBox();
            this.txt_total_bruto = new GUI_V_2.ErrorTxtBox();
            this.txt_numero_orden = new GUI_V_2.ErrorTxtBox();
            this.txt_descuento = new GUI_V_2.ErrorTxtBox();
            this.precio_pro = new GUI_V_2.ErrorTxtBox();
            this.cantidad_pro = new GUI_V_2.ErrorTxtBox();
            this.nombre_pro = new GUI_V_2.ErrorTxtBox();
            this.codigo_pro = new GUI_V_2.ErrorTxtBox();
            this.txt_codigo_fac = new GUI_V_2.ErrorTxtBox();
            this.txt_serie_comprobante = new GUI_V_2.ErrorTxtBox();
            this.txt_nombre_cliente = new GUI_V_2.ErrorTxtBox();
            this.txt_codigo_cliente = new GUI_V_2.ErrorTxtBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 117);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txt_numero_orden);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.Reservar);
            this.panel5.Controls.Add(this.disponible_pro);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txt_descuento);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.precio_pro);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cantidad_pro);
            this.panel5.Controls.Add(this.nombre_pro);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btn_verProductos);
            this.panel5.Controls.Add(this.codigo_pro);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1320, 74);
            this.panel5.TabIndex = 69;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(161, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 86;
            this.label9.Text = "NRO. ORDEN";
            // 
            // Reservar
            // 
            this.Reservar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Reservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Reservar.FlatAppearance.BorderSize = 0;
            this.Reservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Reservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservar.ForeColor = System.Drawing.Color.White;
            this.Reservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reservar.Location = new System.Drawing.Point(1105, 27);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(82, 39);
            this.Reservar.TabIndex = 85;
            this.Reservar.TabStop = false;
            this.Reservar.Text = "Reservar";
            this.Reservar.UseVisualStyleBackColor = false;
            this.Reservar.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // disponible_pro
            // 
            this.disponible_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.disponible_pro.AutoSize = true;
            this.disponible_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponible_pro.Location = new System.Drawing.Point(520, 3);
            this.disponible_pro.Name = "disponible_pro";
            this.disponible_pro.Size = new System.Drawing.Size(96, 18);
            this.disponible_pro.TabIndex = 84;
            this.disponible_pro.Text = "DISPONIBLE";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(808, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 83;
            this.label8.Text = "DESCUENTO";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1233, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 39);
            this.button7.TabIndex = 81;
            this.button7.TabStop = false;
            this.button7.Text = "BORRAR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(926, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 39);
            this.button6.TabIndex = 80;
            this.button6.TabStop = false;
            this.button6.Text = "AGREGAR [ENTER]";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "CANTIDAD";
            // 
            // btn_verProductos
            // 
            this.btn_verProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_verProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_verProductos.FlatAppearance.BorderSize = 0;
            this.btn_verProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_verProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verProductos.ForeColor = System.Drawing.Color.White;
            this.btn_verProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verProductos.Location = new System.Drawing.Point(6, 29);
            this.btn_verProductos.Name = "btn_verProductos";
            this.btn_verProductos.Size = new System.Drawing.Size(80, 38);
            this.btn_verProductos.TabIndex = 68;
            this.btn_verProductos.TabStop = false;
            this.btn_verProductos.Text = "Ver [F5]";
            this.btn_verProductos.UseVisualStyleBackColor = false;
            this.btn_verProductos.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.comboBoxCombrobante);
            this.panel4.Controls.Add(this.fecha_hora);
            this.panel4.Controls.Add(this.comboBoxVendedores);
            this.panel4.Controls.Add(this.txt_codigo_fac);
            this.panel4.Controls.Add(this.txt_serie_comprobante);
            this.panel4.Controls.Add(this.txt_nombre_cliente);
            this.panel4.Controls.Add(this.btn_clientes);
            this.panel4.Controls.Add(this.txt_codigo_cliente);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1320, 43);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // comboBoxCombrobante
            // 
            this.comboBoxCombrobante.FormattingEnabled = true;
            this.comboBoxCombrobante.Location = new System.Drawing.Point(657, 12);
            this.comboBoxCombrobante.Name = "comboBoxCombrobante";
            this.comboBoxCombrobante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCombrobante.TabIndex = 74;
            this.comboBoxCombrobante.Text = "COMBROBANTE";
            this.comboBoxCombrobante.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombrobante_SelectedIndexChanged);
            // 
            // fecha_hora
            // 
            this.fecha_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha_hora.AutoSize = true;
            this.fecha_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_hora.Location = new System.Drawing.Point(1170, 6);
            this.fecha_hora.Name = "fecha_hora";
            this.fecha_hora.Size = new System.Drawing.Size(142, 20);
            this.fecha_hora.TabIndex = 73;
            this.fecha_hora.Text = "HORA Y FECHA";
            // 
            // comboBoxVendedores
            // 
            this.comboBoxVendedores.FormattingEnabled = true;
            this.comboBoxVendedores.Items.AddRange(new object[] {
            "Diana Lopez",
            "Juan Perez",
            "Miguel Paulino"});
            this.comboBoxVendedores.Location = new System.Drawing.Point(512, 10);
            this.comboBoxVendedores.Name = "comboBoxVendedores";
            this.comboBoxVendedores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVendedores.TabIndex = 72;
            this.comboBoxVendedores.Text = "VENDEDOR";
            // 
            // btn_clientes
            // 
            this.btn_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(384, 3);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(122, 34);
            this.btn_clientes.TabIndex = 68;
            this.btn_clientes.Text = "CLIENTES";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.btn_cotizar);
            this.panel3.Controls.Add(this.btn_cobrar);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btn_volver);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1320, 113);
            this.panel3.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(381, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 102);
            this.button9.TabIndex = 70;
            this.button9.TabStop = false;
            this.button9.Text = "LIMPIAR";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(196, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 102);
            this.button8.TabIndex = 69;
            this.button8.TabStop = false;
            this.button8.Text = "CANCELAR";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cotizar.FlatAppearance.BorderSize = 0;
            this.btn_cotizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotizar.ForeColor = System.Drawing.Color.White;
            this.btn_cotizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cotizar.Image")));
            this.btn_cotizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cotizar.Location = new System.Drawing.Point(887, 8);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(205, 102);
            this.btn_cotizar.TabIndex = 67;
            this.btn_cotizar.TabStop = false;
            this.btn_cotizar.Text = "COTIZACIÓN";
            this.btn_cotizar.UseVisualStyleBackColor = false;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cobrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_cobrar.FlatAppearance.BorderSize = 0;
            this.btn_cobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar.ForeColor = System.Drawing.Color.White;
            this.btn_cobrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cobrar.Image")));
            this.btn_cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cobrar.Location = new System.Drawing.Point(1098, 8);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(214, 102);
            this.btn_cobrar.TabIndex = 66;
            this.btn_cobrar.TabStop = false;
            this.btn_cobrar.Text = "CROBRAR [F12]";
            this.btn_cobrar.UseVisualStyleBackColor = false;
            this.btn_cobrar.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1128, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 102);
            this.button2.TabIndex = 66;
            this.button2.Text = "EFECTIVO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volver.Location = new System.Drawing.Point(5, 6);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(185, 102);
            this.btn_volver.TabIndex = 65;
            this.btn_volver.TabStop = false;
            this.btn_volver.Text = "SALIR [ESC]";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 284);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AllowUserToAddRows = false;
            this.dataGridViewProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.NomPro,
            this.PrePro,
            this.CanPro,
            this.SubPro,
            this.ItbPro,
            this.TotalPro});
            this.dataGridViewProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducto.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridViewProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducto.Size = new System.Drawing.Size(1320, 284);
            this.dataGridViewProducto.TabIndex = 0;
            this.dataGridViewProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducto_CellContentClick);
            // 
            // CodPro
            // 
            this.CodPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodPro.FillWeight = 61.19339F;
            this.CodPro.Frozen = true;
            this.CodPro.HeaderText = "CÓDIGO";
            this.CodPro.Name = "CodPro";
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodPro.Width = 167;
            // 
            // NomPro
            // 
            this.NomPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomPro.FillWeight = 168.1775F;
            this.NomPro.Frozen = true;
            this.NomPro.HeaderText = "NOMBRE";
            this.NomPro.Name = "NomPro";
            this.NomPro.Width = 462;
            // 
            // PrePro
            // 
            this.PrePro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrePro.FillWeight = 91.37045F;
            this.PrePro.Frozen = true;
            this.PrePro.HeaderText = "PRECIO";
            this.PrePro.Name = "PrePro";
            this.PrePro.Width = 250;
            // 
            // CanPro
            // 
            this.CanPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CanPro.FillWeight = 62.6336F;
            this.CanPro.Frozen = true;
            this.CanPro.HeaderText = "CANTIDAD";
            this.CanPro.Name = "CanPro";
            this.CanPro.Width = 173;
            // 
            // SubPro
            // 
            this.SubPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubPro.FillWeight = 108.3121F;
            this.SubPro.Frozen = true;
            this.SubPro.HeaderText = "SUBTOTAL";
            this.SubPro.Name = "SubPro";
            this.SubPro.Width = 299;
            // 
            // ItbPro
            // 
            this.ItbPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItbPro.Frozen = true;
            this.ItbPro.HeaderText = "ITBIS";
            this.ItbPro.Name = "ItbPro";
            this.ItbPro.ReadOnly = true;
            // 
            // TotalPro
            // 
            this.TotalPro.FillWeight = 108.3121F;
            this.TotalPro.HeaderText = "TOTAL";
            this.TotalPro.Name = "TotalPro";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_total_desc);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txt_total_neto);
            this.panel6.Controls.Add(this.txt_total_itbis);
            this.panel6.Controls.Add(this.txt_total_bruto);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 311);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1320, 90);
            this.panel6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 76;
            this.label7.Text = "- DESCUENTO:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(798, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "TOTAL NETO:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "+ ITBIS:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "TOTAL BRUTO:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_total_desc
            // 
            this.txt_total_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_total_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_desc.Limpiar = false;
            this.txt_total_desc.Location = new System.Drawing.Point(677, 39);
            this.txt_total_desc.Name = "txt_total_desc";
            this.txt_total_desc.Size = new System.Drawing.Size(115, 40);
            this.txt_total_desc.TabIndex = 77;
            this.txt_total_desc.TabStop = false;
            this.txt_total_desc.Text = "0.00";
            this.txt_total_desc.Validar = true;
            // 
            // txt_total_neto
            // 
            this.txt_total_neto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total_neto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_total_neto.Enabled = false;
            this.txt_total_neto.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_neto.Limpiar = false;
            this.txt_total_neto.Location = new System.Drawing.Point(920, 17);
            this.txt_total_neto.Name = "txt_total_neto";
            this.txt_total_neto.Size = new System.Drawing.Size(393, 67);
            this.txt_total_neto.TabIndex = 75;
            this.txt_total_neto.TabStop = false;
            this.txt_total_neto.Text = "0.00";
            this.txt_total_neto.Validar = true;
            // 
            // txt_total_itbis
            // 
            this.txt_total_itbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_total_itbis.Enabled = false;
            this.txt_total_itbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_itbis.Limpiar = false;
            this.txt_total_itbis.Location = new System.Drawing.Point(384, 38);
            this.txt_total_itbis.Name = "txt_total_itbis";
            this.txt_total_itbis.Size = new System.Drawing.Size(153, 40);
            this.txt_total_itbis.TabIndex = 74;
            this.txt_total_itbis.TabStop = false;
            this.txt_total_itbis.Text = "0.00";
            this.txt_total_itbis.Validar = true;
            // 
            // txt_total_bruto
            // 
            this.txt_total_bruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_total_bruto.Enabled = false;
            this.txt_total_bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_bruto.Limpiar = false;
            this.txt_total_bruto.Location = new System.Drawing.Point(156, 37);
            this.txt_total_bruto.Name = "txt_total_bruto";
            this.txt_total_bruto.Size = new System.Drawing.Size(153, 40);
            this.txt_total_bruto.TabIndex = 73;
            this.txt_total_bruto.TabStop = false;
            this.txt_total_bruto.Text = "0.00";
            this.txt_total_bruto.Validar = true;
            this.txt_total_bruto.TextChanged += new System.EventHandler(this.txt_total_bruto_TextChanged);
            // 
            // txt_numero_orden
            // 
            this.txt_numero_orden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_numero_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_orden.Limpiar = true;
            this.txt_numero_orden.Location = new System.Drawing.Point(272, 3);
            this.txt_numero_orden.Name = "txt_numero_orden";
            this.txt_numero_orden.Size = new System.Drawing.Size(126, 26);
            this.txt_numero_orden.TabIndex = 87;
            this.txt_numero_orden.Validar = true;
            this.txt_numero_orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_orden_KeyPress);
            // 
            // txt_descuento
            // 
            this.txt_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento.Limpiar = false;
            this.txt_descuento.Location = new System.Drawing.Point(811, 40);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(100, 26);
            this.txt_descuento.TabIndex = 82;
            this.txt_descuento.Text = "0";
            this.txt_descuento.Validar = true;
            this.txt_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.errorTxtBox12_KeyPress);
            // 
            // precio_pro
            // 
            this.precio_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.precio_pro.Enabled = false;
            this.precio_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_pro.Limpiar = true;
            this.precio_pro.Location = new System.Drawing.Point(698, 40);
            this.precio_pro.Name = "precio_pro";
            this.precio_pro.Size = new System.Drawing.Size(101, 26);
            this.precio_pro.TabIndex = 79;
            this.precio_pro.TabStop = false;
            this.precio_pro.Validar = true;
            // 
            // cantidad_pro
            // 
            this.cantidad_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cantidad_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_pro.Limpiar = false;
            this.cantidad_pro.Location = new System.Drawing.Point(538, 40);
            this.cantidad_pro.Name = "cantidad_pro";
            this.cantidad_pro.Size = new System.Drawing.Size(81, 26);
            this.cantidad_pro.TabIndex = 77;
            this.cantidad_pro.Text = "1";
            this.cantidad_pro.Validar = true;
            this.cantidad_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_pro_KeyPress);
            // 
            // nombre_pro
            // 
            this.nombre_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nombre_pro.Enabled = false;
            this.nombre_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombre_pro.Limpiar = false;
            this.nombre_pro.Location = new System.Drawing.Point(181, 40);
            this.nombre_pro.Name = "nombre_pro";
            this.nombre_pro.Size = new System.Drawing.Size(266, 26);
            this.nombre_pro.TabIndex = 76;
            this.nombre_pro.TabStop = false;
            this.nombre_pro.Text = "Descripción de producto";
            this.nombre_pro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre_pro.Validar = true;
            // 
            // codigo_pro
            // 
            this.codigo_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.codigo_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_pro.Limpiar = true;
            this.codigo_pro.Location = new System.Drawing.Point(92, 40);
            this.codigo_pro.Name = "codigo_pro";
            this.codigo_pro.Size = new System.Drawing.Size(83, 26);
            this.codigo_pro.TabIndex = 1;
            this.codigo_pro.Validar = true;
            this.codigo_pro.TextChanged += new System.EventHandler(this.codigo_pro_TextChanged);
            this.codigo_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_pro_KeyPress);
            // 
            // txt_codigo_fac
            // 
            this.txt_codigo_fac.Enabled = false;
            this.txt_codigo_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_fac.Limpiar = false;
            this.txt_codigo_fac.Location = new System.Drawing.Point(784, 5);
            this.txt_codigo_fac.Name = "txt_codigo_fac";
            this.txt_codigo_fac.Size = new System.Drawing.Size(167, 26);
            this.txt_codigo_fac.TabIndex = 71;
            this.txt_codigo_fac.TabStop = false;
            this.txt_codigo_fac.Text = "FAC000000";
            this.txt_codigo_fac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_codigo_fac.Validar = true;
            // 
            // txt_serie_comprobante
            // 
            this.txt_serie_comprobante.Enabled = false;
            this.txt_serie_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie_comprobante.Limpiar = false;
            this.txt_serie_comprobante.Location = new System.Drawing.Point(957, 5);
            this.txt_serie_comprobante.Name = "txt_serie_comprobante";
            this.txt_serie_comprobante.Size = new System.Drawing.Size(156, 26);
            this.txt_serie_comprobante.TabIndex = 70;
            this.txt_serie_comprobante.TabStop = false;
            this.txt_serie_comprobante.Text = "COMPROBANTE";
            this.txt_serie_comprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_serie_comprobante.Validar = true;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.Limpiar = false;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(156, 6);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(220, 26);
            this.txt_nombre_cliente.TabIndex = 69;
            this.txt_nombre_cliente.TabStop = false;
            this.txt_nombre_cliente.Text = "Nombre cliente";
            this.txt_nombre_cliente.Validar = true;
            this.txt_nombre_cliente.TextChanged += new System.EventHandler(this.txt_nombre_cliente_TextChanged);
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_codigo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_cliente.Limpiar = true;
            this.txt_codigo_cliente.Location = new System.Drawing.Point(83, 6);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.Size = new System.Drawing.Size(67, 26);
            this.txt_codigo_cliente.TabIndex = 1;
            this.txt_codigo_cliente.Validar = true;
            this.txt_codigo_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.errorTxtBox1_KeyPress);
            // 
            // VentasModoTouch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 514);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "VentasModoTouch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VentasModoTouch_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cotizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_verProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ErrorTxtBox txt_total_bruto;
        private System.Windows.Forms.Label label7;
        private ErrorTxtBox txt_descuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label fecha_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_cobrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItbPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPro;
        private System.Windows.Forms.Label disponible_pro;
        private System.Windows.Forms.ComboBox comboBoxCombrobante;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridViewProducto;
        public ErrorTxtBox txt_codigo_cliente;
        public ErrorTxtBox codigo_pro;
        public ErrorTxtBox nombre_pro;
        public ErrorTxtBox cantidad_pro;
        public ErrorTxtBox precio_pro;
        public ErrorTxtBox txt_nombre_cliente;
        public ErrorTxtBox txt_codigo_fac;
        public ErrorTxtBox txt_serie_comprobante;
        public ErrorTxtBox txt_total_itbis;
        public ErrorTxtBox txt_total_desc;
        public ErrorTxtBox txt_numero_orden;
        public System.Windows.Forms.ComboBox comboBoxVendedores;
        public ErrorTxtBox txt_total_neto;
    }
}