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
    public partial class FormCategorias : FormBaseMan
    {
        int id = 0;
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
               using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    if (id ==0)
                    {
                        Categorias categoria = new Categorias
                        {
                            codigo = Codigo.Text.Trim(),
                            nombre = Nom.Text.Trim(),
                            estado = true
                        };

                        tabla.Categorias.Add(categoria);
                    }

                    else
                    {
                        var categoria = tabla.Categorias.FirstOrDefault(a => a.id == id);
                        if (categoria != null)
                        {
                            categoria.estado = estado.SelectedIndex == 0 ? true : false;
                            categoria.nombre = Nom.Text;
                        }
                    }

                    tabla.SaveChanges();
                    if (id == 0)
                    {
                        MessageBox.Show("La categoría se ha registrado correctamente.");
                        id = 0;
                    }
                    else MessageBox.Show("La categoría se ha modificado correctamente.");
                     
                    Utilidades.LimpiarControles(this);
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
                    var categoria = tabla.Categorias.Where(a => a.codigo == Codigo.Text && a.estado == true).SingleOrDefault();
                    if (categoria!=null)
                    {
                        Nom.Text = categoria.nombre;
                        estado.SelectedIndex = 0;
                        bnt_eliminar.Enabled = true;
                        id = categoria.id;
                   }
                    
                }
            }
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar la categoría?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            try
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    var categoria = tabla.Categorias.FirstOrDefault(a => a.id == id);
                    if (categoria != null)
                    {
                        categoria.estado = false;
                        tabla.SaveChanges();
                        MessageBox.Show("La categoría se ha eliminado correctamente.");
                        Utilidades.LimpiarControles(this);
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
