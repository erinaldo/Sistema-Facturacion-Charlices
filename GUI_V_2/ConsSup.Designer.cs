namespace GUI_V_2
{
    partial class ConsSup
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
            this.dataGridSuplidores = new System.Windows.Forms.DataGridView();
            this.CodSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_RNC_Sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuplidores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.Text = "SUPLIDORES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(140, 38);
            this.filtro.Margin = new System.Windows.Forms.Padding(4);
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(6, 48);
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(953, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nuevo.Location = new System.Drawing.Point(437, 33);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // nro_registros
            // 
            this.nro_registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nro_registros.Location = new System.Drawing.Point(904, 60);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 33);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridSuplidores
            // 
            this.dataGridSuplidores.AllowUserToAddRows = false;
            this.dataGridSuplidores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridSuplidores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSuplidores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSuplidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuplidores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridSuplidores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSuplidores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSuplidores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSuplidores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuplidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodSup,
            this.NomSup,
            this.CLA_RNC_Sup,
            this.TelSup,
            this.DIRSup,
            this.CorSup,
            this.estatus});
            this.dataGridSuplidores.EnableHeadersVisualStyles = false;
            this.dataGridSuplidores.Location = new System.Drawing.Point(10, 80);
            this.dataGridSuplidores.Name = "dataGridSuplidores";
            this.dataGridSuplidores.ReadOnly = true;
            this.dataGridSuplidores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuplidores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSuplidores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dataGridSuplidores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSuplidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuplidores.Size = new System.Drawing.Size(973, 441);
            this.dataGridSuplidores.TabIndex = 113;
            this.dataGridSuplidores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSuplidores_CellDoubleClick);
            // 
            // CodSup
            // 
            this.CodSup.FillWeight = 45.62981F;
            this.CodSup.HeaderText = "CÓDIGO";
            this.CodSup.Name = "CodSup";
            this.CodSup.ReadOnly = true;
            this.CodSup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NomSup
            // 
            this.NomSup.FillWeight = 126.5594F;
            this.NomSup.HeaderText = "NOMBRE";
            this.NomSup.Name = "NomSup";
            this.NomSup.ReadOnly = true;
            // 
            // CLA_RNC_Sup
            // 
            this.CLA_RNC_Sup.FillWeight = 125.7348F;
            this.CLA_RNC_Sup.HeaderText = "CLA/RNC";
            this.CLA_RNC_Sup.Name = "CLA_RNC_Sup";
            this.CLA_RNC_Sup.ReadOnly = true;
            // 
            // TelSup
            // 
            this.TelSup.FillWeight = 128.1196F;
            this.TelSup.HeaderText = "TELÉFONO";
            this.TelSup.Name = "TelSup";
            this.TelSup.ReadOnly = true;
            // 
            // DIRSup
            // 
            this.DIRSup.FillWeight = 125.8214F;
            this.DIRSup.HeaderText = "DIRECCION";
            this.DIRSup.Name = "DIRSup";
            this.DIRSup.ReadOnly = true;
            // 
            // CorSup
            // 
            this.CorSup.FillWeight = 101.9412F;
            this.CorSup.HeaderText = "CORREO";
            this.CorSup.Name = "CorSup";
            this.CorSup.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.FillWeight = 46.19283F;
            this.estatus.HeaderText = "ESTADO";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            // 
            // ConsSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 531);
            this.Controls.Add(this.dataGridSuplidores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsSup";
            this.Text = "ConsSup";
            this.Load += new System.EventHandler(this.ConsSup_Load);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.nro_registros, 0);
            this.Controls.SetChildIndex(this.btn_nuevo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.dataGridSuplidores, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuplidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridSuplidores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_RNC_Sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}