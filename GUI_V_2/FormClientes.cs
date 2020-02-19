using GUI_V_2.Consultas;
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
    public partial class FormClientes : FormBaseMan
    {
        int id = 0;
        public FormClientes()
        {
            InitializeComponent();
            TipCli.SelectedIndex = 0;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true) return;

                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    if (id == 0)
                    {
                        Clientes cliente = new Clientes
                        {
                            codigo = Codigo.Text.Trim(),
                            nombre_completo = Nom.Text.Trim(),
                            telefono = TelCli.Text.Trim(),
                            direccion = DirCli.Text.Trim(),
                            tipo_cliente = Byte.Parse((TipCli.SelectedIndex + 1).ToString()),
                            correo = CorCli.Text.Trim(),
                            estado = true
                        };

                        tabla.Clientes.Add(cliente);
                    }

                    else
                    {
                        var cliente = tabla.Clientes.FirstOrDefault(a => a.id == id);
                        if (cliente != null)
                        {
                            cliente.nombre_completo = Nom.Text.Trim();
                            cliente.telefono = TelCli.Text.Trim();
                            cliente.direccion = DirCli.Text.Trim();
                            cliente.tipo_cliente = Byte.Parse((TipCli.SelectedIndex + 1).ToString());
                            cliente.correo = CorCli.Text.Trim();
                            cliente.estado = estado.SelectedIndex == 0 ? true : false;
                        }
                    }

                    tabla.SaveChanges();
                    if (id == 0)
                    {
                        MessageBox.Show("El cliente se ha registrado correctamente.");
                        Utilidades.LimpiarControles(this);
                    }
                    else MessageBox.Show("El cliente se ha modificado correctamente.");

                }

            }
            catch (Exception ex)
            {

                //Guardar error
            }
        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (Codigo.Text.Trim().Equals("") == false)
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    var cliente = tabla.Clientes.Where(a => a.codigo == Codigo.Text && a.estado == true).SingleOrDefault();
                    if (cliente != null)
                    {
                        Nom.Text = cliente.nombre_completo;
                        TelCli.Text = cliente.telefono;
                        DirCli.Text = cliente.direccion;
                        TipCli.SelectedIndex = cliente.tipo_cliente - 1;
                        CorCli.Text = cliente.correo;
                        estado.SelectedIndex = 0;
                        id = cliente.id;
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

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            try
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    var cliente = tabla.Clientes.FirstOrDefault(a => a.id == id);
                    if (cliente != null)
                    {
                        cliente.estado = false;
                        tabla.SaveChanges();
                        MessageBox.Show("El cliente se ha eliminado correctamente.");
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

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsCli obj = new ConsCli();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                Codigo.Text = obj.dataGridClientes.Rows[obj.dataGridClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
