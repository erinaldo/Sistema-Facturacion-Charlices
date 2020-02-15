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
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormSuplidores obj = new FormSuplidores();
            obj.ShowDialog();
        }
    }
}
