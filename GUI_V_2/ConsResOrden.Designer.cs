namespace GUI_V_2
{
    partial class ConsResOrden
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridOrdenes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_mesera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.Text = "Ordenes ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(146, 49);
            this.filtro.Margin = new System.Windows.Forms.Padding(4);
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(12, 56);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(865, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(760, 49);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Visible = false;
            // 
            // nro_registros
            // 
            this.nro_registros.Location = new System.Drawing.Point(635, 71);
            this.nro_registros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Visible = false;
            // 
            // dataGridOrdenes
            // 
            this.dataGridOrdenes.AllowUserToAddRows = false;
            this.dataGridOrdenes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridOrdenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrdenes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOrdenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_mesera,
            this.fecha,
            this.id_cliente,
            this.estado});
            this.dataGridOrdenes.EnableHeadersVisualStyles = false;
            this.dataGridOrdenes.Location = new System.Drawing.Point(16, 95);
            this.dataGridOrdenes.Name = "dataGridOrdenes";
            this.dataGridOrdenes.ReadOnly = true;
            this.dataGridOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrdenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridOrdenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridOrdenes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrdenes.Size = new System.Drawing.Size(879, 368);
            this.dataGridOrdenes.TabIndex = 115;
            // 
            // id
            // 
            this.id.FillWeight = 88.85079F;
            this.id.HeaderText = "ORDEN #";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id_mesera
            // 
            this.id_mesera.FillWeight = 176.8077F;
            this.id_mesera.HeaderText = "MESERA";
            this.id_mesera.Name = "id_mesera";
            this.id_mesera.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.FillWeight = 124.3826F;
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // id_cliente
            // 
            this.id_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_cliente.FillWeight = 97.03534F;
            this.id_cliente.HeaderText = "CLIENTE";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 87.49878F;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // ConsResOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 475);
            this.Controls.Add(this.dataGridOrdenes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsResOrden";
            this.Text = "ConsResOrden";
            this.Load += new System.EventHandler(this.ConsResOrden_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.nro_registros, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.dataGridOrdenes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mesera;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}