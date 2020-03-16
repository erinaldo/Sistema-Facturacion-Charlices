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
            id_cliente.DataPropertyName = "id_cliente";
            fecha.DataPropertyName = "fecha";
            estado.DataPropertyName = "estado";
            LlenarDataGrid();
        }



        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var Ordenes = from c in DB.Ordenes_Reservadas
                                  select new
                                  {
                                      c.id,
                                      c.id_cliente,
                                      c.fecha,
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
                        Where(c => (c.id == Convert.ToInt16(condicion) || c.id_cliente == Convert.ToInt16(condicion)));
                    }


                    dataGridOrdenes.DataSource = Ordenes.ToList();
                }
                nro_registros.Text = dataGridOrdenes.Rows.Count.ToString() + " REGISTROS.";

            }
            catch (Exception aa)
            {
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


    }
}
