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
    public partial class FormComprabantes : FormBaseMan
    {
        public FormComprabantes()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsComprobante obj = new ConsComprobante();
            obj.ShowDialog();
        }

        private void FormComprabantes_Load(object sender, EventArgs e)
        {

        }
    }
}
