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
    public partial class FormUsuarios : FormBaseMan
    {
        public FormUsuarios()
        {
            InitializeComponent();
            TipUsu.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsUser obj = new ConsUser();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                Codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }
    }
}
