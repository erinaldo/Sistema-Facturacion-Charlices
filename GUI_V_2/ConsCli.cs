using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Consultas
{
    public partial class ConsCli : FormBaseCons
    {
        public ConsCli()
        {
            InitializeComponent();
            dataGridClientes.AutoGenerateColumns = false;
            CodCli.DataPropertyName = "codigo";
            NomCli.DataPropertyName = "nombre_completo";
            CedCli.DataPropertyName = "cla_rnc";
            TelCli.DataPropertyName = "telefono";
            DirCli.DataPropertyName = "direccion";
            TipCli.DataPropertyName = "tipo_cliente";
            CorCli.DataPropertyName = "correo";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                IQueryable<Clientes> clientes = from c in DB.Clientes select c;
                if (condicion.Equals(""))
                {
                    clientes = clientes.
                    Where(c => c.estado == true);
                }
                else
                {
                    clientes = clientes.
                    Where(c => (c.codigo.Contains(condicion) || c.nombre_completo.Contains(condicion) && c.estado == true));
                }

                dataGridClientes.DataSource = clientes.ToList();
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormClientes obj = new FormClientes();
            obj.ShowDialog();
        }

        private void ConsCli_Load(object sender, EventArgs e)
        {

        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarDataGrid(filtro.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.Rows.Count == 0)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
