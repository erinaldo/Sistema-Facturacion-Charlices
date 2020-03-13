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
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                var facturas = from fac in DB.Facturas  join cli in DB.Clientes on fac.id_cliente
                                                   equals cli.id join usu in DB.Usuarios on fac.usuario_cajero_id
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
                                                      estado = fac.estado == true ? "Activa" : "Anulada"
                                                    };
               /* if (condicion.Equals("")==false)
                {
                    facturas = facturas.
                    Where(s => (s.id.ToString().Contains(condicion) || s.id_cliente.ToString().Contains(condicion) || s.usuario_vendedor_id.ToString().Contains(condicion)));
                }*/

                dataGridView1.DataSource = facturas.ToList();
                dataGridView1.Columns["subtotal"].ValueType = typeof(System.Decimal);
                dataGridView1.Columns["subtotal"].DefaultCellStyle.Format = "N";

                dataGridView1.Columns["itbis"].ValueType = typeof(System.Decimal);
                dataGridView1.Columns["itbis"].DefaultCellStyle.Format = "N";

                dataGridView1.Columns["total"].ValueType = typeof(System.Decimal);
                dataGridView1.Columns["total"].DefaultCellStyle.Format = "N";
            }
            nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";
        }
        

        //Botono anular venta
        private void btn_anular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                MessageBox.Show("Debe seleccionar la venta que desea borrar.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seguro que desea cancelar esta venta ?","Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {


            }  
            
        }

        private void ActivarRango_CheckStateChanged(object sender, EventArgs e)
        {
            if (ActivarRango.Checked == true)
            {
                Console.Write("Activo");
            }
            else
            {

                Console.Write("inactivo");
            }

        }

        private void ConsVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
