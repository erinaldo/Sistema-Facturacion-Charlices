﻿using System;
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
        public FormProductos()
        {
            InitializeComponent();
            TipoPro.SelectedIndex = 0;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsPro obj = new ConsPro();
            obj.ShowDialog();
        }
    }
}
