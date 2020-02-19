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
    public partial class ConsComprobante : FormBaseCons
    {
        public ConsComprobante()
        {
            InitializeComponent();

            nro_registros.Text = dataGridView1.Rows.Count.ToString() + " REGISTROS.";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormComprabantes obj = new FormComprabantes();
            obj.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.PerformClick();
        }
    }
}
