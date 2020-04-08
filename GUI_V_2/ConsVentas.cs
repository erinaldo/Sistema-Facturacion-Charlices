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
    public partial class ConsVentas : FormBaseCons
    {
        public ConsVentas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            codigo.DataPropertyName = "codigo";
            fecha.DataPropertyName = "fecha";
            nombre_cliente.DataPropertyName = "nombre_cliente";
            vendedor.DataPropertyName = "vendedor";
            Cajero.DataPropertyName = "cajero";
            subtotal.DataPropertyName = "subtotal";
            itbis.DataPropertyName = "itbis_total";
            total.DataPropertyName = "total";
            estado.DataPropertyName = "estado";

            /*       id_cliente.DataPropertyName = "id_cliente";
                   descuento.DataPropertyName = "descuento";
                 
                   subtotal.DataPropertyName = "subtotal";
                   itbis_total.DataPropertyName = "itbis_total";
                   NFC_comprobante.DataPropertyName = "NFC_comprobante";
                   comprobamte_id.DataPropertyName = "comprobamte_id";
                   usuario_vendedor_id.DataPropertyName = "usuario_vendedor_id";
                   Met_Pago.DataPropertyName = "Met_Pago";
                   usuario_cajero_id.DataPropertyName = "usuario_cajero_id";
                   MessageBox.Show(DateTime.Today.ToShortDateString()); */
            fecha_inicio.Value = DateTime.Today;
            fecha_fin.Value = DateTime.Today;
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                DateTime d1,
                fecHoy = DateTime.Parse(fecha_inicio.Value.ToString("yyyy-MM-dd"));

                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var facturas = from fac in DB.Facturas
                                   join cli in DB.Clientes on fac.id_cliente
                              equals cli.id
                                   join usu in DB.Usuarios on fac.usuario_cajero_id
                     equals usu.id
                                   join user in DB.Usuarios on fac.usuario_vendedor_id
                                     equals user.id
                                   select new
                                   {
                                       codigo = fac.id,
                                       fac.fecha,
                                       nombre_cliente = cli.nombre_completo,
                                       vendedor = user.nombre_completo,
                                       cajero = usu.nombre_completo,
                                       fac.subtotal,
                                       fac.itbis_total,
                                       fac.total,
                                       estado = fac.estado == true ? "Anulada" : "Facturada"
                                   };
                     if (filtro.Text.Trim().Equals("")==false)
                     {
                         facturas = facturas.
                         Where(s => (s.fecha == fecHoy && (s.codigo.ToString().Contains(filtro.Text.Trim()) || s.vendedor.ToString().Contains(filtro.Text.Trim()) || s.nombre_cliente.ToString().Contains(filtro.Text.Trim()))));
                    }
                    else
                    {
                       facturas = facturas.
                       Where(s => (s.fecha == fecHoy));
                    }
                    
                    dataGridView1.DataSource = facturas.ToList();
                    dataGridView1.Columns["subtotal"].ValueType = typeof(System.Decimal);
                    dataGridView1.Columns["subtotal"].DefaultCellStyle.Format = "N";

                    dataGridView1.Columns["itbis"].ValueType = typeof(System.Decimal);
                    dataGridView1.Columns["itbis"].DefaultCellStyle.Format = "N";

                    dataGridView1.Columns["total"].ValueType = typeof(System.Decimal);
                    dataGridView1.Columns["total"].DefaultCellStyle.Format = "N";
                }
                nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";
                
                //total vendido al txt
                double total_ventas = 0;             
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total_ventas += Convert.ToDouble(row.Cells["total"].Value);
                }   
                txt_totalGrid.Text = string.Format("{0:0,0.0}", total_ventas);
                
            } catch(Exception aa)
            {
               //Error Charly
            }
        }
        

        //Botono anular venta
        private void btn_anular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count<1)
            {
                MessageBox.Show("Debe seleccionar la venta que desea anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Seguro que desea anular esta venta?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                try
                {

                    using (CRUD_MODEL DB = new CRUD_MODEL())
                    {
                        int id_Factura = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                        IQueryable<Detalles_Facturas> detalles = DB.Detalles_Facturas.Where(d => d.id_factura == id_Factura);


                        foreach (var resp_Detalles in detalles.ToList())
                        {
                            var producto = DB.Productos.FirstOrDefault(a => a.id == resp_Detalles.id_producto);
                            if (producto != null && producto.tipo_producto==1)
                            {
                                producto.cantidad = producto.cantidad + resp_Detalles.cantidad_producto;
                            }
                        }
                        IQueryable<Facturas> factura = DB.Facturas.Where(f => f.id == id_Factura);
                        var resp = factura.FirstOrDefault();
                        if (resp != null) resp.estado = true;
                        DB.SaveChanges();
                        LlenarDataGrid(filtro.Text.Trim());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al anular la factura, por favor intente de nuevo.");

                }


            }  
            
        }

        //Activar o desactivar por rango
        private void ActivarRango_CheckStateChanged(object sender, EventArgs e)
        {
            if (ActivarRango.Checked == true)
            {   
                fecha_fin.Enabled = true;
            }
            else
            {
                fecha_fin.Enabled = false;
            }
        }

        private void ConsVentas_Load(object sender, EventArgs e)
        {

        }

        //llenar resumen de venta
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                txt_total_neto.Text = string.Format("{0:0,0.0}", dataGridView1.SelectedRows[0].Cells[7].Value);
                txt_itbis.Text = string.Format("{0:0,0.0}", dataGridView1.SelectedRows[0].Cells[5].Value);
                txt_subtotal.Text = string.Format("{0:0,0.0}", dataGridView1.SelectedRows[0].Cells[6].Value);
                txt_NumFac.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                txt_total_neto.Text = "0.00";
                txt_itbis.Text = "0.00";
                txt_subtotal.Text = "0.00";
                txt_NumFac.Text = "0.";
            }
        }


        public string fecha_hoy = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;

        //Boton filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            //Busqueda por rango fecha
            if (ActivarRango.Checked)
            {
                DateTime d1, d2;
                d1 = DateTime.Parse(fecha_inicio.Value.ToString("yyyy-MM-dd"));
                d2 = DateTime.Parse(fecha_fin.Value.ToString("yyyy-MM-dd"));
                string f1 = d1.Year+"/"+d1.Month + "/" + d1.Day, f2 = d2.Year + "/" + d2.Month + "/" + d2.Day;
                
                if (DateTime.Parse(f1) > DateTime.Parse(f2)) 
                {
                    MessageBox.Show("La 'FECHA INICIO' no puede ser mayor a la de 'FECHA FIN'.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if ((DateTime.Parse(f2) > DateTime.Parse(fecha_hoy)) || (DateTime.Parse(f1) > DateTime.Parse(fecha_hoy)))
                {
                    MessageBox.Show("No puede usar fechas mayores a hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LlenarGridRangoFechas();
            }
            else
            {
                LlenarDataGrid(filtro.Text.Trim());
            }
        }



        //metodo para llenar por rango de fechas
        private void LlenarGridRangoFechas()
        {
            try
            {
                DateTime d1, d2;
                d1 = DateTime.Parse(fecha_inicio.Value.ToString("yyyy-MM-dd"));
                d2 = DateTime.Parse(fecha_fin.Value.ToString("yyyy-MM-dd"));

                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var facturas = from fac in DB.Facturas
                                   join cli in DB.Clientes on fac.id_cliente equals cli.id
                                   join usu in DB.Usuarios on fac.usuario_cajero_id equals usu.id
                                   join user in DB.Usuarios on fac.usuario_vendedor_id equals user.id
                                   select new
                                   {
                                       codigo = fac.id,
                                       fac.fecha,
                                       nombre_cliente = cli.nombre_completo,
                                       vendedor = user.nombre_completo,
                                       cajero = usu.nombre_completo,
                                       fac.subtotal,
                                       fac.itbis_total,
                                       fac.total,
                                       estado = fac.estado == true ? "Anulada" : "Facturada"
                                   };
                    if (filtro.Text.Trim().Equals("") == false)
                    {
                        facturas = facturas.
                        Where(s => (((s.fecha >= d1) && (s.fecha <= d2)) && (s.codigo.ToString().Contains(filtro.Text.Trim()) || s.vendedor.ToString().Contains(filtro.Text.Trim()) || s.nombre_cliente.ToString().Contains(filtro.Text.Trim()))));
                    }
                    else
                    {
                       facturas = facturas.
                       Where(s => ((s.fecha >= d1) && (s.fecha <= d2)));
                    }

                    dataGridView1.DataSource = facturas.ToList();
                    dataGridView1.Columns["subtotal"].ValueType = typeof(System.Decimal);
                    dataGridView1.Columns["subtotal"].DefaultCellStyle.Format = "N";

                    dataGridView1.Columns["itbis"].ValueType = typeof(System.Decimal);
                    dataGridView1.Columns["itbis"].DefaultCellStyle.Format = "N";

                    dataGridView1.Columns["total"].ValueType = typeof(System.Decimal);
                    dataGridView1.Columns["total"].DefaultCellStyle.Format = "N";
                }
                nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";

                //total vendido al txt
                double total_ventas = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total_ventas += Convert.ToDouble(row.Cells["total"].Value);
                }
                txt_totalGrid.Text = string.Format("{0:0,0.0}", total_ventas);

            }
            catch (Exception aa)
            {
                //Error Charly
            }
        }


        //Poner fila en rojo si esta anulada
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {  
                if (row.Cells["estado"].Value.ToString() == "Anulada")
                {

                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

            }

        }

        //Detalle de Venta
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe selecionar la factura que desea detallar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    int venco = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                    var detalle = from Fact in DB.Facturas
                                  join Deta_fact in DB.Detalles_Facturas on Fact.id equals Deta_fact.id_factura
                                  join pro in DB.Productos on Deta_fact.id_producto equals pro.id
                                  where Deta_fact.id_factura == venco
                                select new
                                {
                                    pro.codigo,
                                    pro.nombre,
                                    Deta_fact.cantidad_producto,
                                    Deta_fact.precio_producto,
                                    Deta_fact.itbis,
                                };
                  
                      DetalleVenta DV = new DetalleVenta();
                      foreach (var registro_orden in detalle.ToList())
                      {
                          int cantidad_pro = registro_orden.cantidad_producto;
                          double precio_pro = registro_orden.precio_producto;
                          double sub_total = cantidad_pro * precio_pro;
                          double totalItbis = registro_orden.itbis;
                          double total = sub_total + totalItbis;
                         DV.dataGridViewProducto.Rows.Add(registro_orden.codigo, registro_orden.nombre, registro_orden.precio_producto, registro_orden.cantidad_producto, sub_total, totalItbis, total);
                    }
                    DV.txt_numfact.Text = venco.ToString();
                    DV.txt_totalPro.Text = "TOTAL PRODUCTOS: " + detalle.ToList().Count.ToString();
                     DV.ShowDialog();

              }
            }
            catch (Exception s)
            {
             //  ERROR CHARLY
            }
        }


            


    }
}
