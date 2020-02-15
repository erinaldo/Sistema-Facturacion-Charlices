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
    public partial class ConsCatProd : FormBaseCons
    {
        public ConsCatProd()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {   FormProductos obj = new FormProductos();
            obj.ShowDialog();
        }
    }
}
