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
    public partial class frmFactura : Form
    {
        gestorFactura _gestorFactura;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void btmCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    btmCargarArchivo.Enabled = false;
                    btmAgregarFactura.Enabled = true;
                    btmEliminarFactura.Enabled = true;
                    btmModificarDatos.Enabled = true;
                    lblArchivoSeleccionado.Text = openFileDialog1.FileName;
                    _gestorFactura = new gestorFactura(openFileDialog1.FileName);
                    MostrarFactura();
                }
            }
            catch (Exception)
            {
                btmCargarArchivo.Enabled = true;
                btmAgregarFactura.Enabled = false;
                btmEliminarFactura.Enabled = false;
                btmModificarDatos.Enabled = false;
                MessageBox.Show("Error al cargar el archivo.");
            }
        }

        private void btmAgregarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMonto.Text.Length > 0 && txtNumCaja.Text.Length > 0 && txtNumFactura.Text.Length > 0)
                {
                    double monto = Convert.ToDouble(txtMonto.Text);
                    int numCaja = Convert.ToInt32(txtNumCaja.Text);
                    int numFactura = Convert.ToInt32(txtNumFactura.Text);
                    Factura miFactura = new Factura(numFactura, numCaja, monto);
                    _gestorFactura.AgregarFactura(miFactura);
                    MostrarFactura();
                    ClearTextBox();
                }
                else MessageBox.Show("Debe completar los datos...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btmEliminarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (_gestorFactura.CheckListFactura())
                {
                    if (lstFactura.SelectedItem != null)
                    {
                        Factura facturaSeleccionada = (Factura)lstFactura.SelectedItem;
                        _gestorFactura.EliminarFactura(facturaSeleccionada.getNumFactura(), facturaSeleccionada.getNumCaja(), facturaSeleccionada.getMonto());
                        MostrarFactura();
                    }
                    else MessageBox.Show("Debe seleccionar una factura.");
                }
                else MessageBox.Show("No hay facturas para ser eliminadas.");
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
                if (_gestorFactura.CheckListFactura())
                {
                    if (lstFactura.SelectedItem != null) 
                    {
                        if (txtMonto.Text.Length > 0 && txtNumCaja.Text.Length > 0 && txtNumFactura.Text.Length > 0)
                        {
                            Factura facturaSeleccionada = (Factura)lstFactura.SelectedItem;
                            double montoNew = Convert.ToDouble(txtMonto.Text);
                            int numCajaNew = Convert.ToInt32(txtNumCaja.Text);
                            int numFacturaNew = Convert.ToInt32(txtNumFactura.Text);
                            bool resultado = _gestorFactura.ModificarDatos(facturaSeleccionada.getNumFactura(), facturaSeleccionada.getNumCaja(), facturaSeleccionada.getMonto(), numFacturaNew, numCajaNew, montoNew);

                            if (resultado)
                            {
                                Color color = btmModificarDatos.BackColor;
                                btmModificarDatos.BackColor = Color.Green;
                                Timer timer = new Timer();
                                timer.Interval = 500;

                                timer.Tick += (s, args) =>
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

                                timer.Tick += (s, args) =>
                                {
                                    btmModificarDatos.BackColor = color;
                                    timer.Stop();
                                    timer.Dispose();
                                };

                                timer.Start();
                            }
                            MostrarFactura();
                            ClearTextBox();
                        }
                        else MessageBox.Show("Debe completar los datos.");
                    }
                    else MessageBox.Show("Debe seleccionar una factura.");
                }
                else MessageBox.Show("No hay facturas para ser modificadas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void MostrarFactura()
        {
            lstFactura.DataSource = _gestorFactura.listarFactura();
        }

        void ClearTextBox()
        {
            txtMonto.Clear();
            txtNumCaja.Clear();
            txtNumFactura.Clear();
        }

        private void lstFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
