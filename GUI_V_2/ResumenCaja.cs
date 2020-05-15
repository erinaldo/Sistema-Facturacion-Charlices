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

                    MessageBox.Show(tipo_resumen);
                    if (tipo_resumen == "cierre_caja") {
                        var res = DB.Procedimiento_total_caja(tipo_resumen, Utilidades.id_usuario);
                        Total_Caja_Result totales_caja = res.FirstOrDefault();
                        this.Cierre_Caja(totales_caja);
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
            total_efectivo.Text = totales_caja.total_ventas_efectivo.ToString();
            anuladas.Text = totales_caja.anulada.ToString();
            totales_ventas.Text = (totales_caja.total_ventas_efectivo + totales_caja.apertura_caja).ToString();

            //movimiento caja
            apertura.Text = totales_caja.apertura_caja.ToString();
            entradas.Text = totales_caja.entrada_caja.ToString();
            salidas.Text = totales_caja.salida_caja.ToString();
            total_movimiento_caja.Text = ((totales_caja.apertura_caja + totales_caja.entrada_caja) - totales_caja.salida_caja).ToString();

            total_efectivo_caja.Text = totales_caja.total_efectivo_caja.ToString();

        }

        private void ResumenVentas(Resumen_caja_Result totales_caja)
        {

            totales_ventas.Text = totales_caja.total_ventas.ToString();
            label4.Visible = true;
            disponibles.Visible = true;
            disponibles.Text = totales_caja.total_disponible.ToString();
            anuladas.Text = totales_caja.anulada.ToString();


            total_efectivo.Text = totales_caja.total_ventas_efectivo.ToString();

            //movimiento caja
            apertura.Text = totales_caja.apertura_caja.ToString();
            entradas.Text = totales_caja.entrada_caja.ToString();
            salidas.Text = totales_caja.salida_caja.ToString();
            total_movimiento_caja.Text = ((totales_caja.apertura_caja + totales_caja.entrada_caja) - totales_caja.salida_caja).ToString();

            total_efectivo_caja.Text = (Double.Parse(total_movimiento_caja.Text) + Double.Parse(total_efectivo.Text)).ToString();


        }

        private void ResumenCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
