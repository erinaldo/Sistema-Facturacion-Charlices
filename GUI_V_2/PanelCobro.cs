using GUI_V_2.Reportes;
using Microsoft.Reporting.WinForms;
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
    public partial class PanelCobro : Form
    {
        public PanelCobro()
        {
            InitializeComponent();
            c_metodopago.SelectedIndex = 0;
            LlenarComboxMetodosPagos();

        }

        public void LlenarComboxMetodosPagos()
        {
            c_metodopago.DisplayMember = "nombre";
            c_metodopago.ValueMember = "id";
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Metodos_Pagos> metodos = db.Metodos_Pagos.Where(m => m.estado == true).OrderBy(m => m.nombre);
                    c_metodopago.DataSource = metodos.ToList();
                }
            }
            catch (Exception)
            {

            }

        }


        //Boton volver
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Salir ve cobro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes) { 
            this.Close();
            }
        }

        //metodo que aplica el borde al panel
        private void PanelCobro_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                           this.DisplayRectangle);
        }
        
        double monto_actual=0, pago=0;
        
        //Evento que hace el calculo del devuelto para el cliente.
        private void txt_pago_TextChanged(object sender, EventArgs e)
        {
            try
            {
              //  if (txt_pago.Text.Equals("")) txt_devuelto.Text = "0";            
                monto_actual = Convert.ToDouble(txt_monto.Text.Trim());
                pago = Convert.ToDouble(txt_pago.Text.Trim());
                txt_devuelto.Text = (pago - monto_actual).ToString();

            }
            catch (Exception error)
            {

            }

        }

        private void panel_dosmil_Click(object sender, EventArgs e)
        {
            Calcular(2000);
        }

        private void panel_mil_Click(object sender, EventArgs e)
        {
            Calcular(1000);
        }

        private void panel_quiniento_Click(object sender, EventArgs e)
        {
            Calcular(500);
        }

        private void panel_dociento_Click(object sender, EventArgs e)
        {  
            Calcular(200);
        }

        private void panel_cien_Click(object sender, EventArgs e)
        {
            Calcular(100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_pago.Text= "0";
            txt_devuelto.Text = "0";
        }

        private void PanelCobro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                btn_volver.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ImprimirFactura();
            this.Hide();
        }

        ReportDataSource rs = new ReportDataSource();
        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void PanelCobro_Load(object sender, EventArgs e)
        {

        }

        //Metodo que manda el monto seleccionado con el usuario
        private void Calcular(double mas){
            try
            {
                if (txt_pago.Text.Equals("")) txt_pago.Text = "0";
                    pago = Convert.ToDouble(txt_pago.Text.Trim());
                    txt_pago.Text = (pago + mas).ToString();

            }
            catch (Exception error)
            {


            }

        }

        private void ImprimirFactura()
        {
            try
            {
                FormReportesDatos Repor = new FormReportesDatos();
                VentasModoTouch ven = new VentasModoTouch();
                List<FacturaClass> lista = new List<FacturaClass>();
                lista.Clear();

                for (int p = 0; p < ven.dataGridViewProducto.Rows.Count; p++)
                {
                    lista.Add(new FacturaClass
                    {
                        CodPro = ven.dataGridViewProducto.Rows[p].Cells[0].Value.ToString(),
                        NomPro = ven.dataGridViewProducto.Rows[p].Cells[1].Value.ToString(),
                        PrePro = ven.dataGridViewProducto.Rows[p].Cells[2].Value.ToString(),
                        CanPro = ven.dataGridViewProducto.Rows[p].Cells[3].Value.ToString(),
                        SubTotal = ven.dataGridViewProducto.Rows[p].Cells[4].Value.ToString(),
                    });
                }
                lista.Add(new FacturaClass
                {
                    CodCli = ven.txt_codigo_cliente.Text.Trim(),
                    NomCli = ven.txt_nombre_cliente.Text.Trim(),
                    Comprobante = ven.txt_serie_comprobante.Text.Trim(),
                    NumOrden = ven.txt_numero_orden.Text.Trim(),
                    Vendedor = ven.comboBoxVendedores.SelectedValue.ToString(),
                    Descuento = ven.txt_total_desc.Text.Trim(),
                    NumFac = ven.txt_codigo_fac.Text.Trim(),
                    ITBIS = ven.txt_total_itbis.Text.Trim(),
                    Total = ven.txt_total_neto.Text.Trim(),
                    Nota = TxtNota.Text.Trim(),
                    TipoPago = c_metodopago.SelectedValue.ToString(),
                });

                rs.Name = "DataSetFactura";
                rs.Value = lista;
                Repor.reportViewer1.LocalReport.DataSources.Clear();
                Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.RepFact.rdlc";
                Repor.ShowDialog();
            }catch(Exception aaaa)
            {
                MessageBox.Show("Error al crear factura");
            }
        }
        
     
    }
}



public class FacturaClass
{
    public string NumFac { get; set; }
    public string Total { get; set; }
    public string CodPro { get; set; }
    public string NomPro { get; set; }
    public string PrePro { get; set; }
    public string CanPro { get; set; }
    public string SubTotal { get; set; }
    public string CodCli { get; set; }
    public string NomCli { get; set; }
    public string Comprobante { get; set; }
    public string NumOrden { get; set; }
    public string Vendedor { get; set; }
    public string Descuento { get; set; }
    public string ITBIS { get; set; }
    public string Nota { get; set; }
    public string TipoPago { get; set; }

}