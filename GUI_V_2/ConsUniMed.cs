﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class ConsUniMed : FormBaseCons  
    {
        public ConsUniMed()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            CodPro.DataPropertyName = "id";
            NomPro.DataPropertyName = "nombre";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                IQueryable<Unidades_medidas> Unidades = from s in DB.Unidades_medidas select s;
                if (condicion.Equals(""))
                {
                    Unidades = Unidades.
                    Where(s => s.estado == true);
                }
                else
                {
                    Unidades = Unidades.
                    Where(s => (s.id.ToString().Contains(condicion) || s.nombre.Contains(condicion) && s.estado == true));
                }

                dataGridView1.DataSource = Unidades.ToList();
            }
            nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ImprimirTabla(dataGridView1, "Reporte Unidades de Medidas");
            }
            catch (Exception Aa)
            {
                //Error
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormUnidadesMedidas obj = new FormUnidadesMedidas();
            obj.ShowDialog();
            LlenarDataGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (this.dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                FormUnidadesMedidas obj = new FormUnidadesMedidas();
                obj.Show();
                obj.Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }
    }
}