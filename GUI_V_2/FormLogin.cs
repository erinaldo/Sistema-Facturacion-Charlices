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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btn_entrar.Focus();
        }
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_user.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         Form1 ventana = new Form1();
            this.Hide();
            ventana.Show();
   
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode==Keys.Enter)
            {
                btn_entrar.PerformClick();
            }
        }

    }
    }
