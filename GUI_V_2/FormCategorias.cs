﻿using System;
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
            //Validando que sea administrador para modificar
            if (Utilidades.tipo_usuario != 1)
            {
                MessageBox.Show("Solo un administrador puede gestionar los mantenimientos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_guardar.Visible = false;
                bnt_eliminar.Visible = false;
            }

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
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true) return;

                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    if (id ==0)
                    {
                        Categorias categoria = new Categorias
                        {
                            codigo = Codigo.Text.Trim(),
                            nombre = Nom.Text.Trim(),
                            estado = true,
                            cocina = cocina.Checked
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
                            categoria.cocina = cocina.Checked;
                        }
                    }

                    tabla.SaveChanges();
                    if (id == 0)
                    {
                        MessageBox.Show("La categoría se ha registrado correctamente.");
                        Utilidades.LimpiarControles(this);
                    }
                    else MessageBox.Show("La categoría se ha modificado correctamente.");
                     
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
                        cocina.Checked = categoria.cocina;
                        estado.SelectedIndex = 0;
                        bnt_eliminar.Enabled = true;
                        id = categoria.id;
                    }
                    else
                    {
                        id = 0;
                        bnt_eliminar.Enabled = false;
                        Codigo.Limpiar = false;
                        cocina.Checked = false;
                        Utilidades.LimpiarControles(this);
                        Codigo.Limpiar = true;
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
