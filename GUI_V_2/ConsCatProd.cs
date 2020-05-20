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
    public partial class ConsCatProd : FormBaseCons
    {
        public ConsCatProd()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            try { 
            CodPro.DataPropertyName = "codigo";
            NomPro.DataPropertyName = "nombre";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
            }catch(Exception aas)
            {
                //Posible error
            }
        }

        public void LlenarDataGrid(string condicion = "")
        {

            try { 
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                IQueryable<Categorias> categorias = from s in DB.Categorias select s;
                if (condicion.Equals(""))
                {
                    categorias = categorias.
                    Where(s => s.estado == true);
                }
                else
                {
                    categorias = categorias.
                    Where(s => (s.codigo.Contains(condicion) || s.nombre.Contains(condicion) && s.estado == true));
                }

                dataGridView1.DataSource = categorias.ToList();
            }
            nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";
        }catch(Exception aas)
            {
                //Posible error
            }
}


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try { 
            FormCategorias obj = new FormCategorias();
            obj.ShowDialog();
            LlenarDataGrid();
            }catch(Exception aas)
            {
                //Posible error
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
           
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            try { 
            if (this.dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                FormCategorias obj = new FormCategorias();
                obj.Show();
                obj.Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }catch(Exception aas)
            {
                //Posible error
            }
}

        ReportDataSource rs = new ReportDataSource();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportesDatos Repor = new FormReportesDatos();

                List<CatProClass> lista = new List<CatProClass>();
                lista.Clear();

                for (int p = 0; p < dataGridView1.Rows.Count; p++)
                {
                    lista.Add(new CatProClass
                    {
                        Codigo = dataGridView1.Rows[p].Cells[0].Value.ToString(),
                        Nombre = dataGridView1.Rows[p].Cells[1].Value.ToString(),
                        Estado = dataGridView1.Rows[p].Cells[2].Value.ToString(),
                    });
                }
                rs.Name = "DataSetCatPro";
                rs.Value = lista;
                Repor.reportViewer1.LocalReport.DataSources.Clear();
                Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.RepCatPro.rdlc";
                Repor.ShowDialog();

            }
            catch (Exception Aa)
            {
                //Error
            }
        }


    }
}


//metodo setter y getter
public class CatProClass
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Estado { get; set; }

}
