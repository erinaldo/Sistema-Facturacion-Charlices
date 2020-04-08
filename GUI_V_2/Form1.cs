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
            Loading.Show();
            //Asignando datos del usuario registrado
            lbluser.Text = Utilidades.NombreUsuario;
            if (Utilidades.tipo_usuario == 1)
            {
                lblusuario.Text = "ADMINISTRADOR";
                
            }
            else if (Utilidades.tipo_usuario == 2)
            { 
                lblusuario.Text = "CAJERO";
                MenuVertical.Enabled = false;
            }


        }


        VentanaLoading Loading = new VentanaLoading();


        private void btnMenu_Click(object sender, EventArgs e)
        {
            Animar();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Cerrar la sesion ?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
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
            AbrirFormEnPanel(new FormCONSULTAS());
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
                AbrirFormVenta();
            }
            if (e.KeyCode == Keys.F7)
            {
                AbrirFormEntradaSalidaCajaVenta();
            }
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            AbrirFormVenta();

        }

        public void AbrirFormVenta()
        {
            if (Utilidades.ValidarAperturaCaja())
            {
                string mensaje = "No podra realizar ventas el día de hoy, ya que se realizó el cierre de caja.";
                if (!Utilidades.Caja_Cerrada(mensaje))
                {
                    VentasModoTouch obj = new VentasModoTouch();
                    obj.ShowDialog();
                }
                  
            }
                
        }

        public void AbrirFormEntradaSalidaCajaVenta()
        {
            if (Utilidades.ValidarAperturaCaja())
            {
                string mensaje = "No se puede dar entrada/salida a caja, ya que hoy se realizó el cierre de caja.";
                if (!Utilidades.Caja_Cerrada(mensaje))
                {
                    Entrada_SalidaCaja obj = new Entrada_SalidaCaja();
                    obj.ShowDialog();
                }
                    
            }

        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            AbrirFormEntradaSalidaCajaVenta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Utilidades.ValidarAperturaCaja(false))
            {
                AbrirCaja obj = new AbrirCaja();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("La se hizo la apertura de caja, puede vender.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
