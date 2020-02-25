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
    public partial class FormUnidadesMedidas : FormBaseMan
    {
        public FormUnidadesMedidas()
        {
            InitializeComponent();
        }
        int id = 0;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true) return;

                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    if (id == 0)
                    {
                        Unidades_medidas unidades = new Unidades_medidas
                        {
                            id = Int32.Parse(Codigo.Text.Trim()),
                            nombre = Nom.Text.Trim(),
                            estado = true
                        };
                        tabla.Unidades_medidas.Add(unidades);
                    }

                    else
                    {
                        var unidade = tabla.Unidades_medidas.FirstOrDefault(a => a.id == id);
                        if (unidade != null)
                        {
                            unidade.estado = estado.SelectedIndex == 0 ? true : false;
                            unidade.nombre = Nom.Text;
                        }
                    }
                    tabla.SaveChanges();

                    if (id == 0)
                    {
                        MessageBox.Show("La categoría se ha registrado correctamente.");
                    
                    }
                    else MessageBox.Show("La categoría se ha modificado correctamente.");
                }
                Utilidades.LimpiarControles(this);

            }
            catch (Exception ex)
            {
               //
            }
        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (Codigo.Text.Trim().Equals("") == false)
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    int id = Int32.Parse(Codigo.Text);
                    var unidade = tabla.Unidades_medidas.Where(a => a.id == id && a.estado == true).SingleOrDefault();
                    if (unidade != null)
                    {
                        Nom.Text = unidade.nombre;
                        estado.SelectedIndex = 0;
                        bnt_eliminar.Enabled = true;
                        id = unidade.id;
                    }
                    else
                    {
                        id = 0;
                        bnt_eliminar.Enabled = false;
                        Codigo.Limpiar = false;
                        Utilidades.LimpiarControles(this);
                        Codigo.Limpiar = true;
                        Nom.Text = "";
                    }

                }

            }
        }
    }
}
