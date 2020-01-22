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
    public partial class USUARIO : Form
    {
        public USUARIO()
        {
            InitializeComponent();
         
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Privilegios() {

            if (c_priv.SelectedIndex ==0)
            {
                mant_crear.Checked= true;
                mant_mod.Checked = true;
                mant_eli.Checked = false;
                rep_con.Checked = true;
                rep_exp.Checked = false;
                rep_imp.Checked = true;
                inv_cierre.Checked = false;
                inv_com.Checked = false;
                inv_ven.Checked = true;
            }
            else if (c_priv.SelectedIndex == 1)
            { 
            mant_crear.Checked = true;
            mant_mod.Checked = true;
            mant_eli.Checked = true;
            rep_con.Checked = true;
            rep_exp.Checked = true;
            rep_imp.Checked = true;
            inv_cierre.Checked = true;
            inv_com.Checked = true;
            inv_ven.Checked = true;
            }


        
        }

        private void c_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Privilegios();
        }
    }
}
