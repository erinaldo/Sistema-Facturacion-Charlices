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
            try
            {
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
                
                //total vendido al txt
                double total_ventas = 0;             
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total_ventas += Convert.ToDouble(row.Cells["total"].Value);
                }
                txt_totalGrid.Text = total_ventas.ToString();
                
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

            if (MessageBox.Show("Seguro que desea anular esta venta ?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes )
            {


            }  
            
        }

        //Activar o desactivar por rango
        private void ActivarRango_CheckStateChanged(object sender, EventArgs e)
        {
            if (ActivarRango.Checked == true)
            {   
                fecha_inicio.Enabled = true;
                fecha_fin.Enabled = true;
            }
            else
            {
                fecha_inicio.Enabled = false;
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
                txt_total_neto.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txt_itbis.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txt_subtotal.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
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

      
    }
}
