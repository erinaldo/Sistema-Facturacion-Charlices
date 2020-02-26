using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Reportes
{
    public partial class FormReportesDatos : Form
    {
        public FormReportesDatos()
        {
            InitializeComponent();
        }

        public List<ProductosClass> Productos = new List<ProductosClass>();
        
        private void FormReportes_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetProductos", Productos));
            this.reportViewer1.RefreshReport();

        }
    }
}
