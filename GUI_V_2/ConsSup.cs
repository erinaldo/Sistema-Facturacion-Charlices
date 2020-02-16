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
    public partial class ConsSup : FormBaseCons
    {
        public ConsSup()
        {
            InitializeComponent();
            dataGridSuplidores.AutoGenerateColumns = false;
            CodSup.DataPropertyName = "codigo";
            NomSup.DataPropertyName = "nombre_completo";
            CLA_RNC_Sup.DataPropertyName = "cla_rnc";
            TelSup.DataPropertyName = "telefono";
            DIRSup.DataPropertyName = "direccion";
            estatus.DataPropertyName = "estado";
            LlenarDataGrid();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                IQueryable<Suplidores> suplidores = from s in DB.Suplidores select s;
                if (condicion.Equals(""))
                {
                    suplidores = suplidores.
                    Where(s => s.estado == true);
                }
                else
                {
                    suplidores = suplidores.
                    Where(s => (s.codigo.Contains(condicion) || s.nombre_completo.Contains(condicion) && s.estado == true));
                }

                dataGridSuplidores.DataSource = suplidores.ToList();
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormSuplidores obj = new FormSuplidores();
            obj.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarDataGrid(filtro.Text);
        }
    }
}
