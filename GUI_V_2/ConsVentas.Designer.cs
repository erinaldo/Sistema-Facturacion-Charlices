﻿namespace GUI_V_2
{
    partial class ConsVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NFC_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobamte_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_cajero_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Met_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_vendedor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_anular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.p_resumen = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_descuentos = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_itbis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_formaPago = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total_neto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_totalGrid = new System.Windows.Forms.Label();
            this.ActivarRango = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.p_resumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.Text = "VENTAS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(258, 140);
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.Text = "FILTRAR";
            // 
            // filtro
            // 
            this.filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtro.Location = new System.Drawing.Point(548, 146);
            this.filtro.Size = new System.Drawing.Size(207, 35);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(418, 155);
            this.label16.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1110, 9);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.Location = new System.Drawing.Point(258, 70);
            this.btn_nuevo.Text = "DETALLE";
            // 
            // nro_registros
            // 
            this.nro_registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nro_registros.Location = new System.Drawing.Point(1061, 167);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(765, 141);
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_cliente,
            this.fecha,
            this.NFC_comprobante,
            this.comprobamte_id,
            this.usuario_cajero_id,
            this.Met_Pago,
            this.usuario_vendedor_id,
            this.itbis_total,
            this.descuento,
            this.subtotal,
            this.total});
            this.dataGridVentas.EnableHeadersVisualStyles = false;
            this.dataGridVentas.Location = new System.Drawing.Point(17, 191);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridVentas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVentas.Size = new System.Drawing.Size(1123, 322);
            this.dataGridVentas.TabIndex = 115;
            // 
            // id
            // 
            this.id.FillWeight = 78.95237F;
            this.id.HeaderText = "FACTURA #";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id_cliente
            // 
            this.id_cliente.FillWeight = 109.8024F;
            this.id_cliente.HeaderText = "CLIENTE";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.FillWeight = 81.61572F;
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // NFC_comprobante
            // 
            this.NFC_comprobante.FillWeight = 108.2109F;
            this.NFC_comprobante.HeaderText = "NFC";
            this.NFC_comprobante.Name = "NFC_comprobante";
            this.NFC_comprobante.ReadOnly = true;
            // 
            // comprobamte_id
            // 
            this.comprobamte_id.HeaderText = "COMPROBANTE ID";
            this.comprobamte_id.Name = "comprobamte_id";
            this.comprobamte_id.ReadOnly = true;
            this.comprobamte_id.Visible = false;
            // 
            // usuario_cajero_id
            // 
            this.usuario_cajero_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario_cajero_id.FillWeight = 109.8396F;
            this.usuario_cajero_id.HeaderText = "USUARIO";
            this.usuario_cajero_id.Name = "usuario_cajero_id";
            this.usuario_cajero_id.ReadOnly = true;
            // 
            // Met_Pago
            // 
            this.Met_Pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Met_Pago.FillWeight = 111.6175F;
            this.Met_Pago.HeaderText = "FORMA PAGO";
            this.Met_Pago.Name = "Met_Pago";
            this.Met_Pago.ReadOnly = true;
            // 
            // usuario_vendedor_id
            // 
            this.usuario_vendedor_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario_vendedor_id.FillWeight = 114.9565F;
            this.usuario_vendedor_id.HeaderText = "VENDEDOR";
            this.usuario_vendedor_id.Name = "usuario_vendedor_id";
            this.usuario_vendedor_id.ReadOnly = true;
            // 
            // itbis_total
            // 
            this.itbis_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itbis_total.FillWeight = 51.40212F;
            this.itbis_total.HeaderText = "ITBIS";
            this.itbis_total.Name = "itbis_total";
            this.itbis_total.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descuento.FillWeight = 111.675F;
            this.descuento.HeaderText = "DESCUENTO";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.FillWeight = 110.2319F;
            this.subtotal.HeaderText = "SUB-TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.FillWeight = 111.6951F;
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActivarRango);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fecha_fin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fecha_inicio);
            this.panel1.Location = new System.Drawing.Point(17, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 136);
            this.panel1.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA FIN";
            // 
            // fecha_fin
            // 
            this.fecha_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fin.Location = new System.Drawing.Point(14, 102);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(197, 26);
            this.fecha_fin.TabIndex = 2;
            this.fecha_fin.Value = new System.DateTime(2020, 3, 11, 14, 33, 34, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA INICIO";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_inicio.Location = new System.Drawing.Point(14, 41);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(197, 26);
            this.fecha_inicio.TabIndex = 0;
            this.fecha_inicio.Value = new System.DateTime(2020, 3, 11, 14, 33, 27, 0);
            // 
            // btn_anular
            // 
            this.btn_anular.BackColor = System.Drawing.Color.Tomato;
            this.btn_anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anular.ForeColor = System.Drawing.Color.White;
            this.btn_anular.Location = new System.Drawing.Point(363, 70);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(98, 40);
            this.btn_anular.TabIndex = 117;
            this.btn_anular.Text = "ANULAR";
            this.btn_anular.UseVisualStyleBackColor = false;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "CONTROLES";
            // 
            // p_resumen
            // 
            this.p_resumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_resumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_resumen.Controls.Add(this.label14);
            this.p_resumen.Controls.Add(this.txt_descuentos);
            this.p_resumen.Controls.Add(this.label12);
            this.p_resumen.Controls.Add(this.txt_itbis);
            this.p_resumen.Controls.Add(this.label8);
            this.p_resumen.Controls.Add(this.txt_formaPago);
            this.p_resumen.Controls.Add(this.label7);
            this.p_resumen.Controls.Add(this.txt_total_neto);
            this.p_resumen.Controls.Add(this.label4);
            this.p_resumen.Location = new System.Drawing.Point(611, 9);
            this.p_resumen.Name = "p_resumen";
            this.p_resumen.Size = new System.Drawing.Size(493, 118);
            this.p_resumen.TabIndex = 117;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "-DESCUENTOS:";
            // 
            // txt_descuentos
            // 
            this.txt_descuentos.AutoSize = true;
            this.txt_descuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuentos.Location = new System.Drawing.Point(157, 80);
            this.txt_descuentos.Name = "txt_descuentos";
            this.txt_descuentos.Size = new System.Drawing.Size(45, 24);
            this.txt_descuentos.TabIndex = 11;
            this.txt_descuentos.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "-ITBIS:";
            // 
            // txt_itbis
            // 
            this.txt_itbis.AutoSize = true;
            this.txt_itbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itbis.Location = new System.Drawing.Point(99, 56);
            this.txt_itbis.Name = "txt_itbis";
            this.txt_itbis.Size = new System.Drawing.Size(45, 24);
            this.txt_itbis.TabIndex = 9;
            this.txt_itbis.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "-FORMA PAGO:";
            // 
            // txt_formaPago
            // 
            this.txt_formaPago.AutoSize = true;
            this.txt_formaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_formaPago.Location = new System.Drawing.Point(363, 81);
            this.txt_formaPago.Name = "txt_formaPago";
            this.txt_formaPago.Size = new System.Drawing.Size(25, 24);
            this.txt_formaPago.TabIndex = 7;
            this.txt_formaPago.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "-TOTAL:";
            // 
            // txt_total_neto
            // 
            this.txt_total_neto.AutoSize = true;
            this.txt_total_neto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_neto.Location = new System.Drawing.Point(98, 30);
            this.txt_total_neto.Name = "txt_total_neto";
            this.txt_total_neto.Size = new System.Drawing.Size(45, 24);
            this.txt_total_neto.TabIndex = 5;
            this.txt_total_neto.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "RESUMEN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "TOTAL:";
            // 
            // txt_totalGrid
            // 
            this.txt_totalGrid.AutoSize = true;
            this.txt_totalGrid.BackColor = System.Drawing.Color.PaleGreen;
            this.txt_totalGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalGrid.Location = new System.Drawing.Point(82, 516);
            this.txt_totalGrid.Name = "txt_totalGrid";
            this.txt_totalGrid.Size = new System.Drawing.Size(45, 24);
            this.txt_totalGrid.TabIndex = 9;
            this.txt_totalGrid.Text = "0.00";
            // 
            // ActivarRango
            // 
            this.ActivarRango.AutoSize = true;
            this.ActivarRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivarRango.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ActivarRango.Location = new System.Drawing.Point(139, 18);
            this.ActivarRango.Name = "ActivarRango";
            this.ActivarRango.Size = new System.Drawing.Size(79, 17);
            this.ActivarRango.TabIndex = 118;
            this.ActivarRango.Text = "ACTIVAR";
            this.ActivarRango.UseVisualStyleBackColor = true;
            this.ActivarRango.CheckStateChanged += new System.EventHandler(this.ActivarRango_CheckStateChanged);
            // 
            // ConsVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 549);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_totalGrid);
            this.Controls.Add(this.p_resumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_anular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridVentas);
            this.Name = "ConsVentas";
            this.Controls.SetChildIndex(this.dataGridVentas, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btn_anular, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.p_resumen, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.nro_registros, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.txt_totalGrid, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_resumen.ResumeLayout(false);
            this.p_resumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NFC_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprobamte_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_cajero_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Met_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_vendedor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel p_resumen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_total_neto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_formaPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_totalGrid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txt_descuentos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_itbis;
        private System.Windows.Forms.CheckBox ActivarRango;
    }
}