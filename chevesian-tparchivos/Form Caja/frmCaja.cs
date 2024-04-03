using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chevesian_tparchivos
{
    public partial class frmCaja : Form
    {
        gestorCaja _gestorCaja;
        public frmCaja()
        {
            InitializeComponent();
        }

        private void lblNumCaja_Click(object sender, EventArgs e)
        {

        }

        private void btmCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    btmCargarArchivo.Enabled = false;
                    btmAgregarCaja.Enabled = true;
                    btmEliminarCaja.Enabled = true;
                    btmModificarDatos.Enabled = true;
                    _gestorCaja = new gestorCaja(openFileDialog1.FileName);
                    lblArchivoSeleccionado.Text = openFileDialog1.FileName;
                    MostrarCaja();
                }
            }
            catch (Exception)
            {
                btmCargarArchivo.Enabled = true;
                btmAgregarCaja.Enabled = false;
                btmEliminarCaja.Enabled = false;
                btmModificarDatos.Enabled = false;
                MessageBox.Show("Error al cargar el archivo.");
            }
        }


        private void btmAgregarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCaja.Text.Length > 0 && txtNumCaja.Text.Length > 0)
                {
                    String nombreCaja = txtNombreCaja.Text;
                    int numCaja = Convert.ToInt32(txtNumCaja.Text);
                    Caja miCaja = new Caja(nombreCaja, numCaja);
                    _gestorCaja.AgregarCaja(miCaja);
                    ClearTextBox();
                    MostrarCaja();
                }
                else MessageBox.Show("Debe completar los datos...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btmEliminarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (_gestorCaja.CheckListCaja())
                {
                    if (lstCaja.SelectedItem != null)
                    {
                        Caja cajaSeleccionada = (Caja)lstCaja.SelectedItem;
                        _gestorCaja.EliminarCaja(cajaSeleccionada.getNumeroCaja(), cajaSeleccionada.getNombre());
                        MostrarCaja();
                    }
                    else MessageBox.Show("Debe seleccionar una caja.");
                }
                else MessageBox.Show("No hay elementos en la caja para ser eliminados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btmModificarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (_gestorCaja.CheckListCaja())
                {
                    if (lstCaja.SelectedItem != null)
                    {
                        if (txtNombreCaja.Text.Length > 0 && txtNumCaja.Text.Length > 0)
                        {
                            Caja cajaSeleccionado = (Caja)lstCaja.SelectedItem;
                            String nuevoNombreCaja = txtNombreCaja.Text;
                            int nuevoNumCaja = Convert.ToInt32(txtNumCaja.Text);
                            bool Resultado = _gestorCaja.ModificarDatos(cajaSeleccionado.getNumeroCaja(), cajaSeleccionado.getNombre(), nuevoNumCaja, nuevoNombreCaja);
                            ClearTextBox();
                            MostrarCaja();

                            if (Resultado)
                            {
                                Color color = btmModificarDatos.BackColor;
                                btmModificarDatos.BackColor = Color.Green;
                                Timer timer = new Timer();
                                timer.Interval = 500;

                                timer.Tick += (s, agrs) =>
                                {
                                    btmModificarDatos.BackColor = color;
                                    timer.Stop();
                                    timer.Dispose();
                                };

                                timer.Start();
                            }
                            else
                            {
                                Color color = btmModificarDatos.BackColor;
                                btmModificarDatos.BackColor = Color.Red;
                                Timer timer = new Timer();
                                timer.Interval = 500;

                                timer.Tick += (s, agrs) =>
                                {
                                    btmModificarDatos.BackColor = color;
                                    timer.Stop();
                                    timer.Dispose();
                                };

                                timer.Start();
                            }
                        }
                        else MessageBox.Show("Debe completar los datos para poder modificar una caja.");
                    }
                    else MessageBox.Show("Debe seleccionar una caja.");
                }
                else MessageBox.Show("No hay elementos en la caja para ser eliminados.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void MostrarCaja()
        {
            lstCaja.DataSource = _gestorCaja.listarCaja();
        }

        void ClearTextBox()
        {
            txtNombreCaja.Clear();
            txtNumCaja.Clear();
        }

    }
}
