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
    public partial class FormCaja : Form
    {
        public FormCaja()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Entradas obj = new Entradas();
            obj.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Salidas obj = new Salidas();
            obj.ShowDialog();
        }
    }
}