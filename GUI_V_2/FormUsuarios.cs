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
    public partial class FormUsuarios : FormBaseMan
    {
        int id = 0;
        public FormUsuarios()
        {
            InitializeComponent();
            TipUsu.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsUser obj = new ConsUser();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                Codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;

                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    if (id == 0)
                    {
                        Usuarios usuario = new Usuarios
                        {
                            codigo = Codigo.Text.Trim(),
                            nombre_completo = Nom.Text.Trim(),
                            usuario = UsuNom.Text.Trim(),
                            password = UsuPass.Text.Trim(),
                            ced_rnc = CedUsu.Text.Trim(),
                            telefono = TelUsu.Text.Trim(),
                            direccion = DirUsu.Text.Trim(),
                            correo = CorUsu.Text.Trim(),
                            tipo_usuario = int.Parse(TipUsu.SelectedIndex.ToString()),
                            estado = true
                        };

                        DB.Usuarios.Add(usuario);
                    }

                    else
                    {
                        var usuario = DB.Usuarios.FirstOrDefault(a => a.id == id);
                        if (usuario != null)
                        {

                            usuario.codigo = Codigo.Text.Trim();
                            usuario.nombre_completo = Nom.Text.Trim();
                            usuario.usuario = UsuNom.Text.Trim();
                            usuario.password = UsuPass.Text.Trim();
                            usuario.ced_rnc = CedUsu.Text.Trim();
                            usuario.telefono = TelUsu.Text.Trim();
                            usuario.direccion = DirUsu.Text.Trim();
                            usuario.correo = CorUsu.Text.Trim();
                            usuario.tipo_usuario = int.Parse(TipUsu.SelectedIndex.ToString());
                            usuario.estado = estado.SelectedIndex == 0 ? true : false;
                        }
                    }

                        DB.SaveChanges();
                        if (id == 0)
                        {
                            MessageBox.Show("El usuario se ha registrado correctamente.");
                            Utilidades.LimpiarControles(this);
                        }
                        else MessageBox.Show("El usuario se ha modificado correctamente.");

                    }

            }
            catch (Exception ex)
            {

                //Guardar error
            }
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar el usuario?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            try
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var usuario = DB.Usuarios.FirstOrDefault(a => a.id == id);
                    if (usuario != null)
                    {
                        usuario.estado = false;
                        DB.SaveChanges();
                        MessageBox.Show("El usuario se ha eliminado correctamente.");
                        Utilidades.LimpiarControles(this);
                        bnt_eliminar.Enabled = false;
                        id = 0;
                    }
                }

            }
            catch (Exception)
            {

                //Guardar Error
            }
        }
    }
}
