﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }

        public Boolean Validar {get; set; }
        public Boolean Limpiar { get; set; }
    }
}
