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
            id.DataPropertyName = "id";
            fecha.DataPropertyName = "fecha";
            total.DataPropertyName = "total";
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
                IQueryable<Facturas> Unidades = from s in DB.Facturas select s;
                if (condicion.Equals(""))
                {
                    Unidades = Unidades.
                    Where(s => s.id>0);
                }
                else
                {
                    Unidades = Unidades.
                    Where(s => (s.id.ToString().Contains(condicion) || s.id_cliente.ToString().Contains(condicion) || s.usuario_vendedor_id.ToString().Contains(condicion)));
                }

                dataGridView1.DataSource = Unidades.ToList();
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
    }
}
