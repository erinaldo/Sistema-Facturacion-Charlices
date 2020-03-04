using GUI_V_2.Reportes;
using Microsoft.Reporting.WinForms;
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
    public partial class PanelCobro : Form
    {
        public PanelCobro()
        {
            InitializeComponent();
            c_metodopago.SelectedIndex = 0;
            LlenarComboxMetodosPagos();

        }

        public void LlenarComboxMetodosPagos()
        {
            c_metodopago.DisplayMember = "nombre";
            c_metodopago.ValueMember = "id";
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Metodos_Pagos> metodos = db.Metodos_Pagos.Where(m => m.estado == true).OrderBy(m => m.nombre);
                    c_metodopago.DataSource = metodos.ToList();
                }
            }
            catch (Exception)
            {

            }

        }


        //Boton volver
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Salir ve cobro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //metodo que aplica el borde al panel
        private void PanelCobro_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                           this.DisplayRectangle);
        }

        double monto_actual = 0, pago = 0;

        //Evento que hace el calculo del devuelto para el cliente.
        private void txt_pago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //  if (txt_pago.Text.Equals("")) txt_devuelto.Text = "0";            
                monto_actual = Convert.ToDouble(txt_monto.Text.Trim());
                pago = Convert.ToDouble(txt_pago.Text.Trim());
                txt_devuelto.Text = (pago - monto_actual).ToString();

            }
            catch (Exception error)
            {

            }

        }

        private void panel_dosmil_Click(object sender, EventArgs e)
        {
            Calcular(2000);
        }

        private void panel_mil_Click(object sender, EventArgs e)
        {
            Calcular(1000);
        }

        private void panel_quiniento_Click(object sender, EventArgs e)
        {
            Calcular(500);
        }

        private void panel_dociento_Click(object sender, EventArgs e)
        {
            Calcular(200);
        }

        private void panel_cien_Click(object sender, EventArgs e)
        {
            Calcular(100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_pago.Text = "0";
            txt_devuelto.Text = "0";
        }

        private void PanelCobro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_volver.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void PanelCobro_Load(object sender, EventArgs e)
        {

        }

        //Metodo que manda el monto seleccionado con el usuario
        private void Calcular(double mas)
        {
            try
            {
                if (txt_pago.Text.Equals("")) txt_pago.Text = "0";
                pago = Convert.ToDouble(txt_pago.Text.Trim());
                txt_pago.Text = (pago + mas).ToString();

            }
            catch (Exception error)
            {


            }

        }

    }
}
