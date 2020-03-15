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
    public partial class ConsUser : FormBaseCons
    {
        public ConsUser()
        {
            InitializeComponent();
            dataGridViewUser.AutoGenerateColumns = false;
            CodUser.DataPropertyName = "codigo";
            NomUser.DataPropertyName = "nombre_completo";
            usuario.DataPropertyName = "usuario";
            TipoUser.DataPropertyName = "tipo_usuario";
            CedUser.DataPropertyName = "ced_rnc";
            TelUser.DataPropertyName = "telefono";
            DirUser.DataPropertyName = "direccion";
            CorreoUser.DataPropertyName = "correo";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormUsuarios obj = new FormUsuarios();
            obj.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                var usuarios = from u in DB.Usuarios select new {
                   u.codigo,
                   u.nombre_completo,
                   u.usuario,
                   tipo_usuario = u.tipo_usuario==1 ? "CAJERO" : "ADMINISTRADOR",
                   u.ced_rnc,
                   u.telefono,
                   u.direccion,
                   u.correo,
                   u.estado
                };
                if (condicion.Equals(""))
                {
                    usuarios = usuarios.
                    Where(s => s.estado == true);
                }
                else
                {
                    usuarios = usuarios.
                    Where(s => (s.codigo.Contains(condicion) || s.nombre_completo.Contains(condicion) && s.estado == true));
                }

                dataGridViewUser.DataSource = usuarios.ToList();
            }
            nro_registros.Text = dataGridViewUser.Rows.Count.ToString() + " REGISTROS.";
        }


        private void Editar()
        {
            if (this.dataGridViewUser.Rows.Count > 0 && dataGridViewUser.SelectedRows.Count > 0)
            {
                FormUsuarios obj = new FormUsuarios();
                obj.Show();
                obj.Codigo.Text = dataGridViewUser.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void ConsUser_Load(object sender, EventArgs e)
        {

        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarDataGrid(filtro.Text);
        }
    }
}
