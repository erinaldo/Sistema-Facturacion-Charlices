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
    public partial class FormInicioResumen : Form
    {
        public FormInicioResumen()
        {
            InitializeComponent();
            Barra.Show();
            Codigo.DataPropertyName = "codigo";
            Nombre.DataPropertyName = "nombre_producto";
            Cantidad.DataPropertyName = "cantidad";
            RedordenD.DataPropertyName = "re_orden";
            EstadoD.DataPropertyName = "estado";
          
            LlenarTablaGrid();
            CargarDatosResumen();
        }

        VentanaLoading Barra = new VentanaLoading();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }



        public void CargarDatosResumen()
        {
            try
            {
                using (CRUD_MODEL datos = new CRUD_MODEL()) {
                    IQueryable<Clientes> Cli = datos.Clientes.Where(u => u.estado == true);
                    IQueryable<Productos> Pro = datos.Productos.Where(u => u.estado == true);
                    IQueryable<Suplidores> Sup = datos.Suplidores.Where(u => u.estado == true);
                  
                    txtClientesCount.Text = Cli.AsQueryable().Count().ToString();
                    txtProductosCount.Text = Pro.AsQueryable().Count().ToString();
                    txtSuplidoresCount.Text = Sup.AsQueryable().Count().ToString();
                }
            }
            catch (Exception error)
            {
                //Error Charly
            }
        }


        //Llenar Tabla Productos Bajos de Stock
        public void LlenarTablaGrid()
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    //IQueryable<Productos> 
                    var productos = from pro in DB.Productos
                                    join cat in DB.Categorias on pro.id_categoria
                             equals cat.id
                                    join unidad in DB.Unidades_medidas on pro.id_unidad_medida
                      equals unidad.id
                                    select new
                                    {
                                        pro.codigo,
                                        nombre_producto = pro.nombre,
                                        pro.cantidad,
                                        pro.re_orden,
                                        pro.estado,
                                    };
                    productos = productos.Where(pro => pro.estado==true && (pro.cantidad <= pro.re_orden));
                    TablaProductos.DataSource = productos.ToList();

                }
            }
            catch (Exception e)
            {
                //error
            }
        }
        
    }

}
