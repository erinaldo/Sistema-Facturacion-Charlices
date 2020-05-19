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
    public partial class ResumenCaja : Form
    {
        public String tipo_resumen;
        public ResumenCaja(String tipo_resumen="")
        {
            this.tipo_resumen = tipo_resumen;
            InitializeComponent();
            ResumirCaja();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ResumirCaja()
        {
            try
            {

                //entrada salida
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {

                    if (tipo_resumen == "cierre_caja") {
                        var res = DB.Procedimiento_total_caja(tipo_resumen, Utilidades.id_usuario);
                        Total_Caja_Result totales_caja = res.FirstOrDefault();
                        this.Cierre_Caja(totales_caja);
                        //Ticket de cierre 
                        if (DialogResult.Yes == MessageBox.Show("¿Desea imprimir ticket de cierre?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            TicketCierreCaja();
                        }
                    }
                    else
                    {
                        var res = DB.Resumen_caja();
                        Resumen_caja_Result totales_caja = res.FirstOrDefault();
                        this.ResumenVentas(totales_caja);
                    }



                }




            }
            catch(Exception a)
            {
                //error
            }
            finally
            {
                tipo_resumen = "";
            }



        }


       
        private void Cierre_Caja(Total_Caja_Result totales_caja)
        {

            try { 
            total_efectivo.Text = totales_caja.total_ventas_efectivo.ToString();
            anuladas.Text = totales_caja.anulada.ToString();
            totales_ventas.Text = (totales_caja.total_ventas_efectivo + totales_caja.apertura_caja).ToString();

            //movimiento caja
            apertura.Text = totales_caja.apertura_caja.ToString();
            entradas.Text = totales_caja.entrada_caja.ToString();
            salidas.Text = totales_caja.salida_caja.ToString();
            total_movimiento_caja.Text = ((totales_caja.apertura_caja + totales_caja.entrada_caja) - totales_caja.salida_caja).ToString();

            total_efectivo_caja.Text = totales_caja.total_efectivo_caja.ToString();
        }catch(Exception ee)
            {
                //error
            }

}

        private void ResumenVentas(Resumen_caja_Result totales_caja)
        {

            try
            {
                totales_ventas.Text = string.Format("{0:0,0.0}", totales_caja.total_ventas.ToString());
                label4.Visible = true;
                disponibles.Visible = true;
                disponibles.Text = string.Format("{0:0,0.0}", totales_caja.total_disponible.ToString());
                anuladas.Text = string.Format("{0:0,0.0}", totales_caja.anulada.ToString());


                total_efectivo.Text = string.Format("{0:0,0.0}", totales_caja.total_ventas_efectivo.ToString());

                //movimiento caja
                apertura.Text = string.Format("{0:0,0.0}", totales_caja.apertura_caja.ToString());
                entradas.Text = string.Format("{0:0,0.0}", totales_caja.entrada_caja.ToString());
                salidas.Text = string.Format("{0:0,0.0}", totales_caja.salida_caja.ToString());
                total_movimiento_caja.Text = string.Format("{0:0,0.0}", ((totales_caja.apertura_caja + totales_caja.entrada_caja) - totales_caja.salida_caja).ToString());

                total_efectivo_caja.Text = string.Format("{0:0,0.0}", (Double.Parse(total_movimiento_caja.Text) + Double.Parse(total_efectivo.Text)).ToString());
            }catch(Exception ee)
            {
                //error
            }

        }

        private void ResumenCaja_Load(object sender, EventArgs e)
        {

        }





        public void TicketCierreCaja()
        {
            FormConGen empresa = new FormConGen();
            //Creamos una instancia d ela clase CrearTicket
            Factura ticket = new Factura();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(empresa.NomEmpresa.Text);
            // ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            // ticket.TextoIzquierda("R.N.C: " + empresa.RncEmpresa.Text); //RNC EMPRESA
            // ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");

            ticket.TextoCentro("-- Cierre de caja --");
            ticket.lineasAsteriscos();
            //Sub cabecera.
            ticket.TextoExtremos("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy"), " " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Usuario: " + Utilidades.id_usuario + " - " + Utilidades.NombreUsuario);

            ticket.lineasAsteriscos();
            ticket.TextoCentro("DETALLE DE CIERRE:");
            ticket.lineasIgual();

            ticket.TextoIzquierda("Resumen de ventas:");
            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         TOTAL VENTAS....RD$", totales_ventas.Text.Trim());
            ticket.AgregarTotales("         DISPONIBLES.....RD$", disponibles.Text.Trim());
            ticket.AgregarTotales("         ANULADAS........RD$", anuladas.Text.Trim());
            ticket.AgregarTotales("         TOTAL EFECTIVO..RD$", total_efectivo.Text.Trim());
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Movimientos en caja:");
            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         MONTO APERTURA..RD$", apertura.Text.Trim());
            ticket.AgregarTotales("         ENTRADAS........RD$", entradas.Text.Trim());
            ticket.AgregarTotales("         SALIDAS.........RD$", salidas.Text.Trim());
            ticket.AgregarTotales("         TOTAL EFECTIVO..RD$", total_movimiento_caja.Text.Trim());
            ticket.TextoIzquierda("");
            ticket.TextoCentro("TOTAL RESULTANTE:");
            ticket.TextoCentro("RD$ " + total_efectivo_caja.Text.Trim());
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            //Texto final del Ticket.
            ticket.TextoCentro("________________________________");
            ticket.TextoCentro("FIRMA");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            ticket.ImprimirTicket("EPSON TM-T88IV ReStick");//Nombre de la impresora ticketera           
        }





    }
}
