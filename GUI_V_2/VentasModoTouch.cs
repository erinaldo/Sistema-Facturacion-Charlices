using GUI_V_2.Consultas;
using GUI_V_2.Mensajes;
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
    public partial class VentasModoTouch : Form
    {
        public class ProductosOrden
        {
            public int Id_producto { get; set; }
            public int Cantidad { get; set; }
            public string Nombre_producto { get; set; }
        }

        List<ProductosOrden> ProOrdenList = new List<ProductosOrden>();

        double itbisPro = 0;
        bool cocinaPro = false;
        int id_cliente = 0;
        int tipo_cliente = -1;
        int id_producto = 0;

        public VentasModoTouch()
        {
            InitializeComponent();

            try
            {
                GenerarCodigoFac();
                LlenarComboxCombrobantes();
                LlenarComboxVendedores();
            }
            catch (Exception a)
            {
                //error
            }

        }


        public void LlenarComboxCombrobantes()
        {
            comboBoxCombrobante.DisplayMember = "tipo";
            comboBoxCombrobante.ValueMember = "id";
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Combrobantes> comprobante = db.Combrobantes.Where(c => c.estado == true && c.usados <= c.cantidad_limite).OrderBy(c => c.tipo);
                    comboBoxCombrobante.DataSource = comprobante.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        public void LlenarComboxVendedores()
        {
            comboBoxVendedores.DisplayMember = "nombre_completo";
            comboBoxVendedores.ValueMember = "id";
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Usuarios> usuario = db.Usuarios.Where(u => u.estado == true).OrderBy(u => u.nombre_completo);
                    comboBoxVendedores.DataSource = usuario.ToList();
                }
            }
            catch (Exception)
            {

            }

        }

        public void GenerarCodigoFac()
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    IQueryable<Facturas> factura = DB.Facturas.OrderByDescending(f => f.id);
                    var resp = factura.FirstOrDefault();
                    if (resp == null)
                    {
                        txt_codigo_fac.Text = "1";
                    }
                    else
                    {
                        txt_codigo_fac.Text = (resp.id + 1).ToString();
                    }

                }
            }
            catch (Exception a)
            {
                //error
            }
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Salir de ventas ?", "Confirme", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
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
            try
            {
                if (dataGridViewProducto.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar los productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_nombre_cliente.Text.Equals("Nombre cliente"))
                {
                    MessageBox.Show("Debe seleccionar un cliente disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                PanelCobro obj = new PanelCobro();
                obj.txt_monto.Text = txt_total_neto.Text;
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    int id_metodo_pago = int.Parse(obj.c_metodopago.SelectedValue.ToString());
                    CrearFactura(id_metodo_pago);
                }
            }
            catch (Exception a)
            {
                //error
            }
        }

        public void CrearFactura(int metodo_pago)
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    Facturas factura = new Facturas
                    {
                        id_cliente = id_cliente,
                        subtotal = Double.Parse(txt_total_bruto.Text.Trim()),
                        itbis_total = Double.Parse(txt_total_itbis.Text.Trim()),
                        fecha = DateTime.Today,
                        descuento = Double.Parse(txt_total_desc.Text.Trim()),
                        total = Double.Parse(txt_total_bruto.Text.Trim()),
                        usuario_vendedor_id = int.Parse(comboBoxVendedores.SelectedValue.ToString()),
                        usuario_cajero_id = int.Parse(comboBoxVendedores.SelectedValue.ToString()),
                        NFC_comprobante = txt_serie_comprobante.Text,
                        metodo_pago_id = metodo_pago,
                        comprobante_id = int.Parse(comboBoxCombrobante.SelectedValue.ToString())
                    };

                    foreach (DataGridViewRow registsros in dataGridViewProducto.Rows)
                    {
                        string codigoPro = registsros.Cells[0].Value.ToString();
                        var producto = DB.Productos.FirstOrDefault(a => a.codigo == codigoPro);
                        if (producto != null)
                        {
                            double precioProVenta = Double.Parse(registsros.Cells[2].Value.ToString());
                            int cantidaProVendida = int.Parse(registsros.Cells[3].Value.ToString());
                            double itbisProVenta = Double.Parse(registsros.Cells[5].Value.ToString());
                            if (producto.tipo_producto == 1) producto.cantidad -= cantidaProVendida;


                            if(Reservar.Text.Equals("Reservar Orden")){
                                bool cocinarPro = bool.Parse(registsros.Cells[8].Value.ToString());
                                if (cocinarPro)
                                {
                                    string nombreProducto = registsros.Cells[1].Value.ToString();

                                    ProOrdenList.Add(new ProductosOrden()
                                    {
                                        Id_producto = producto.id,
                                        Cantidad = cantidaProVendida,
                                        Nombre_producto = nombreProducto
                                    });
                                }
                            }


                            Detalles_Facturas detalles_fac = new Detalles_Facturas
                            {
                                id_producto = producto.id,
                                cantidad_producto = cantidaProVendida,
                                precio_producto = precioProVenta,
                                itbis = itbisProVenta
                            };
                            factura.Detalles_Facturas.Add(detalles_fac);
                        }
                    }
                    DB.Facturas.Add(factura);

                    if (Reservar.Text.Equals("Modificar Orden"))
                    {
                        int codigo_orden = int.Parse(txt_numero_orden.Text.Trim());
                        IQueryable<Ordenes_Reservadas> ORDEN = DB.Ordenes_Reservadas.Where(o => o.id == codigo_orden);
                        var resORDEN = ORDEN.FirstOrDefault();
                        if (resORDEN != null)
                        {
                            resORDEN.estado = true;
                        }

                    }
                    if (txt_serie_comprobante.Text.Equals("SIN COMPROBANTE") == false)
                    {
                        IQueryable<Combrobantes> combrobante = DB.Combrobantes.Where(c => c.id == factura.comprobante_id);
                        var resp = combrobante.FirstOrDefault();
                        if (resp != null)
                        {
                            resp.usados = resp.usados + 1;
                        }

                    }

                    DB.SaveChanges();
                    GetComprobanteSeleccionado();
                    if (Utilidades.ConFact == 1)
                    {
                        ImprimirTicketVenta();
                    }


                    if (Reservar.Text.Equals("Reservar Orden"))
                    {
                        ImprimirTicketReserva(true);
                        ProOrdenList.Clear();
                    }

                    LimpiarCampo();
                    MessageBox.Show("La factura se creo correctamente.");
                    GenerarCodigoFac();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        public void LimpiarCampo()
        {
            Utilidades.LimpiarControles(this);
            txt_nombre_cliente.Text = "Nombre cliente";
            txt_total_bruto.Text = "0.00";
            txt_total_itbis.Text = "0.00";
            txt_total_desc.Text = "0.00";
            txt_total_neto.Text = "0.00";
            Reservar.Text = "Reservar Orden";
            ProOrdenList.Clear();
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
            try
            {
                ConsPro obj = new ConsPro();
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    string codigo_pro = obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    string nombre_pro = obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    decimal precio_pro = 0;

                    int itbis_pro = int.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[7].Value.ToString());

                    int cantidad_pro = int.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[8].Value.ToString());

                    string tipo_pro = obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[10].Value.ToString();

                    id_producto = int.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[12].Value.ToString());
                    cocinaPro = bool.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[13].Value.ToString());

                    if (tipo_cliente == 1)
                    {
                        precio_pro = Decimal.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[3].Value.ToString());
                    }
                    else if (tipo_cliente == 2)
                    {
                        precio_pro = Decimal.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[5].Value.ToString());
                    }
                    else
                    {
                        precio_pro = Decimal.Parse(obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[4].Value.ToString());
                    }

                    SetCampoByProducto(nombre_pro, precio_pro, codigo_pro, cantidad_pro, itbis_pro, tipo_pro == "Inventario" ? 1 : 2);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(e.ToString());
                //error
            }
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            try
            {
                ConsCli obj = new ConsCli();
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    txt_codigo_cliente.Text = obj.dataGridClientes.Rows[obj.dataGridClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    txt_codigo_cliente.Focus();
                    SendKeys.Send("{ENTER}");
                    string codigo = obj.dataGridClientes.Rows[obj.dataGridClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    string nombre = obj.dataGridClientes.Rows[obj.dataGridClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    int id = int.Parse(obj.dataGridClientes.Rows[obj.dataGridClientes.CurrentCell.RowIndex].Cells[8].Value.ToString());
                    string tipoCliente = obj.dataGridClientes.Rows[obj.dataGridClientes.CurrentCell.RowIndex].Cells[5].Value.ToString();
                    int tipoCl = tipoCliente == "NORMAL" ? 1 : tipoCliente == "EMPRESA" ? 2 : 3;
                }
            }
            catch (Exception a)
            {
                //error
            }
        }


        public void SetCampoByCliente(string nombre, string codigo, int id, int tipoCliente)
        {
            txt_codigo_cliente.Text = codigo;
            txt_nombre_cliente.Text = nombre;
            id_cliente = id;
            tipo_cliente = tipoCliente;
            codigo_pro.Focus();

        }


        private void codigo_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception s)
            {
                //error
            }
        }

        public void ProductoByCodigo(string codigoPro)
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var producto = DB.Productos.Where(p => p.codigo == codigoPro && p.estado == true).Join(DB.Categorias,p=>p.id_categoria,cat=>cat.id,(p,cat)=>new {
                        p.id,
                        p.nombre,
                        precioProducto = tipo_cliente == 1 ? p.precio_normal : tipo_cliente == 2 ? p.precio_empresa : p.precio_empleado,
                        p.cantidad,
                        p.itbis,
                        p.tipo_producto,
                        cat.cocina
                    });
                    var respProducto = producto.FirstOrDefault();

                    if (respProducto != null)
                    {
                        id_producto = respProducto.id;
                        cocinaPro = respProducto.cocina;
                        decimal precioProducto = respProducto.precioProducto;
                        SetCampoByProducto(respProducto.nombre, precioProducto, codigoPro, respProducto.cantidad, respProducto.itbis, respProducto.tipo_producto);
                    }
                    else
                    {
                        nombre_pro.Text = "Descripción de producto";
                        precio_pro.Text = "";
                        disponible_pro.Text = "";
                        itbisPro = 0;
                        cocinaPro = false;
                        id_producto = 0;
                        MessageBox.Show("No existe un producto con dicho código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }

            catch (Exception ex)
            {
                //    MessageBox.Show(ex.ToString());
            }
        }

        public void SetCampoByProducto(string nombre, decimal precio, string codigo, int cantidad, int itbis, int tipo_producto)
        {
            try
            {
                codigo_pro.Text = codigo;
                nombre_pro.Text = nombre;
                precio_pro.Text = precio.ToString();
                if (tipo_producto == 1) CantidadDisponiblePro(codigo, int.Parse(cantidad.ToString()));
                else
                {
                    total_producto.Text = "TOTAL : Sin límite";
                    disponible_pro.Text = "DISPONIBLE : Sin límite";
                }

                itbisPro = itbis;
                cantidad_pro.Focus();
            }
            catch (Exception ccv)
            {
                //error
            }
        }

        public void ClienteByCodigo(string codigo_cliente)
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    IQueryable<Clientes> cliente = DB.Clientes.Where(p => p.codigo == codigo_cliente && p.estado == true);
                    var respcliente = cliente.SingleOrDefault();

                    if (respcliente != null)
                    if (respcliente != null)
                    {
                        SetCampoByCliente(respcliente.nombre_completo, codigo_cliente, respcliente.id, respcliente.tipo_cliente);
                    }
                    else
                    {
                        id_cliente = 0;
                        tipo_cliente = 0;
                        txt_nombre_cliente.Text = "Nombre cliente";
                        MessageBox.Show("No existe un cliente con dicho código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        public void CantidadDisponiblePro(string codigo, int cantidad)
        {
            try
            {
                total_producto.Text = "TOTAL :" + cantidad.ToString();

                int id_orden = 0;
                if (txt_numero_orden.Text.Trim().Equals("") == false)
                {
                    id_orden = int.Parse(txt_numero_orden.Text.Trim());
                }

                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var ordenes = from detalles in DB.Detalles_Ordenes
                                  join orden in DB.Ordenes_Reservadas on detalles.orden_id
                       equals orden.id
                                  where (orden.estado == false && detalles.id_producto == id_producto && (id_orden == 0 || detalles.orden_id != id_orden))
                                  group detalles by detalles.cantidad_producto into total
                                  let totalOrdenProducto = total.Sum(t => t.cantidad_producto)
                                  select new
                                  {
                                      totalOrdenProducto
                                  };

                    var resultado = ordenes.FirstOrDefault();
                    int cantidad_ordenada = 0;
                    if (resultado != null) cantidad_ordenada = resultado.totalOrdenProducto;

                    int cantidad_addCarrito = 0;
                    foreach (DataGridViewRow registsros in dataGridViewProducto.Rows)
                    {
                        if (registsros.Cells[0].Value.ToString() == codigo)
                        {
                            cantidad_addCarrito += int.Parse(registsros.Cells[3].Value.ToString());
                        }

                    }

                    int sub_cantidadDisponible = cantidad - cantidad_addCarrito;
                    cantidad_ordenada += (cantidad - sub_cantidadDisponible);
                    int totan_disponible = cantidad - cantidad_ordenada;
                    cantidad_orden_producto.Text = "RESERVADAS : " + cantidad_ordenada;
                    disponible_pro.Text = "DISPONIBLE: " + totan_disponible.ToString();
                }


            }
            catch (Exception cc)
            {
                //error
            }
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
            try
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
                if (!disponible_pro.Text.Trim().Contains("Sin límite") && cantidadCliPro > int.Parse(disponible_pro.Text.Trim().Replace("DISPONIBLE:", "").ToString()))
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
                                                  subtotal, totalItbis, total, id_producto, cocinaPro);

                    subtotalFac += subtotal;
                    itbisFac += totalItbis;
                }

                txt_total_bruto.Text = subtotalFac.ToString("N2");
                txt_total_itbis.Text = itbisFac.ToString("N2");
                txt_total_neto.Text = (subtotalFac + itbisFac).ToString("N2");
                calcularDesc();

                codigo_pro.Text = "";
                nombre_pro.Text = "Descripción de producto";
                cantidad_pro.Text = "1";
                precio_pro.Text = "";
                disponible_pro.Text = "DISPONIBLE";
                total_producto.Text = "TOTAL";
                cantidad_orden_producto.Text = "RESERVADAS";
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
            catch (Exception ccv)
            {
                MessageBox.Show(ccv.ToString());
            }
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
            try
            {

                if (dataGridViewProducto.Rows.Count > 0)
                {
                    string nombreProducto = dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].Cells[1].Value.ToString();
                    DialogResult pregunta = MessageBox.Show($"¿Esta seguro que desea borrar el producto '{nombreProducto}' del carrito?", "Confirme", MessageBoxButtons.YesNo);
                    if (pregunta != DialogResult.Yes)
                    {
                        return;

                    }

                    if (Reservar.Text.Equals("Modificar Orden"))
                    {
                        try
                        {
                            using (CRUD_MODEL DB = new CRUD_MODEL())
                            {
                                int id_orden = int.Parse(txt_numero_orden.Text);
                                int id_productoOrden = int.Parse(dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].Cells[7].Value.ToString());

                                var detalles_orden = DB.Detalles_Ordenes.FirstOrDefault(a => a.orden_id == id_orden && a.id_producto == id_productoOrden);


                                if (detalles_orden != null)
                                {
                                    ProOrdenList.Remove(ProOrdenList.Find(p => p.Id_producto == id_productoOrden));
                                    DB.Detalles_Ordenes.Remove(detalles_orden);
                                    DB.SaveChanges();
                                }
                            }

                        }
                        catch (Exception)
                        {

                            return;
                            //Guardar Error
                        }

                    }

                    double rItbis = Double.Parse(txt_total_itbis.Text);
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
                        txt_descuento.Text = "0";
                        txt_total_desc.Text = "0";
                        return;
                    }

                    rTotal = rItbis + rSubTotal;

                    txt_total_neto.Text = rTotal.ToString("N2");
                    txt_total_bruto.Text = rSubTotal.ToString("N2");
                    txt_total_itbis.Text = rItbis.ToString("N2");
                    calcularDesc();
                }
                else
                {
                    MessageBox.Show("Debe de tener por lo menos un producto para poder borrar.");
                }
            }
            catch (Exception vv)
            {
                //Error
            }
        }

        private void errorTxtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception cc)
            {
                //error
            }
        }

        private void btn_cotizar_Click(object sender, EventArgs e)
        {

        }

        private void errorTxtBox12_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                calcularDesc();
            }


        }

        public void calcularDesc()
        {
            try
            {
                double descuento = Double.Parse(txt_descuento.Text.Trim());
                if (descuento >= 0 && descuento <= 100)
                {
                    double totalSinDesc = Double.Parse(txt_total_bruto.Text) + Double.Parse(txt_total_itbis.Text);
                    double desc = Convert.ToDouble(txt_descuento.Text);
                    double descAplicado = (totalSinDesc * (desc / 100));
                    double totalConDesc = totalSinDesc - descAplicado;
                    txt_total_neto.Text = totalConDesc.ToString("N2");
                    txt_total_desc.Text = descAplicado.ToString("N2");
                }
            }
            catch (Exception axx)
            {
                //error
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxCombrobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetComprobanteSeleccionado();
        }

        public void GetComprobanteSeleccionado()
        {
            try
            {
                int indexSeleccionado = comboBoxCombrobante.SelectedIndex;
                if (indexSeleccionado < 0) return;
                if (comboBoxCombrobante.SelectedText.Equals("SIN COMPROBANTE"))
                {
                    txt_serie_comprobante.Text = "SIN COMPROBANTE";
                    return;
                }
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {

                    int idCombrobante = int.Parse(comboBoxCombrobante.SelectedValue.ToString());
                    IQueryable<Combrobantes> combrobante = DB.Combrobantes.Where(c => c.id == idCombrobante);
                    var resComprobante = combrobante.FirstOrDefault();
                    if (resComprobante != null)
                    {
                        int usados = int.Parse(resComprobante.usados.ToString()) + 1;
                        String usadost = Convert.ToString(usados).PadLeft(8, '0');

                        txt_serie_comprobante.Text = resComprobante.serie + "" + usadost;
                    }


                }

            }
            catch (Exception)
            {

            }
        }

        private void txt_nombre_cliente_TextChanged(object sender, EventArgs e)
        {

        }
        String mesero = "";
        private void Reservar_Click(object sender, EventArgs e)
        {

            if (txt_numero_orden.Text.Trim().Equals("") && Reservar.Text.Equals("Modificar Orden"))
            {
                MessageBox.Show("Ingrese un número de orden o consulte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else if (dataGridViewProducto.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos para procesar la orden.");
                return;
            }

            mesero = comboBoxVendedores.SelectedItem.ToString();

            NotaReserva notaReserva = new NotaReserva();

            if (notaReserva.ShowDialog() == DialogResult.OK)
            {
                Utilidades.NotaVenta = notaReserva.txt_nota.Text.ToString();
            }
            else
            {
                Utilidades.NotaVenta = "";
            }

            if (Reservar.Text.Equals("Reservar Orden")) CrearReservaOrden();
            else ModificarReservaOrden();
            

            ImprimirTicketReserva();
            
            if (Reservar.Text.Equals("Reservar Orden")) LimpiarCampo();
            ProOrdenList.Clear();
        }

        public void ModificarReservaOrden()
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    int orden_id = int.Parse(txt_numero_orden.Text.Trim());
                    var orden = DB.Ordenes_Reservadas.FirstOrDefault(a => a.id == orden_id);
                    if (orden != null)
                    {
                        orden.id_cliente = id_cliente;
                        orden.fecha = DateTime.Today;
                        orden.id_mesera = int.Parse(comboBoxVendedores.SelectedValue.ToString());
                    }



                    foreach (DataGridViewRow registsros in dataGridViewProducto.Rows)
                    {
                        int idPro = int.Parse(registsros.Cells[7].Value.ToString());

                        var detalle_orden = DB.Detalles_Ordenes.FirstOrDefault(a => a.orden_id == orden_id && a.id_producto == idPro);

                        double precioProVenta = Double.Parse(registsros.Cells[2].Value.ToString());
                        int cantidaProVendida = int.Parse(registsros.Cells[3].Value.ToString());
                        double itbisProVenta = Double.Parse(registsros.Cells[5].Value.ToString());

                        if (detalle_orden != null)
                        {
                            bool cocina = bool.Parse(registsros.Cells[8].Value.ToString());
                            if (cocina)
                            {
                                int indexPro = ProOrdenList.FindIndex(p => p.Id_producto == idPro);
                                if (indexPro == -1)
                                {
                                    string nombreProducto = registsros.Cells[1].Value.ToString();

                                    ProOrdenList.Add(new ProductosOrden()
                                    {
                                        Id_producto = idPro,
                                        Cantidad = Math.Abs(detalle_orden.cantidad_producto - cantidaProVendida),
                                        Nombre_producto = nombreProducto
                                    });
                                }
                                else
                                {
                                    ProOrdenList[indexPro].Cantidad = Math.Abs(cantidaProVendida - ProOrdenList[indexPro].Cantidad);
                                }
                            }
                            

                            detalle_orden.cantidad_producto = cantidaProVendida;
                            detalle_orden.precio_producto = precioProVenta;
                            detalle_orden.itbis = itbisProVenta;


                        }
                        else
                        {
                            Detalles_Ordenes detalles_orden = new Detalles_Ordenes
                            {
                                orden_id = orden_id,
                                id_producto = idPro,
                                cantidad_producto = cantidaProVendida,
                                precio_producto = precioProVenta,
                                itbis = itbisProVenta
                            };

                            bool cocina = bool.Parse(registsros.Cells[8].Value.ToString());
                            if (cocina)
                            {
                                string nombreProducto = registsros.Cells[1].Value.ToString();

                                ProOrdenList.Add(new ProductosOrden()
                                {
                                    Id_producto = idPro,
                                    Cantidad = cantidaProVendida,
                                    Nombre_producto = nombreProducto
                                });
                            }
                               

                            DB.Detalles_Ordenes.Add(detalles_orden);
                        }

                    }
                    DB.SaveChanges();
                    MessageBox.Show("La orden se modifico correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        public void CrearReservaOrden()
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    Ordenes_Reservadas orden = new Ordenes_Reservadas
                    {
                        id_cliente = id_cliente,
                        fecha = DateTime.Today,
                        id_mesera = int.Parse(comboBoxVendedores.SelectedValue.ToString())
                    };


                    foreach (DataGridViewRow registsros in dataGridViewProducto.Rows)
                    {
                        string codigoPro = registsros.Cells[0].Value.ToString();
                        var producto = DB.Productos.FirstOrDefault(a => a.codigo == codigoPro);
                        if (producto != null)
                        {
                            double precioProVenta = Double.Parse(registsros.Cells[2].Value.ToString());
                            int cantidaProVendida = int.Parse(registsros.Cells[3].Value.ToString());
                            double itbisProVenta = Double.Parse(registsros.Cells[5].Value.ToString());
                            if (producto.tipo_producto == 1) producto.cantidad -= cantidaProVendida;

                            Detalles_Ordenes detalles_orden = new Detalles_Ordenes
                            {
                                id_producto = producto.id,
                                cantidad_producto = cantidaProVendida,
                                precio_producto = precioProVenta,
                                itbis = itbisProVenta
                            };

                            bool cocina = bool.Parse(registsros.Cells[8].Value.ToString());
                            if (cocina)
                            {
                                string nombrePro = registsros.Cells[1].Value.ToString();

                                ProOrdenList.Add(new ProductosOrden()
                                {
                                    Id_producto = producto.id,
                                    Cantidad = cantidaProVendida,
                                    Nombre_producto = nombrePro
                                });
                            }
                                
                            orden.Detalles_Ordenes.Add(detalles_orden);
                        }

                    }
                    DB.Ordenes_Reservadas.Add(orden);
                    DB.SaveChanges();
                    MessageBox.Show("La orden se creo correctamente.");
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        private void txt_numero_orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    int codigo = int.Parse(txt_numero_orden.Text.Trim());
                    if (!codigo.Equals(""))
                    {
                        OrdenByCodigo(codigo);
                    }
                }
            }
            catch (Exception aee)
            {
                //error
            }
        }

        public void OrdenByCodigo(int codigo_orden)
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var orden = from ord in DB.Ordenes_Reservadas
                                join Deta_orden in DB.Detalles_Ordenes on ord.id
                     equals Deta_orden.orden_id
                                join pro in DB.Productos on Deta_orden.id_producto equals pro.id
                                join cli in DB.Clientes on ord.id_cliente equals cli.id
                                join cat in DB.Categorias on pro.id_categoria equals cat.id
                                where ord.id == codigo_orden
                                select new
                                {
                                    ord.id_mesera,
                                    ord.estado,
                                    ord.id_cliente,
                                    cli.tipo_cliente,
                                    cliente_codigo = cli.codigo,
                                    cli.nombre_completo,
                                    pro.id,
                                    pro.nombre,
                                    cat.cocina,
                                    pro.codigo,
                                    Deta_orden.cantidad_producto,
                                    Deta_orden.precio_producto,
                                    Deta_orden.itbis,
                                };

                    if (orden.ToList().LongCount() > 0)
                    {
                        dataGridViewProducto.Rows.Clear();
                        double total_Sub = 0;
                        double total_itbis = 0;
                        foreach (var registro_orden in orden.ToList())
                        {
                            if (registro_orden.estado)
                            {
                                MessageBox.Show("La orden ya había sido facturada, consulte en ventas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            txt_codigo_cliente.Text = registro_orden.cliente_codigo;
                            txt_nombre_cliente.Text = registro_orden.nombre_completo;
                            id_cliente = registro_orden.id_cliente;
                            tipo_cliente = registro_orden.tipo_cliente;
                            comboBoxVendedores.SelectedValue = registro_orden.id_mesera;
                            int cantidad_pro = registro_orden.cantidad_producto;
                            double precio_pro = registro_orden.precio_producto;
                            double sub_total = cantidad_pro * precio_pro;
                            double totalItbis = registro_orden.itbis;
                            double total = sub_total + totalItbis;
                            total_Sub += sub_total;
                            total_itbis += totalItbis;
                            dataGridViewProducto.Rows.Add(registro_orden.codigo, registro_orden.nombre, registro_orden.precio_producto, registro_orden.cantidad_producto, sub_total.ToString(), totalItbis.ToString(), total.ToString(), registro_orden.id,registro_orden.cocina);

                            if (registro_orden.cocina)
                            {
                                ProOrdenList.Add(new ProductosOrden()
                                {
                                    Id_producto = registro_orden.id,
                                    Cantidad = registro_orden.cantidad_producto,
                                    Nombre_producto = registro_orden.nombre
                                });
                            }
                        }
                        if (total_Sub > 0)
                        {
                            Reservar.Text = "Modificar Orden";
                            codigo_pro.Focus();
                        }
                        txt_total_bruto.Text = total_Sub.ToString("N2");
                        txt_total_itbis.Text = total_itbis.ToString("N2");
                        txt_total_neto.Text = (total_itbis + total_Sub).ToString("N2");
                        txt_total_desc.Text = "0.0";
                    }
                    else
                    {
                        nombre_pro.Text = "Descripción de producto";
                        precio_pro.Text = "";
                        disponible_pro.Text = "";
                        itbisPro = 0;
                        Reservar.Text = "Reservar Orden";
                        MessageBox.Show("No existe una orden con ese código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ProOrdenList.Clear();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        PanelCobro PaCobro = new PanelCobro();
        //Metodo para crear Factura 



        ReportDataSource rs = new ReportDataSource();


        //Impresion de factura con Repoviewer desactivado.
        /* public void ImprimirFactura()
               {
                   try
                   {
                       FormReportesDatos Repor = new FormReportesDatos();
                       List<FacturaClass> lista = new List<FacturaClass>();
                       lista.Clear();
                       for (int p = 0; p < dataGridViewProducto.Rows.Count; p++)
                       {
                           lista.Add(new FacturaClass
                           {
                               CodPro = dataGridViewProducto.Rows[p].Cells[0].Value.ToString(),
                               NomPro = dataGridViewProducto.Rows[p].Cells[1].Value.ToString(),
                               PrePro = dataGridViewProducto.Rows[p].Cells[2].Value.ToString(),
                               CanPro = dataGridViewProducto.Rows[p].Cells[3].Value.ToString(),
                               SubTotal = dataGridViewProducto.Rows[p].Cells[4].Value.ToString(),
                               CodCli = txt_codigo_cliente.Text.Trim(),
                               NomCli = txt_nombre_cliente.Text.Trim(),
                               Comprobante = txt_serie_comprobante.Text.Trim(),
                               NumOrden = txt_numero_orden.Text.Trim(),
                               Vendedor = comboBoxVendedores.SelectedItem.ToString(),
                               Descuento = txt_total_desc.Text.Trim(),
                               NumFac = txt_codigo_fac.Text.Trim(),
                               ITBIS = txt_total_itbis.Text.Trim(),
                               Total = txt_total_neto.Text.Trim(),
                               Nota = Utilidades.NotaVenta.ToString(),
                               TipoPago = "Efectivo",
                           });
                       }

                       rs.Name = "DataSetTicketVenta";
                       rs.Value = lista;
                       Repor.reportViewer1.LocalReport.DataSources.Clear();
                       Repor.reportViewer1.LocalReport.DataSources.Add(rs);
                       Repor.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_V_2.Reportes.TicketVenta.rdlc";
                       Repor.ShowDialog();
                   }
                   catch (Exception aaaa)
                   {
                       //MessageBox.Show("Error al crear factura");
                   }
               }
               */



            //Ticket de venta
        public void ImprimirTicketVenta()
        {
            FormConGen empresa = new FormConGen();
            //Creamos una instancia d ela clase CrearTicket
            Factura ticket = new Factura();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(empresa.NomEmpresa.Text);
            // ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda(empresa.DirEmpresa.Text);
            ticket.TextoIzquierda(empresa.NumEmpresa.Text);
            ticket.TextoIzquierda("RNC: " + empresa.RncEmpresa.Text.Trim());
            // ticket.TextoIzquierda("R.N.C: " + empresa.RncEmpresa.Text); //RNC EMPRESA
            // ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("# ORDEN: FAC000" + txt_codigo_fac.Text.Trim());
            ticket.TextoIzquierda("FACTURA: " + txt_codigo_fac.Text.Trim());
            ticket.TextoIzquierda("NFC: " + txt_serie_comprobante.Text.Trim());
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoExtremos("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy"), " " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Cliente: " + txt_codigo_cliente.Text.Trim() + " - " + txt_nombre_cliente.Text.Trim());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO 1, CANT 3, PRECIO 2, IMPORTE 4
            ticket.lineasAsteriscos();
            //Agregando articulos al data GridView
            for (int p = 0; p < dataGridViewProducto.Rows.Count; p++)
            {
                ticket.AgregaArticulo(dataGridViewProducto.Rows[p].Cells[1].Value.ToString(),
                   dataGridViewProducto.Rows[p].Cells[3].Value.ToString(),
                   dataGridViewProducto.Rows[p].Cells[2].Value.ToString(),
                   dataGridViewProducto.Rows[p].Cells[4].Value.ToString());
            }

            ticket.lineasIgual();
            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         TOTAL........RD$", txt_total_neto.Text.Trim());
            ticket.AgregarTotales("         ITBIS........RD$", txt_total_itbis.Text.Trim());//La M indica que es un decimal en C#
            ticket.AgregarTotales("         DESCUENTOS...RD$", txt_total_desc.Text.Trim());
            ticket.TextoIzquierda("");

            //Texto final del Ticket.
            ticket.TextoIzquierda("NOTA: " + Utilidades.NotaVenta);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR VISITA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("EPSON TM-T88IV ReStick");//Nombre de la impresora ticketera           
        }


        //Ticket de Orden - Para cocina
        public void ImprimirTicketReserva(bool venta_Reservada = false)
        {
            //Usar Lista ProOrdenList para imprimir el tickets
            FormConGen empresa = new FormConGen();
            //Creamos una instancia d ela clase CrearTicket
            Factura ticket = new Factura();

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("TICKET PARA COCINA");
            ticket.lineasAsteriscos();
            if (venta_Reservada)
            {
                ticket.TextoIzquierda("# ORDEN: FAC000" + txt_codigo_fac.Text.Trim());
            }
            else
            {
                ticket.TextoIzquierda("# ORDEN: " + txt_numero_orden.Text.Trim());
            }
            ticket.TextoIzquierda("");

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy"), " " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Productos para cocina
            ticket.EncabezadoCocina();//NOMBRE DEL ARTICULO 1, CANT 3, PRECIO 2, IMPORTE 4
            ticket.lineasAsteriscos();

            //Agregando productos
            for (int p = 0; p < ProOrdenList.Count; p++)
            {
                if (ProOrdenList[p].Cantidad == 0) continue;

                ticket.AgregaArticulo(
                        ProOrdenList[p].Nombre_producto.ToString(), //Nombre articulo
                        ProOrdenList[p].Cantidad.ToString(), //Cantidad
                        "", //Precio no requerido
                        ""); //Importe no requerido
            }

            ticket.lineasIgual();

            //Texto final del Ticket.

            ticket.TextoIzquierda("Mesera/o: " + mesero);
            ticket.TextoIzquierda("Nota: " + Utilidades.NotaVenta);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();
            ticket.ImprimirTicket("EPSON TM-T88IV ReStick");//Nombre de la impresora ticketera

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducto.Rows.Count > 0)
            {
                DialogResult pregunta = MessageBox.Show($"¿Esta seguro que desea borrar todos los productos ?", "Confirme", MessageBoxButtons.YesNo);
                if (pregunta != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    LimpiarCampo();
                }

            }
        }


        //Boton Consultar Ordenes 
        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                ConsResOrden obj = new ConsResOrden();
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    txt_numero_orden.Text = obj.dataGridOrdenes.Rows[obj.dataGridOrdenes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    txt_numero_orden.Focus();
                    SendKeys.Send("{ENTER}");
                }
            }catch(Exception aaaa)
            {

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
 