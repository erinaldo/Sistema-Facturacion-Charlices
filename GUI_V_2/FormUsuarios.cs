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
            //Validando que sea administrador para modificar
            if (Utilidades.tipo_usuario != 1)
            {
                MessageBox.Show("Solo un administrador puede gestionar los mantenimientos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_guardar.Visible = false;
                bnt_eliminar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsUser obj = new ConsUser();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                Codigo.Text = obj.dataGridViewUser.Rows[obj.dataGridViewUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
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
                            tipo_usuario = int.Parse(TipUsu.SelectedIndex.ToString()) + 1,
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
                            usuario.tipo_usuario = int.Parse(TipUsu.SelectedIndex.ToString()) + 1;
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

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (Codigo.Text.Trim().Equals("") == false)
            {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    var usuario = DB.Usuarios.Where(a => a.codigo == Codigo.Text && a.estado == true).SingleOrDefault();
                    if (usuario != null)
                    {
                        Codigo.Text = usuario.codigo;
                        Nom.Text= usuario.nombre_completo;
                        UsuNom.Text=usuario.usuario;
                        UsuPass.Text = usuario.password;
                        CedUsu.Text= usuario.ced_rnc;
                        TelUsu.Text=usuario.telefono;
                        DirUsu.Text=usuario.direccion;
                        CorUsu.Text=usuario.correo;
                        TipUsu.SelectedIndex = usuario.tipo_usuario - 1;
                        estado.SelectedIndex = 0;
                        id = usuario.id;
                        bnt_eliminar.Enabled = true;
                    }
                    else
                    {
                        id = 0;
                        bnt_eliminar.Enabled = false;
                        Codigo.Limpiar = false;
                        Utilidades.LimpiarControles(this);
                        Codigo.Limpiar = true;
                    }

                }
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
