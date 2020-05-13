using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI_V_2
{
    class Utilidades
    {
        
        public static int ConFact = 1;
        public static string NotaVenta = "";

        public static string mesero = "";
        public static int id_usuario = 0;
        public static int tipo_usuario = 0;
        public static string NombreUsuario = "";


        public static Boolean ValidarFormulario(Control objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayError = false;

            foreach (Control Item in objeto.Controls)
            {
                if(Item is ErrorTxtBox){
                    ErrorTxtBox obj = (ErrorTxtBox)Item;
                    if (obj.Validar==true)
                    {
                        if (String.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar en blanco");
                            HayError = true;

                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(obj,"");
                    }
          
                }

            }

            return HayError;
        }



        public static bool ValidarAperturaCaja(bool mostrarMensaje = true)
        {
            bool estado = true;
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                DateTime fechaInicio = DateTime.Today;
                DateTime fechaFinal= DateTime.Now;

                IQueryable<Aperturas_Cajas> caja = DB.Aperturas_Cajas.Where(c => c.fecha>=fechaInicio  && c.fecha <= fechaFinal);
                var resp = caja.FirstOrDefault();
                if (resp == null)
                {
                    
                    if(mostrarMensaje) MessageBox.Show("No se le ha dado la apertura del día a la caja.");
                    estado  = false; 
                }
                return estado;
            }
        }


        public static bool Caja_Cerrada(string mensaje)
        {
            bool estado = true;
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                DateTime fechaInicio = DateTime.Today;
                DateTime fechaFinal = DateTime.Now;

                IQueryable<Cierre_Caja> caja = DB.Cierre_Caja.Where(c => c.fecha >= fechaInicio && c.fecha <= fechaFinal);
                var resp = caja.FirstOrDefault();
                if (resp == null) estado = false;
                else MessageBox.Show(mensaje);
                return estado;
            }
        }


        public static void LimpiarControles(Control forms)
        {

            foreach (Control Item in forms.Controls)
            {
                if (Item is ErrorTxtBox obj)
                {
                    if (obj.Limpiar)
                    {
                        obj.Text = "";
                    }
                }
                else if (Item is DataGridView dataGrid)
                {
                    dataGrid.Rows.Clear();
                }else if(Item is ComboBox combox)
                {
                    combox.SelectedIndex = 0;
                }else if (Item is NumericUpDown numeric)
                {
                    numeric.Value = 0;
                }
                if (Item.Controls.Count > 0)
                {
                    LimpiarControles(Item);
                }

            }

        }



    }
}

public class MessageBoxTemporal
{
    System.Threading.Timer IntervaloTiempo;
    string TituloMessageBox;
    string TextoMessageBox;
    int TiempoMaximo;
    IntPtr hndLabel = IntPtr.Zero;
    bool MostrarContador;

    MessageBoxTemporal(string texto, string titulo, int tiempo, bool contador)
    {
        TituloMessageBox = titulo;
        TiempoMaximo = tiempo;
        TextoMessageBox = texto;
        MostrarContador = contador;

        if (TiempoMaximo > 99) return; //Máximo 99 segundos
        IntervaloTiempo = new System.Threading.Timer(EjecutaCada1Segundo,
            null, 1000, 1000);
        if (contador)
        {
            DialogResult ResultadoMensaje = MessageBox.Show(texto + "\r\nEste mensaje se cerrará dentro de " +
                TiempoMaximo.ToString("00") + " segundos ...", titulo);
            if (ResultadoMensaje == DialogResult.OK) IntervaloTiempo.Dispose();
        }
        else
        {
            DialogResult ResultadoMensaje = MessageBox.Show(texto + "...", titulo);
            if (ResultadoMensaje == DialogResult.OK) IntervaloTiempo.Dispose();
        }
    }
    public static void Show(string texto, string titulo, int tiempo, bool contador)
    {
        new MessageBoxTemporal(texto, titulo, tiempo, contador);
    }
    void EjecutaCada1Segundo(object state)
    {
        TiempoMaximo--;
        if (TiempoMaximo <= 0)
        {
            IntPtr hndMBox = FindWindow(null, TituloMessageBox);
            if (hndMBox != IntPtr.Zero)
            {
                SendMessage(hndMBox, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                IntervaloTiempo.Dispose();
            }
        }
        else if (MostrarContador)
        {
            // Ha pasado un intervalo de 1 seg:
            if (hndLabel != IntPtr.Zero)
            {
                SetWindowText(hndLabel, TextoMessageBox +
                    "\r\nEste mensaje se cerrará dentro de " +
                    TiempoMaximo.ToString("00") + " segundos");
            }
            else
            {
                IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                if (hndMBox != IntPtr.Zero)
                {
                    // Ha encontrado el MessageBox, busca ahora el texto
                    hndLabel = FindWindowEx(hndMBox, IntPtr.Zero, "Static", null);
                    if (hndLabel != IntPtr.Zero)
                    {
                        // Ha encontrado el texto porque el MessageBox
                        // solo tiene un control "Static".
                        SetWindowText(hndLabel, TextoMessageBox +
                            "\r\nEste mensaje se cerrará dentro de " +
                            TiempoMaximo.ToString("00") + " segundos");
                    }
                }
            }
        }
    }
    const int WM_CLOSE = 0x0010;
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    [System.Runtime.InteropServices.DllImport("user32.dll",
        CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
        CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
        string lpszClass, string lpszWindow);
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
        CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    static extern bool SetWindowText(IntPtr hwnd, string lpString);
}