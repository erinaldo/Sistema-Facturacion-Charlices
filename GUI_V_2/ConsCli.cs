﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Consultas
{
    public partial class ConsCli : FormBaseCons
    {
        public ConsCli()
        {
            InitializeComponent();


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormClientes obj = new FormClientes();
            obj.ShowDialog();
        }
    }
}
