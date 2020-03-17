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
    public partial class ConsPro : FormBaseCons
    {
        public ConsPro()
        {
            InitializeComponent();
            dataGridVProducto.AutoGenerateColumns = false;
            id.DataPropertyName = "id";
            CodPro.DataPropertyName = "codigo";
            NomPro.DataPropertyName = "nombre_producto";
            CatPro.DataPropertyName = "nombre_categoria";
            cocina.DataPropertyName = "cocina";
            PreNor.DataPropertyName = "precio_normal";
            PreEmp.DataPropertyName = "precio_empleado";
            PreEmpresa.DataPropertyName = "precio_empresa";
            Unidad.DataPropertyName = "unidad";
            itbis.DataPropertyName = "itbis";
            CanPro.DataPropertyName = "cantidad";
            Reorden.DataPropertyName = "re_orden";
            TipPro.DataPropertyName = "tipo_producto";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormProductos obj = new FormProductos();
            obj.ShowDialog();
            LlenarDataGrid();
        }

        private void ConsPro_Load(object sender, EventArgs e)
        {

        }


        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
               
        
                var productos =  from pro in DB.Productos join cat in DB.Categorias on pro.id_categoria
                                                   equals cat.id join unidad in DB.Unidades_medidas on pro.id_unidad_medida
                                                   equals unidad.id
                                                    select new {
                                                       pro.codigo,
                                                       pro.id,
                                                       nombre_producto = pro.nombre,
                                                       nombre_categoria = cat.nombre,
                                                       cat.cocina,
                                                       pro.precio_normal,
                                                       pro.precio_empleado,
                                                       pro.precio_empresa,
                                                       unidad = unidad.nombre,
                                                       pro.itbis,
                                                       pro.cantidad,
                                                       pro.re_orden,
                                                       tipo_producto  = pro.tipo_producto==1 ? "Inventario" : "Servicio",
                                                       pro.estado
                                                    };

                if (condicion.Equals(""))
                {
                    productos = productos.Where(pro => pro.estado == true);

                }
                else
                {
                    productos = productos.Where(pro => pro.estado == true && (pro.codigo.Contains(condicion) || pro.nombre_producto.Contains(condicion)));
                }

                    dataGridVProducto.DataSource = productos.ToList();
            }
            nro_registros.Text = dataGridVProducto.Rows.Count.ToString() + " REGISTROS.";
        }

        private void filtro_Leave(object sender, EventArgs e)
        {
        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarDataGrid(filtro.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridVProducto.Rows.Count == 0)  return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dataGridVProducto_DoubleClick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void dataGridVProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
            LlenarDataGrid();
          }
        
        private void Editar()
        {
            
            if (this.dataGridVProducto.Rows.Count > 0 && dataGridVProducto.SelectedRows.Count > 0)
            {
                FormProductos obj = new FormProductos();
                obj.Show();
                obj.Codigo.Text = dataGridVProducto.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
               

            }

        }


        ReportDataSource rs = new ReportDataSource();
        //Boton para imprimir
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportesDatos Repor = new FormReportesDatos();
              
                List<ProductosClass> lista = new List<ProductosClass>();
                lista.Clear();
                
                for (int p = 0; p < dataGridVProducto.Rows.Count ; p++){
                        lista.Add(new ProductosClass {
                        Codigo = dataGridVProducto.Rows[p].Cells[0].Value.ToString(),
                        Nombre = dataGridVProducto.Rows[p].Cells[1].Value.ToString(),
                        Categoria = dataGridVProducto.Rows[p].Cells[2].Value.ToString(),
                        Normal = dataGridVProducto.Rows[p].Cells[3].Value.ToString(),
                        Empleado = dataGridVProducto.Rows[p].Cells[4].Value.ToString(),
                        Empresa = dataGridVProducto.Rows[p].Cells[5].Value.ToString(),
                        Unidad = dataGridVProducto.Rows[p].Cells[6].Value.ToString(),
                        ITBIS = dataGridVProducto.Rows[p].Cells[7].Value.ToString(),
                        Cantiadad = dataGridVProducto.Rows[p].Cells[8].Value.ToString(),
                        Reorden = dataGridVProducto.Rows[p].Cells[9].Value.ToString(),
                        Tipo = dataGridVProducto.Rows[p].Cells[10].Value.ToString(),
                        Estado = dataGridVProducto.Rows[p].Cells[11].Value.ToString()
                    });
                }
                
                rs.Name = "DataSet1";
                rs.Value = lista;
                Repor.reportViewer1.LocalReport.DataSources.Clear();
                Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.Report1.rdlc";
                Repor.ShowDialog();


            }
            catch (Exception Aa)
            {
                MessageBox.Show("Hubo un fallo Charly");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


public class ProductosClass
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public string Normal { get; set; }
    public string Empleado { get; set; }
    public string Empresa { get; set; }
    public string Unidad { get; set; }
    public string ITBIS { get; set; }
    public string Cantiadad { get; set; }
    public string Reorden { get; set; }
    public string Tipo { get; set; }
    public string Estado { get; set; }
    
}
