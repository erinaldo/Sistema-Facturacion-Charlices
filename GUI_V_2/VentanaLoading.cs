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
    public partial class VentanaLoading : Form
    {
        private int Tiempo;  

        public VentanaLoading()
        {
            InitializeComponent();
            Tiempo = 0;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo++;
            label16.Text = "Cargando inicio, favor espere... " + Tiempo.ToString();
            if (Tiempo == 3)
            {
                label16.Text = "Listo...";
                timer1.Stop();
                this.Close();
            }
        }

        private void VentanaLoading_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DarkGray,3),
                          this.DisplayRectangle);

        }
    }
}
