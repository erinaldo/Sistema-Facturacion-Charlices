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
    public partial class ConsUniMed : FormBaseCons  
    {
        public ConsUniMed()
        {
            InitializeComponent();
            try { 
            dataGridView1.AutoGenerateColumns = false;
            CodPro.DataPropertyName = "codigo";
            NomPro.DataPropertyName = "nombre";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
            }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }
}

        public void LlenarDataGrid(string condicion = "")
        {
            try { 
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
                    Where(s => (s.codigo.ToString().Contains(condicion) || s.nombre.Contains(condicion) && s.estado == true));
                }

                dataGridView1.DataSource = Unidades.ToList();
            }
            nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";
        }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }

}


ReportDataSource rs = new ReportDataSource();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportesDatos Repor = new FormReportesDatos();

                List<UnidadesMedidasClass> lista = new List<UnidadesMedidasClass>();
                lista.Clear();

                     for (int p = 0; p < dataGridView1.Rows.Count; p++)
                    {
                        lista.Add(new UnidadesMedidasClass
                        {
                            Codigo = dataGridView1.Rows[p].Cells[0].Value.ToString(),
                            Nombre = dataGridView1.Rows[p].Cells[1].Value.ToString(),
                            Estado = dataGridView1.Rows[p].Cells[2].Value.ToString(),
                        });
                }
                rs.Name = "DataSetUniMed";
                rs.Value = lista;
                Repor.reportViewer1.LocalReport.DataSources.Clear();
                Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.RepUniMed.rdlc";
                Repor.ShowDialog();
                
            }
            catch (Exception Aa)
            {
                //Error
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try { 
            FormUnidadesMedidas obj = new FormUnidadesMedidas();
            obj.ShowDialog();
            LlenarDataGrid();
        }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }

}

private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            Editar();
            LlenarDataGrid();
        }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }

}

        private void Editar()
        {
            try { 
            if (this.dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                FormUnidadesMedidas obj = new FormUnidadesMedidas();
                obj.Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
                obj.ShowDialog();

            }
             }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }

        }

private void ConsUniMed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


//metodo setter y getter
public class UnidadesMedidasClass
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Estado { get; set; }

}
