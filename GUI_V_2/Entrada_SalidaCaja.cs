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
    public partial class Entrada_SalidaCaja : Form
    {
        public Entrada_SalidaCaja()
        {
            InitializeComponent();
            try { 
            dataGridView1.AutoGenerateColumns = false;
            id.DataPropertyName = "id";
            fecha.DataPropertyName = "fecha";
            id_usuario.DataPropertyName = "id_usuario";
            motivo.DataPropertyName = "motivo";
            monto.DataPropertyName = "monto";
            }
            catch (Exception ex) {
             //   MessageBox.Show(ex.ToString());
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el movimiento de la caja que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult pregunta = MessageBox.Show($"¿Esta seguro que desea borrar el movimiento?", "Confirme", MessageBoxButtons.YesNo);
            if (pregunta != DialogResult.Yes)
            {
                return;
            }

            try {
                using (CRUD_MODEL DB = new CRUD_MODEL())
                {
                    int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());
                    IQueryable<Entrada_Salida_Caja> caja = DB.Entrada_Salida_Caja.Where(c => c.id == id);
                    var resp = caja.SingleOrDefault();
                    if (resp != null)
                    {
                        resp.estado = false;
                        DB.SaveChanges();
                        TraerAccionCaja();
                    }
                }
            }
            catch (Exception ex) {
             //   MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void Salidas_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3),
                           this.DisplayRectangle);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try { 
            if(comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar el tipo de acción para reaizar el proceso.");
                return;
            }
            if (!Utilidades.ValidarFormulario(this, errorProvider1))
            {
                try
                {
                    using (CRUD_MODEL DB = new CRUD_MODEL())
                    {
                        if (comboBox1.SelectedIndex == 1)
                        {
                            var res = DB.Procedimiento_total_caja("salida_Caja", Utilidades.id_usuario);
                            var totales_caja = res.FirstOrDefault();
                            if (float.Parse(txt_monto.Text.Trim()) > totales_caja.total_efectivo_caja)
                            {
                                MessageBox.Show($"No hay suficiente dinero en caja para sacar ese monto. La caja solo dispone de {totales_caja.total_efectivo_caja.ToString()}");
                                return;
                            }
                        }
                        Entrada_Salida_Caja caja = new Entrada_Salida_Caja
                        {
                            estado = true,
                            fecha = DateTime.Now,
                            id_usuario = Utilidades.id_usuario,
                            monto = float.Parse(txt_monto.Text.Trim()),
                            motivo = txt_motivo.Text.Trim(),
                            tipo = comboBox1.SelectedIndex == 0 ? false : true
                        };

                        DB.Entrada_Salida_Caja.Add(caja);
                        DB.SaveChanges();
                        string accion = comboBox1.SelectedIndex == 0 ? "entrada" : "salida";
                        MessageBox.Show($"EL monto de {accion} a la caja se ha registrado correctamente.");
                        TraerAccionCaja();
                        txt_monto.Text = "";
                        txt_motivo.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try { 
            if (comboBox1.SelectedIndex == -1) return;
                    TraerAccionCaja();
        }
            catch (Exception ex) {
             //   MessageBox.Show(ex.ToString());
            }
}

        public void TraerAccionCaja()
        {
            try { 
            using (CRUD_MODEL DB = new CRUD_MODEL())
            {
                bool tipo = comboBox1.SelectedIndex == 1 ? true : false;
                IQueryable<Entrada_Salida_Caja> caja = DB.Entrada_Salida_Caja.Where(c => c.estado == true && c.tipo == tipo);
                dataGridView1.DataSource = caja.ToList();
            }
        }
            catch (Exception ex) {
             //   MessageBox.Show(ex.ToString());
            }
}

        private void Entrada_SalidaCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
