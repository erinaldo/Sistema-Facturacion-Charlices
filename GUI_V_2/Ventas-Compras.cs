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
    public partial class Ventas_Compras : Form
    {
        public Ventas_Compras()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirFormVenta();
        }

        private void pic_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormVenta();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirFormVenta();
        }

        public void AbrirFormVenta()
        {
            if (Utilidades.ValidarAperturaCaja())
            {
                    VentasModoTouch ventas = new VentasModoTouch();
                    ventas.ShowDialog();
            }
        }
    }
}
