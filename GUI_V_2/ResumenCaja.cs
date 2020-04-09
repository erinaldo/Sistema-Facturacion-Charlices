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
        public ResumenCaja()
        {
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

        String Fecha;


        private void ResumirCaja()
        {
            try
            {

                MessageBox.Show("ENTRO AL METODO.");
                //entrada salida
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    //c.fecha == Convert.ToDateTime(Fecha)
                    MessageBox.Show("ENTRO A CALCULAR");
                    IQueryable<Entrada_Salida_Caja> caja = DB.Entrada_Salida_Caja.Where(c => c.estado == true );
                    MessageBox.Show("CANTIDAD DE CAJA: " + caja.ToList().Count);
                    MessageBox.Show("Fecha en caja: " + caja.ToList()[0].fecha+" Fecha nuestra: "+Fecha);

                }




            }
            catch(Exception a)
            {
                //error
            }



        }


        //Valor monto apertura
        private void MontoApertura()
        {


            
        }

        //Valor monto apertura
        private void ResumenVentas()
        {

            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                //c.fecha == Convert.ToDateTime(Fecha)
                MessageBox.Show("ENTRO A CALCULAR");
                IQueryable<Entrada_Salida_Caja> caja = DB.Entrada_Salida_Caja.Where(c => c.estado == true);
               
            }


        }




    }
}
