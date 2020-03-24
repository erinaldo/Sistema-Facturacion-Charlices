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
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Entradas_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                           this.DisplayRectangle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
