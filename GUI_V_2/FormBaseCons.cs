using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace GUI_V_2
{
    public partial class FormBaseCons : Form
    {
        public FormBaseCons()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBaseCons_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                        this.DisplayRectangle);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {


        }

        //Metodo para generar los reportes
      public void ImprimirTabla(DataGridView tabla, String NomRep)
        {
            //Esto es para tomar los atributos puestos en condifuracion
            FormConGen ConGen = new FormConGen();
            String Empresa = ConGen.NomEmpresa.Text.Trim(); 

            int alto = tabla.Size.Height;
            int ancho = tabla.Size.Width;
            tabla.Width = 210;
            tabla.Height = 297;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = " " + Empresa + "";
            printer.SubTitle = NomRep   ;
            printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.TableAlignment = DGVPrinter.Alignment.Right;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = DateTime.Now.ToLongTimeString()+ " - "+DateTime.Now.ToLongDateString();
            printer.FooterColor = Color.Black;
            printer.SubTitleSpacing = 15;
            printer.FooterSpacing = 15;
            printer.SubTitleColor = Color.Gray;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.printDocument.DocumentName = NomRep+" - "+ DateTime.Now.ToShortDateString();
            printer.PrintDataGridView(tabla);
            tabla.Width = ancho;
            tabla.Height = alto;
        }
    }
}
