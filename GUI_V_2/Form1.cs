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
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
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
            AbrirFormEnPanel(new Mantenimientos());
            AnimacionPequena();
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
            AnimacionPequena();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null,e);
            AnimacionPequena();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes());
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
            AbrirFormEnPanel(new Reportes());
            AnimacionPequena();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new USUARIO());
            AnimacionPequena();
        }

        private void btnven_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CONSULTAS());
            AnimacionPequena();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConGen());
            AnimacionPequena();
        }

        private void btncom_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ventas_Compras());
            AnimacionPequena();
        }
    }
}
