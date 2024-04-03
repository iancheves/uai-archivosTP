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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btmCaja_Click(object sender, EventArgs e)
        {
            try
            {
                frmCaja _frmCaja = new frmCaja();
                _frmCaja.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btmFactura_Click(object sender, EventArgs e)
        {
            try
            {
                frmFactura _frmFactura = new frmFactura();
                _frmFactura.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
