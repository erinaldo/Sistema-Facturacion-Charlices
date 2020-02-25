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
    public partial class FormProductos : FormBaseMan
    {
        int id = 0;
        public FormProductos()
        {
            InitializeComponent();
            TipoPro.SelectedIndex = 0;
            itbis.SelectedIndex = 0;
            LlenarComboxCategorias();
            LlenarComboxUnidadMedidas();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsPro obj = new ConsPro();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                Codigo.Text = obj.dataGridVProducto.Rows[obj.dataGridVProducto.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

       public void LlenarComboxCategorias()
        {
            categoriasCombox.DisplayMember = "nombre";
            categoriasCombox.ValueMember   = "id";
            try
            {
                using(CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Categorias> categorias = db.Categorias.Where(c => c.estado == true).OrderBy(c=>c.nombre);
                    categoriasCombox.DataSource = categorias.ToList();
                }
            }
            catch (Exception)
            {

            }

        }


        public void LlenarComboxUnidadMedidas()
        {
            unidadMedidaCombox.DisplayMember = "nombre";
            unidadMedidaCombox.ValueMember   = "id";
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    IQueryable<Unidades_medidas> unidades_medida = db.Unidades_medidas.Where(u => u.estado == true).OrderBy(u => u.nombre);
                    unidadMedidaCombox.DataSource = unidades_medida.ToList();
                }
            }
            catch (Exception)
            {

            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true) return;

                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    if (id == 0)
                    {
                        Productos producto = new Productos
                        {
                            codigo = Codigo.Text.Trim(),
                            nombre = Nom.Text.Trim(),
                            precio_normal = precio_normal.Value,
                            precio_empleado= precio_empleado.Value,
                            precio_empresa = precio_empresa.Value,
                            itbis = int.Parse(itbis.SelectedItem.ToString().Replace("%","")),
                            cantidad = Int32.Parse(cantidadPro.Value.ToString()),
                            re_orden  = Int32.Parse(reorden.Value.ToString()),
                            id_categoria = Int32.Parse(categoriasCombox.SelectedValue.ToString()),
                            id_unidad_medida = Int32.Parse(unidadMedidaCombox.SelectedValue.ToString()),
                            tipo_producto = Byte.Parse((TipoPro.SelectedIndex + 1).ToString()),
                            estado = true
                        };

                        db.Productos.Add(producto);
                    }

                    else
                    {
                        var producto = db.Productos.FirstOrDefault(a => a.id == id);
                        if (producto != null)
                        {
                            producto.nombre = Nom.Text.Trim();
                            producto.precio_normal = precio_normal.Value;
                            producto.precio_empleado = precio_empleado.Value;
                            producto.precio_empresa = precio_empresa.Value;
                            producto.itbis = int.Parse(itbis.SelectedItem.ToString().Replace("%", ""));
                            producto.cantidad = Int32.Parse(cantidadPro.Value.ToString());
                            producto.re_orden = Int32.Parse(reorden.Value.ToString());
                            producto.id_categoria = Int32.Parse(categoriasCombox.SelectedValue.ToString());
                            producto.id_unidad_medida = Int32.Parse(unidadMedidaCombox.SelectedValue.ToString());
                            producto.tipo_producto = Byte.Parse((TipoPro.SelectedIndex + 1).ToString());
                            producto.estado = estado.SelectedIndex == 0 ? true : false;
                        }
                    }

                    db.SaveChanges();
                    if (id == 0)
                    {
                        MessageBox.Show("El producto se ha registrado correctamente.");
                        Utilidades.LimpiarControles(this);
                    }
                    else MessageBox.Show("El producto se ha modificado correctamente.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                //Guardar error
            }
        }

        private void Codigo_Leave(object sender, EventArgs e)
        {
            if (Codigo.Text.Trim().Equals("") == false)
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    var producto = db.Productos.Where(a => a.codigo == Codigo.Text && a.estado == true).SingleOrDefault();
                    if (producto != null)
                    {
                        Nom.Text                         = producto.nombre;
                        precio_normal.Value              = producto.precio_normal;
                        precio_empleado.Value            = producto.precio_empleado;
                        precio_empresa.Value             = producto.precio_empresa;
                        itbis.SelectedIndex              = producto.itbis == 18 ? 0 : 1;
                        cantidadPro.Value                = producto.cantidad;
                        reorden.Value                    = producto.re_orden;
                        categoriasCombox.SelectedValue   = producto.id_categoria;
                        unidadMedidaCombox.SelectedValue = producto.id_unidad_medida;
                        TipoPro.SelectedIndex            = producto.tipo_producto == 1 ? 0 : 1;
                        estado.SelectedIndex             = 0;
                        id                               = producto.id;
                        bnt_eliminar.Enabled             = true;
                    }
                    else
                    {
                        id = 0;
                        Codigo.Limpiar = false;
                        Utilidades.LimpiarControles(this);
                        Codigo.Limpiar = true;
                    }

                }
            }
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quieres eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            try
            {
                using (CRUD_MODEL db = new CRUD_MODEL())
                {
                    var producto = db.Productos.FirstOrDefault(a => a.id == id);
                    if (producto != null)
                    {
                        producto.estado = false;
                        db.SaveChanges();
                        MessageBox.Show("El producto se ha eliminado correctamente.");
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

        private void btn_nueva_categoria_Click(object sender, EventArgs e)
        {
            FormCategorias obj = new FormCategorias();
            obj.ShowDialog();
            LlenarComboxCategorias();
        }
       
        private void btn_nueva_unidad_Click(object sender, EventArgs e)
        {
            FormUnidadesMedidas obj = new FormUnidadesMedidas();
            obj.ShowDialog();
            LlenarComboxUnidadMedidas();
        }

        //por si hay articulos que tienen el mismo precio no tenga que joder con escribir mucho.
        private void precio_normal_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void precio_normal_ValueChanged(object sender, EventArgs e)
        {
            precio_empleado.Value = precio_normal.Value;
            precio_empresa.Value = precio_normal.Value;
        }

        private void precio_normal_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
