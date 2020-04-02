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
    public partial class CerrarCaja : Form
    {
        public CerrarCaja()
        {
            InitializeComponent();
        }

        //Boton Cerrar Caja
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Accion cerrar Caja
        private void btn_cerrarCaja_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1))
                return;

            //Consultar que el usuario y la contrasena entren y coincian con el usuario loggeado.
            /*
               //Codigo para valdar el usuario
            
            */
            //Luego de validado preguntaremos si esta seguro de hacer el cierre de caja:
           if(DialogResult.Yes == MessageBox.Show("No se puede vender por hoy, luego del cierre de caja. Esta seguro que desea continiar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Metodo cerrar caja
            }
           
        }
        

        //Metodo cerrar caja






    }
}
