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
    public partial class ConsResOrden : FormBaseCons
    {
        public ConsResOrden()
        {
            InitializeComponent();
            id.DataPropertyName = "id";
            id_cliente.DataPropertyName = "nombre_completo";
            fecha.DataPropertyName = "fecha";
            id_mesera.DataPropertyName = "id_mesera";
            estado.DataPropertyName = "estado";

            LlenarDataGrid();
        }



        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var Ordenes = from o in DB.Ordenes_Reservadas join c in DB.Clientes on o.id_cliente equals c.id join m in DB.Usuarios on o.id_mesera equals m.id
                                  select new
                                  {
                                      o.id,
                                      c.nombre_completo,
                                      o.fecha,
                                      id_mesera= m.nombre_completo,
                                      estado = c.estado==true ? "PAGA" : "SIN PAGAR",

                                  };
                    if (condicion.Equals(""))
                    {
                        Ordenes = Ordenes.
                        Where(c => c.id > 0);
                    }
                    else
                    {
                        Ordenes = Ordenes.
                        Where(c => (c.id == int.Parse(condicion) || c.nombre_completo == condicion));
                    }


                    dataGridOrdenes.DataSource = Ordenes.ToList();
                }
                nro_registros.Text = dataGridOrdenes.Rows.Count.ToString() + " REGISTROS.";

            }
            catch (Exception aa)
            {
                MessageBox.Show(aa.ToString());
                //error charly
            }
        }

        //boton seleccionar
        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridOrdenes.Rows.Count == 0) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConsResOrden_Load(object sender, EventArgs e)
        {

        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            //LlenarDataGrid(filtro.Text.Trim());
        }
    }
}
