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

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try { 
            FormComprabantes obj = new FormComprabantes();
            obj.ShowDialog();
            }catch(Exception aas)
            {
                //Posible error
            }
}

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
        private void Editar()
        {
            try { 
            if (this.dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                FormComprabantes obj = new FormComprabantes();
                obj.Show();
                obj.Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                obj.Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }catch(Exception aas)
            {
                //Posible error
            }
}
    }
}
