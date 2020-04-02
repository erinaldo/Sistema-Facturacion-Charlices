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
    public partial class FormComprabantes : FormBaseMan
    {
        public FormComprabantes()
        {
            InitializeComponent();
            //Validando que sea administrador para modificar
            if (Utilidades.tipo_usuario != 1)
            {
                MessageBox.Show("Solo un administrador puede gestionar los mantenimientos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_guardar.Visible = false;
                bnt_eliminar.Visible = false;
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsComprobante obj = new ConsComprobante();
            obj.ShowDialog();
        }

        private void FormComprabantes_Load(object sender, EventArgs e)
        {

        }

        //solo numeros
        private void NumOrden_KeyPress(object sender, KeyPressEventArgs e)
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


        //solo numeros
        private void ComUsa_KeyPress(object sender, KeyPressEventArgs e)
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
