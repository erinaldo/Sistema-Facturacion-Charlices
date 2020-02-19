using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_V_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Animar();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
  //      ReleaseCapture();
  //      SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMantenimientos());
            AnimacionPequena();
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInicioResumen());
            AnimacionPequena();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null,e);
            AnimacionPequena();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormClientes());
            AnimacionPequena();
        }

        private void Animar() {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 60;
            }
            else
                MenuVertical.Width = 250;
        }

        private void AnimacionPequena()
        {
            MenuVertical.Width = 60;
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormReportes());
            AnimacionPequena();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EN PROCESO DE DESARROLLO...","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
;        }

        private void btnven_Click(object sender, EventArgs e) 
        {
            AbrirFormEnPanel(new FormCONSULTAS());
            AnimacionPequena();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConGen());
            AnimacionPequena();
        }

        private void btncom_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ventas_Compras());
            AnimacionPequena();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCaja());
            AnimacionPequena();
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

   
        //Funciones rapidas... para rapido acceso !
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                VentasModoTouch obj = new VentasModoTouch();
                obj.ShowDialog();
            }
            if (e.KeyCode == Keys.F7)
            {
                Salidas obj = new Salidas();
                obj.ShowDialog();
            }
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            VentasModoTouch obj = new VentasModoTouch();
            obj.ShowDialog();
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            Salidas obj = new Salidas();
            obj.ShowDialog();
        }

    }
}
