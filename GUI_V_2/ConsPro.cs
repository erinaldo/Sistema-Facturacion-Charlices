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
    public partial class ConsPro : FormBaseCons
    {
        public ConsPro()
        {
            InitializeComponent();
            dataGridVProducto.AutoGenerateColumns = false;
            CodPro.DataPropertyName = "id";
            NomPro.DataPropertyName = "nombre_producto";
            CatPro.DataPropertyName = "nombre_categoria";
            PreNor.DataPropertyName = "precio_normal";
            PreEmp.DataPropertyName = "precio_empleado";
            PreEmpresa.DataPropertyName = "precio_empresa";
            Unidad.DataPropertyName = "unidad";
            itbis.DataPropertyName = "itbis";
            CanPro.DataPropertyName = "cantidad";
            Reorden.DataPropertyName = "re_orden";
            TipPro.DataPropertyName = "tipo_producto";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ConsPro obj = new ConsPro();
            obj.ShowDialog();
        }

        private void ConsPro_Load(object sender, EventArgs e)
        {

        }


        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                //IQueryable<Productos> 
                  var productos = (from pro in DB.Productos join cat in DB.Categorias on pro.id_categoria
                                                   equals cat.id join unidad in DB.Unidades_medidas on pro.id_unidad_medida
                                                   equals unidad.id  where pro.estado ==true select new {
                                                       pro.id,
                                                       nombre_producto = pro.nombre,
                                                       nombre_categoria = cat.nombre,
                                                       pro.precio_normal,
                                                       pro.precio_empleado,
                                                       pro.precio_empresa,
                                                       unidad = unidad.nombre,
                                                       pro.itbis,
                                                       pro.cantidad,
                                                       pro.re_orden,
                                                       pro.tipo_producto,
                                                       pro.estado
                                                    });
                    dataGridVProducto.DataSource = productos.ToList();
            }

        }
    }
}
