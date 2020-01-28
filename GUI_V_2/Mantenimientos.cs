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
    public partial class Mantenimientos : Form
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes());
        }
        
        private void AbrirFormEnPanel(object Mentenimientos)
        {
            if (this.formHijo2.Controls.Count > 0)
                this.formHijo2.Controls.RemoveAt(0);
            Form fh = Mentenimientos as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.formHijo2.Controls.Add(fh);
            this.formHijo2.Tag = fh;
            fh.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new USUARIO());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Suplidores());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Productos());
        }
    }
}
