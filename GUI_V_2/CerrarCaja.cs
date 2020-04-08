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
    public partial class CerrarCaja : Form
    {
        public CerrarCaja()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        //Boton Cerrar Caja
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Accion cerrar Caja
        private void btn_cerrarCaja_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1))
                return;

        
           if(DialogResult.Yes == MessageBox.Show("No se puede vender por hoy, luego del cierre de caja. ¿Esta seguro que desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    IQueryable<Usuarios> usuario = DB.Usuarios.Where(u => u.usuario == txt_user.Text.Trim() && u.password == txt_pass.Text.Trim());

                    var resp = usuario.SingleOrDefault();
                    if (resp == null)
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecto.");
                    }
                    else
                    {
                        if (resp.id != Utilidades.id_usuario)
                        {
                            MessageBox.Show("Los credenciales no coinciden con el usuario logeado, cierre la sesión e inicie sesión con su usuario correspondiente.");
                        }
                        else
                        {
                            var res = DB.Procedimiento_total_caja("cierre_caja", Utilidades.id_usuario);
                            var totales_caja = res.FirstOrDefault();
                            ResumenCaja caja = new ResumenCaja();
                            caja.total_efectivo.Text = totales_caja.total_ventas_efectivo.ToString();
                            caja.anuladas.Text = totales_caja.apertura_caja.ToString();
                            caja.totales_ventas.Text = (totales_caja.total_ventas_efectivo + totales_caja.apertura_caja).ToString();

                            //movimiento caja
                            caja.apertura.Text = totales_caja.apertura_caja.ToString();
                            caja.entradas.Text = totales_caja.entrada_caja.ToString();
                            caja.salidas.Text = totales_caja.salida_caja.ToString();
                            caja.total_movimiento_caja.Text = ((totales_caja.apertura_caja + totales_caja.entrada_caja) - totales_caja.salida_caja).ToString();

                            caja.total_efectivo_caja.Text = totales_caja.total_efectivo_caja.ToString();
                            caja.ShowDialog();
                            this.Close();
                        }
                    }

                }

                }

            }

        private void CerrarCaja_Load(object sender, EventArgs e)
        {

        }


        //Metodo cerrar caja






    }
}
