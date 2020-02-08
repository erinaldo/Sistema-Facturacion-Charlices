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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
                {
                    VisitLink();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, intente de nuevo mas tarde.");
                }
            }

            private void VisitLink()
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=18098862933&text=Soporte%20!");
            }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 ventana = new Form1();
            ventana.Show();
          
        }
    }
    }
