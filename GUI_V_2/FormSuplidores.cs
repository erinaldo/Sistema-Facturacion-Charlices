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
    public partial class FormSuplidores : FormBaseMan
    {
        int id = 0;
        public FormSuplidores()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    if (id == 0)
                    {
                        Suplidores suplidor = new Suplidores
                        {
                            codigo = Codigo.Text.Trim(),
                            nombre_completo = Nom.Text.Trim(),
                            cla_rnc = CedSup.Text.Trim(),
                            telefono = TelSup.Text.Trim(),
                            direccion = DirSup.Text.Trim(),
                            estado = true
                        };

                        tabla.Suplidores.Add(suplidor);
                    }

                    else
                    {
                        var suplidor = tabla.Suplidores.FirstOrDefault(a => a.id == id);
                        if (suplidor != null)
                        {
                            suplidor.nombre_completo = Nom.Text.Trim();
                            suplidor.cla_rnc = CedSup.Text.Trim();
                            suplidor.telefono = TelSup.Text.Trim();
                            suplidor.direccion = DirSup.Text.Trim();
                            suplidor.estado = estado.SelectedIndex == 0 ? true : false;
                        }
                    }

                    tabla.SaveChanges();
                    if (id == 0)
                    {
                        MessageBox.Show("El suplidor se ha registrado correctamente.");
                        id = 0;
                    }
                    else MessageBox.Show("El suplidor se ha modificado correctamente.");

                    Utilidades.LimpiarControles(this);
                }

            }
            catch (Exception ex)
            {

                //Guardar error
            }
        }

        private void Codigo_Validated(object sender, EventArgs e)
        {

        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (Codigo.Text.Trim().Equals("") == false)
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    var suplidor = tabla.Suplidores.Where(a => a.codigo == Codigo.Text && a.estado == true).SingleOrDefault();
                    if (suplidor != null)
                    {
                        Nom.Text = suplidor.nombre_completo;
                        CedSup.Text = suplidor.cla_rnc;
                        TelSup.Text = suplidor.telefono;
                        DirSup.Text = suplidor.direccion;
                        estado.SelectedIndex = 0;
                        id = suplidor.id;
                        bnt_eliminar.Enabled = true;

                    }
                    else
                    {
                        Codigo.Limpiar = false;
                        Utilidades.LimpiarControles(this);
                        Codigo.Limpiar = true;
                    }

                }
            }
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar el suplidor?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            try
            {
                using (CRUD_MODEL tabla = new CRUD_MODEL())
                {
                    var suplidor = tabla.Suplidores.FirstOrDefault(a => a.id == id);
                    if (suplidor != null)
                    {
                        suplidor.estado = false;
                        tabla.SaveChanges();
                        MessageBox.Show("El suplidor se ha eliminado correctamente.");
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
