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
    public partial class FormCaja : Form
    {
        public FormCaja()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarAperturaCaja())
            {
                    Entrada_SalidaCaja obj = new Entrada_SalidaCaja();
                    obj.ShowDialog();
            }
        }

        //Panel Abrir Caja
        private void label5_Click(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarAperturaCaja(false))
            {

                AbrirCaja obj = new AbrirCaja();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ya se ha abierto la apertura de la caja del día.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarAperturaCaja())
            {
                    CerrarCaja obj = new CerrarCaja();
                    obj.ShowDialog();
            }
        }
    }
}
