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

namespace GUI_V_2.Consultas
{
    public partial class ConsCli : FormBaseCons
    {
        public ConsCli()
        {
            InitializeComponent();
            dataGridClientes.AutoGenerateColumns = false;
            id.DataPropertyName = "id";
            CodCli.DataPropertyName = "codigo";
            NomCli.DataPropertyName = "nombre_completo";
            CedCli.DataPropertyName = "cla_rnc";
            TelCli.DataPropertyName = "telefono";
            DirCli.DataPropertyName = "direccion";
            TipCli.DataPropertyName = "tipo_cliente";
            CorCli.DataPropertyName = "correo";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                var  clientes = from c in DB.Clientes
                                select new
                                {
                                   c.codigo,
                                   c.nombre_completo,
                                   c.cla_rnc,
                                   c.telefono,
                                   c.direccion,
                                   tipo_cliente  = c.tipo_cliente == 1 ? "NORMAL" : c.tipo_cliente == 2 ? "EMPRESA" : "EMPLEADO",
                                   c.correo,
                                   c.estado

                                };
                if (condicion.Equals(""))
                {
                    clientes = clientes.
                    Where(c => c.estado == true);
                }
                else
                {
                    clientes = clientes.
                    Where(c => (c.codigo.Contains(condicion) || c.nombre_completo.Contains(condicion) && c.estado == true));
                }

                
                dataGridClientes.DataSource = clientes.ToList();
            }
            nro_registros.Text = dataGridClientes.Rows.Count.ToString() + " REGISTROS.";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormClientes obj = new FormClientes();
            obj.ShowDialog();
            LlenarDataGrid();
        }

        private void ConsCli_Load(object sender, EventArgs e)
        {

        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarDataGrid(filtro.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.Rows.Count == 0) return;
            DialogResult = DialogResult.OK;
            Close();

        }
        
        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
        private void Editar()
        {
            if (this.dataGridClientes.Rows.Count > 0 && dataGridClientes.SelectedRows.Count > 0)
            {
                FormClientes obj = new FormClientes();
                obj.Show();
                obj.Codigo.Text = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
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

                List<ClientesClass> lista = new List<ClientesClass>();
                lista.Clear();

                for (int p = 0; p < dataGridClientes.Rows.Count; p++)
                {
                    lista.Add(new ClientesClass
                    {
                        Codigo = dataGridClientes.Rows[p].Cells[0].Value.ToString(),
                        Nombre = dataGridClientes.Rows[p].Cells[1].Value.ToString(),
                        Cedula = dataGridClientes.Rows[p].Cells[2].Value.ToString(),
                        Telefono = dataGridClientes.Rows[p].Cells[3].Value.ToString(),
                        Direccion = dataGridClientes.Rows[p].Cells[4].Value.ToString(),
                        Tipo = dataGridClientes.Rows[p].Cells[5].Value.ToString(),
                        Correo = dataGridClientes.Rows[p].Cells[6].Value.ToString(),
                        Estado = dataGridClientes.Rows[p].Cells[7].Value.ToString()
                    });
                }
                rs.Name = "DataSetCli";
                rs.Value = lista;
                Repor.reportViewer1.LocalReport.DataSources.Clear();
                Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.RepCli.rdlc";
                Repor.ShowDialog();

            }
            catch (Exception Aa)
            {
                //   MessageBox.Show("Hubo un fallo Charly");
            }
        }
    }
}



public class ClientesClass
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Correo { get; set; }
    public string Tipo { get; set; }
    public string Estado { get; set; }
}

