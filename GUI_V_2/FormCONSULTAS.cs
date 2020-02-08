using GUI_V_2.Consultas;
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
    public partial class FormCONSULTAS : Form
    {
        public FormCONSULTAS()
        {
            InitializeComponent();
        }
        
        private void AbrirFormEnPanel(object Mentenimientos)
        {
            if (this.panel_consultas.Controls.Count > 0)
                this.panel_consultas.Controls.RemoveAt(0);
            Form fh = Mentenimientos as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_consultas.Controls.Add(fh);
            this.panel_consultas.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           AbrirFormEnPanel( new ConsCli());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsCatProd());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsSup());
        }
    }
}
