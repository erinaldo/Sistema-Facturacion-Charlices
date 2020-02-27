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
        public VentanaLoading()
        {
            InitializeComponent();
            BarraPro.Value = 50;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarraPro.Increment(1);
            if (BarraPro.Value==100)
            {
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
