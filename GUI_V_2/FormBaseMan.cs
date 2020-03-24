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
    public partial class FormBaseMan : Form
    {
        public FormBaseMan()
        {
            InitializeComponent();
            estado.SelectedIndex = 0;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                return;
            


        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void FormBaseMan_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                         this.DisplayRectangle);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
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
