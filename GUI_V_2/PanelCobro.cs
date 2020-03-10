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
    public partial class PanelCobro : Form
    {
     

        public PanelCobro()
        {
            InitializeComponent();
            LlenarComboxMetodosPagos();
            c_metodopago.SelectedIndex = 2;
            txt_pago.Focus();

        }

       
        public void LlenarComboxMetodosPagos()
        {
            c_metodopago.DisplayMember = "nombre";
            c_metodopago.ValueMember = "id";
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Metodos_Pagos> metodos = db.Metodos_Pagos.Where(m => m.estado == true).OrderBy(m => m.nombre);
                    c_metodopago.DataSource = metodos.ToList();
                }
            }
            catch (Exception)
            {

            }

        }


        //Boton volver
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Salir ve cobro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //metodo que aplica el borde al panel
        private void PanelCobro_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                           this.DisplayRectangle);
        }

        double monto_actual = 0, pago = 0;

        //Evento que hace el calculo del devuelto para el cliente.
        private void txt_pago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //  if (txt_pago.Text.Equals("")) txt_devuelto.Text = "0";            
                monto_actual = Convert.ToDouble(txt_monto.Text.Trim());
                pago = Convert.ToDouble(txt_pago.Text.Trim());
                txt_devuelto.Text = (pago - monto_actual).ToString();

            }
            catch (Exception error)
            {

            }

        }

        private void panel_dosmil_Click(object sender, EventArgs e)
        {
            Calcular(2000);
        }

        private void panel_mil_Click(object sender, EventArgs e)
        {
            Calcular(1000);
        }

        private void panel_quiniento_Click(object sender, EventArgs e)
        {
            Calcular(500);
        }

        private void panel_dociento_Click(object sender, EventArgs e)
        {
            Calcular(200);
        }

        private void panel_cien_Click(object sender, EventArgs e)
        {
            Calcular(100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_pago.Text = "0";
            txt_devuelto.Text = "0";
        }

        private void PanelCobro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_volver.PerformClick();
            }
        }


        //Boton con ticket
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (Convert.ToDouble(txt_pago.Text.Trim()) >= Convert.ToDouble(txt_monto.Text.Trim())) {
                    Utilidades.ConFact = 1;
                    Utilidades.NotaVenta = TxtNota.Text.Trim();
                    DialogResult = DialogResult.OK;
                    //this.Hide();
                }
                else{
                    MessageBox.Show("El monto de la factura es mayor que el pago del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception asd)
            {
              //  MessageBox.Show("Error al convertir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Boton sin ticket
        private void button2_Click(object sender, EventArgs e)
        {

             try {
                if (Convert.ToDouble(txt_pago.Text.Trim())>=Convert.ToDouble(txt_monto.Text.Trim())) {
                    Utilidades.ConFact = 0;      
                    DialogResult = DialogResult.OK;
                    //this.Hide();
                }
                else{
                    MessageBox.Show("El monto de la factura es mayor que el pago del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception asd)
            {
              //  MessageBox.Show("Error al convertir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanelCobro_Load(object sender, EventArgs e)
        {

        }

        //Solo numero TextBox
        private void txt_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNota_DoubleClick(object sender, EventArgs e)
        {
          
        }

        //Metodo que manda el monto seleccionado con el usuario


        private void Calcular(double mas)
        {
            try
            {
                if (txt_pago.Text.Equals("")) txt_pago.Text = "0";
                pago = Convert.ToDouble(txt_pago.Text.Trim());
                txt_pago.Text = (pago + mas).ToString();

            }
            catch (Exception error)
            {


            }

        }

        /*
        FacturaClass DatosVenta = new FacturaClass();
        public void ImprimirTicketVenta()
        {
            FormConGen empresa = new FormConGen();
            
            //Creamos una instancia d ela clase CrearTicket
            Factura ticket = new Factura();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(empresa.NomEmpresa.Text);
       //     ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda(empresa.DirEmpresa.Text);
            ticket.TextoIzquierda(empresa.NumEmpresa.Text);
            ticket.TextoIzquierda("R.N.C: "+ empresa.RncEmpresa.Text);
        //    ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("# ORDEN: ",DatosVenta.NumOrden); 
            ticket.lineasAsteriscos();

           
            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Factura: " + DatosVenta.NumFac);
            ticket.TextoIzquierda("Cliente: "+DatosVenta.CodCli+" - "+DatosVenta.NomCli);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Fecha: " + DateTime.Now.ToShortDateString(), " " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL......$", 100);
            ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }
        */


    }
}
