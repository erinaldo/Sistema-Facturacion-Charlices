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
            Nombre.DataPropertyName = "nombre";
            Cantidad.DataPropertyName = "cantidad";
            RedordenD.DataPropertyName = "re_orden";
            EstadoD.DataPropertyName = "estado";
            LlenarTablaGrid();
            CargarDatosResumen();
        }
      

        VentanaLoading Barra = new VentanaLoading();
        Form1 Principal = new Form1();

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        int a = 0;

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
                    IQueryable<Productos> productos = DB.Productos.Where(pro => pro.estado==true 
                    && (pro.cantidad <= pro.re_orden) && pro.tipo_producto==1);
                    TablaProductos.DataSource = productos.Select(p=>new {p.codigo,p.nombre,p.cantidad}) .ToList();

                }
            }
            catch (Exception e)
            {
                //error
            }
        }

        private void FormInicioResumen_Load(object sender, EventArgs e)
        {

        }

        //boton Cliente
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal.btn_man.PerformClick();
            
        }

       //Boton Productos
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Principal.btn_man.PerformClick();
        }

       //boton Suplidores
        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Principal.btn_man.PerformClick();
        }


        //boton Ventas
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Principal.btn_man.PerformClick();

        }
    }

}
