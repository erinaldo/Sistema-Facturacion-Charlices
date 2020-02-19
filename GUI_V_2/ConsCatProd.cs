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
    public partial class ConsCatProd : FormBaseCons
    {
        public ConsCatProd()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            CodPro.DataPropertyName = "codigo";
            NomPro.DataPropertyName = "nombre";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                IQueryable<Categorias> categorias = from s in DB.Categorias select s;
                if (condicion.Equals(""))
                {
                    categorias = categorias.
                    Where(s => s.estado == true);
                }
                else
                {
                    categorias = categorias.
                    Where(s => (s.codigo.Contains(condicion) || s.nombre.Contains(condicion) && s.estado == true));
                }

                dataGridView1.DataSource = categorias.ToList();
            }
        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {   FormProductos obj = new FormProductos();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
