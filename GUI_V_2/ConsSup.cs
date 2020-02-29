using GUI_V_2.Reportes;
using Microsoft.Reporting.WinForms;
using System;
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
    public partial class ConsSup : FormBaseCons
    {
        public ConsSup()
        {
            InitializeComponent();
            dataGridSuplidores.AutoGenerateColumns = false;
            CodSup.DataPropertyName = "codigo";
            NomSup.DataPropertyName = "nombre_completo";
            CLA_RNC_Sup.DataPropertyName = "cla_rnc";
            TelSup.DataPropertyName = "telefono";
            CorSup.DataPropertyName = "correo";
            DIRSup.DataPropertyName = "direccion";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                IQueryable<Suplidores> suplidores = from s in DB.Suplidores select s;
                if (condicion.Equals(""))
                {
                    suplidores = suplidores.
                    Where(s => s.estado == true);
                }
                else
                {
                    suplidores = suplidores.
                    Where(s => (s.codigo.Contains(condicion) || s.nombre_completo.Contains(condicion) && s.estado == true));
                }

                dataGridSuplidores.DataSource = suplidores.ToList();
            }
            nro_registros.Text = dataGridSuplidores.Rows.Count.ToString() + " REGISTROS.";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormSuplidores obj = new FormSuplidores();
            obj.ShowDialog();
            LlenarDataGrid();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarDataGrid(filtro.Text);
        }

        private void ConsSup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridSuplidores.Rows.Count == 0)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dataGridSuplidores_DoubleClick(object sender, EventArgs e)
        {
    

        }

        private void dataGridSuplidores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }


        private void Editar()
        {
            if (this.dataGridSuplidores.Rows.Count > 0 && dataGridSuplidores.SelectedRows.Count > 0)
            {
                FormSuplidores obj = new FormSuplidores();
                obj.Show();
                obj.Codigo.Text = dataGridSuplidores.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }
        ReportDataSource rs = new ReportDataSource();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportesDatos Repor = new FormReportesDatos();

                List<SuplidoresClass> lista = new List<SuplidoresClass>();
                lista.Clear();

                for (int p = 0; p < dataGridSuplidores.Rows.Count; p++)
                {
                    lista.Add(new SuplidoresClass
                    {
                        Codigo = dataGridSuplidores.Rows[p].Cells[0].Value.ToString(),
                        Nombre = dataGridSuplidores.Rows[p].Cells[1].Value.ToString(),
                        Cedula = dataGridSuplidores.Rows[p].Cells[2].Value.ToString(),
                        Telefono = dataGridSuplidores.Rows[p].Cells[3].Value.ToString(),
                        Direccion = dataGridSuplidores.Rows[p].Cells[4].Value.ToString(),
                        Correo = dataGridSuplidores.Rows[p].Cells[5].Value.ToString(),
                        Estado = dataGridSuplidores.Rows[p].Cells[6].Value.ToString()
                    });
                }
                rs.Name = "DataSetSup";
                rs.Value = lista;
                Repor.reportViewer1.LocalReport.DataSources.Clear();
                Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.RepSup.rdlc";
                Repor.ShowDialog();

            }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }
        }
    }
}



public class SuplidoresClass
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Correo { get; set; }
    public string Estado { get; set; }
}

