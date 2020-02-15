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
    public partial class VentasModoTouch : Form
    {
        public VentasModoTouch()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Salir de ventas ?", "Confirme", MessageBoxButtons.YesNo);
            if(pregunta == DialogResult.Yes)
            {
                this.Dispose();
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha_hora.Text = DateTime.Now.ToString("hh:mm ") + DateTime.Now.ToShortDateString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PanelCobro obj = new PanelCobro();
            obj.ShowDialog();

        }

        //Funciones rapidas con teclas
        private void VentasModoTouch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
            btn_volver.PerformClick();

            }

            if (e.KeyCode == Keys.F12)
            {
                btn_cobrar.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btn_verProductos.PerformClick();
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsPro obj = new ConsPro();
            obj.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ConsCli obj = new ConsCli();
            obj.ShowDialog();
        }
    }
}
