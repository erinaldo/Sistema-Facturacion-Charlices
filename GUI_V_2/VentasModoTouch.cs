using GUI_V_2.Consultas;
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
    public partial class VentasModoTouch : Form
    {
        double itbisPro = 0;
        public VentasModoTouch()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Salir de ventas ?", "Confirme", MessageBoxButtons.YesNo);
            if(pregunta == DialogResult.Yes)
            {
                this.Dispose();
            }



        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha_hora.Text = DateTime.Now.ToString("hh:mm ") + DateTime.Now.ToShortDateString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PanelCobro obj = new PanelCobro();
            obj.txt_monto.Text = txt_total_neto.Text;
            obj.ShowDialog();
        }

        //Funciones rapidas con teclas
        private void VentasModoTouch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
            btn_volver.PerformClick();
            }

            if (e.KeyCode == Keys.F12)
            {
            btn_cobrar.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
            btn_verProductos.PerformClick();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsPro obj = new ConsPro();
            obj.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ConsCli obj = new ConsCli();
            obj.ShowDialog();
        }

        private void codigo_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string codigo = codigo_pro.Text.Trim();
                if (!codigo.Equals(""))
                {
                    ProductoByCodigo(codigo);
                }

            }
        }

        public void ProductoByCodigo(string codigoPro)
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    IQueryable<Productos> producto = DB.Productos.Where(p => p.codigo == codigoPro && p.estado == true);
                    var respProducto = producto.SingleOrDefault();

                    if (respProducto != null)
                    {
                        nombre_pro.Text = respProducto.nombre;
                        precio_pro.Text = respProducto.precio_normal.ToString();
                        CantidadDisponiblePro(codigoPro, int.Parse(respProducto.cantidad.ToString()));
                        itbisPro = respProducto.itbis;
                        cantidad_pro.Focus();
                    }
                    else
                    {
                        nombre_pro.Text = "";
                        precio_pro.Text = "";
                        disponible_pro.Text = "";
                        itbisPro = 0;
                        MessageBox.Show("no");
                    }
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }


        public void ClienteByCodigo(string codigoPro)
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    IQueryable<Clientes> cliente = DB.Clientes.Where(p => p.codigo == codigoPro && p.estado == true);
                    var respcliente = cliente.SingleOrDefault();

                    if (respcliente != null)
                    {
                        txt_nombre_cliente.Text = respcliente.nombre_completo;
                        
                    }
                    else
                    {
                        txt_nombre_cliente.Text = "";
                        MessageBox.Show("no");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        public void CantidadDisponiblePro(string codigo,int cantidad)
        {
            foreach (DataGridViewRow registsros in dataGridViewProducto.Rows)
            {
                if (registsros.Cells[0].Value.ToString() == codigo)
                {
                    cantidad -= int.Parse(registsros.Cells[3].Value.ToString());
                }


            }

            disponible_pro.Text = "Disponible: "  + cantidad.ToString();

        }

        private void codigo_pro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarProductoCarrito();
        }

        private void txt_total_bruto_TextChanged(object sender, EventArgs e)
        {

        }

        public void AgregarProductoCarrito()
        {
            if (nombre_pro.Text.Trim().Equals("Descripción de producto"))
            {
                MessageBox.Show("Por favor seleccionar un producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cantidad_pro.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor digite una cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int cantidadCliPro = int.Parse(cantidad_pro.Text.Trim());
            if (cantidadCliPro > int.Parse(disponible_pro.Text.Trim().Replace("Disponible:", "").ToString()))
            {
                MessageBox.Show($"La cantidad máxima disponible del producto {nombre_pro.Text.Trim()} es {disponible_pro.Text.Trim()} ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            bool proAddDataGrid = false;
            double subtotalFac = 0;
            double itbisFac = 0;

            foreach (DataGridViewRow registsros in dataGridViewProducto.Rows)
            {
                if (registsros.Cells[0].Value.ToString() == codigo_pro.Text.Trim())
                {
                    double precioPro = Double.Parse(registsros.Cells[2].Value.ToString());
                    int cantidadPro = int.Parse(registsros.Cells[3].Value.ToString());
                    cantidadPro += cantidadCliPro;
                    double subtotal = cantidadPro * precioPro;

                    registsros.Cells[3].Value = cantidadPro.ToString();
                    registsros.Cells[4].Value = subtotal.ToString();
                    double totalItbis = (itbisPro / 100) * subtotal;
                    registsros.Cells[5].Value = totalItbis.ToString();
                    registsros.Cells[6].Value = totalItbis + subtotal;
                    proAddDataGrid = true;
                }

                subtotalFac += Double.Parse(registsros.Cells[4].Value.ToString());
                itbisFac += Double.Parse(registsros.Cells[5].Value.ToString());

            }

            if (!proAddDataGrid)
            {
                int cantidadPro = int.Parse(cantidad_pro.Text.Trim());
                double precioPro = Double.Parse(precio_pro.Text.Trim());
                double subtotal = cantidadPro * precioPro;
                double totalItbis = (itbisPro / 100) * subtotal;
                double total = totalItbis + subtotal;
                dataGridViewProducto.Rows.Add(codigo_pro.Text.Trim(), nombre_pro.Text, precio_pro.Text.Trim(), cantidad_pro.Text.Trim(),
                                              subtotal, totalItbis, total);

                subtotalFac += subtotal;
                itbisFac += totalItbis;
            }

            txt_total_bruto.Text = subtotalFac.ToString();
            txt_total_itbis.Text = itbisFac.ToString();
            txt_total_neto.Text = (subtotalFac + itbisFac).ToString();

            codigo_pro.Text = "";
            nombre_pro.Text = "";
            cantidad_pro.Text = "1";
            precio_pro.Text = "";
            disponible_pro.Text = "";
            codigo_pro.Focus();

            /*txt_codigoPro.Text = "";
            txt_nombrePro.Text = "";
            txt_precioPro.Text = "";
            txt_cantidadPro.Text = "";
            txt_codigoPro.Focus();
            txtSubTotal.Text = totalFact.ToString();
            txtTotalItbis.Text = totalItbis.ToString();
            txt_totalFactura.Text = (totalFact + totalItbis).ToString();*/

        }

        private void cantidad_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AgregarProductoCarrito();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

          


            if (dataGridViewProducto.Rows.Count > 0)
            {
                string nombreProducto = dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].Cells[1].Value.ToString();
                DialogResult pregunta = MessageBox.Show($"¿Esta seguro que desea borrar el producto '{nombreProducto}' del carrito?", "Confirme", MessageBoxButtons.YesNo);
                if (pregunta != DialogResult.Yes)
                {
                    return;

                }

                double rItbis    = Double.Parse(txt_total_itbis.Text);
                double rSubTotal = Double.Parse(txt_total_bruto.Text);
                double rTotal = 0;

                rItbis -= Convert.ToDouble(dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].Cells[5].Value);
                rSubTotal -= Convert.ToDouble(dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].Cells[4].Value);
                dataGridViewProducto.Rows.RemoveAt(dataGridViewProducto.CurrentRow.Index);
                if (dataGridViewProducto.Rows.Count == 0)
                {
                    txt_total_bruto.Text = "0";
                    txt_total_neto.Text = "0";
                    txt_total_itbis.Text = "0";
                    return;
                }

                rTotal = rItbis + rSubTotal;

                txt_total_neto.Text = rTotal.ToString();
                txt_total_bruto.Text = rSubTotal.ToString();
                txt_total_itbis.Text = rItbis.ToString();

            }
            else
            {
                MessageBox.Show("Debe de tener por lo menos un producto para poder borrar.");
            }
        }

        private void errorTxtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string codigo = txt_codigo_cliente.Text.Trim();
                if (!codigo.Equals(""))
                {
                    ClienteByCodigo(codigo);
                }

            }
        }

        private void btn_cotizar_Click(object sender, EventArgs e)
        {

        }
    }


}
