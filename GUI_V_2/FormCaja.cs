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



        private void AbrirFormEnPanel(object FormEnCaja)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = FormEnCaja as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarAperturaCaja())
            {
                string mensaje = "No se puede dar entrada/salida a caja, ya que hoy se realizó el cierre de caja.";
                if (!Utilidades.Caja_Cerrada(mensaje))
                {
                    Entrada_SalidaCaja obj = new Entrada_SalidaCaja();
                    obj.ShowDialog();
                }

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
                string mensaje = "Ya hoy se había realizado el cierre de caja.";
                if (!Utilidades.Caja_Cerrada(mensaje))
                {
                    CerrarCaja obj = new CerrarCaja();
                    obj.ShowDialog();
                }
                   
            }
        }

        private void txt_ResumenCaja_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ResumenCaja());
        }
    }
}
