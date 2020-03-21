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
    public partial class AbrirCaja : Form
    {
        public AbrirCaja()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirCaja_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                          this.DisplayRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarFormulario(this, errorProvider1))
            {
                using( CRUD_MODEL DB = new CRUD_MODEL())
                {
                    Aperturas_Cajas caja = new Aperturas_Cajas
                    {
                        fecha = DateTime.Now,
                        id_usuario = Utilidades.id_usuario,
                        monto_inicial = float.Parse(txt_monto.Text.Trim())
                    };

                    DB.Aperturas_Cajas.Add(caja);
                    DB.SaveChanges();
                    MessageBox.Show("El monto se ha guardado correctamente.");
                    this.Close();
                }
            }
        }

        private void AbrirCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
