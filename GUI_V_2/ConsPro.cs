using GUI_V_2.Reportes;
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
            CodPro.DataPropertyName = "codigo";
            NomPro.DataPropertyName = "nombre_producto";
            CatPro.DataPropertyName = "nombre_categoria";
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
                //IQueryable<Productos> 
        
                var productos =  from pro in DB.Productos join cat in DB.Categorias on pro.id_categoria
                                                   equals cat.id join unidad in DB.Unidades_medidas on pro.id_unidad_medida
                                                   equals unidad.id
                                                    select new {
                                                       pro.codigo,
                                                       pro.id,
                                                       nombre_producto = pro.nombre,
                                                       nombre_categoria = cat.nombre,
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
            if (dataGridVProducto.Rows.Count == 0)
                return;
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FormReportesDatos Rep = new FormReportesDatos();
                List<ProductosClass> lista = new List<ProductosClass>();
                lista.Clear();
                int a = 0;


                for (int p = 0; p < dataGridVProducto.RowCount; p++){
                   
                    lista.Add(new ProductosClass{
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
                        Estado = Convert.ToBoolean(dataGridVProducto.Rows[p].Cells[11].Value)
                    });
                }
                Rep.ShowDialog();
              
            }
            catch (Exception Aa)
            {
                MessageBox.Show("Hubo un fallo Charly");
            }
        }

    }
}


public class ProductosClass
{
    public String Codigo { get; set; }
    public String Nombre { get; set; }
    public String Categoria { get; set; }
    public String Normal { get; set; }
    public String Empleado { get; set; }
    public String Empresa { get; set; }
    public String Unidad { get; set; }
    public String ITBIS { get; set; }
    public String Cantiadad { get; set; }
    public String Reorden { get; set; }
    public String Tipo { get; set; }
    public Boolean Estado { get; set; }
    
}
