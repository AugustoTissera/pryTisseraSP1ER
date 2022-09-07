using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryTisseraSP1ER
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter swMovimientos = new StreamWriter("./movimientos.txt");
            swMovimientos.WriteLine(cboFacturaTipo.Text + "\u0009" + txtFacturaNro.Text + "\u0009" + dtpFecha.Text + "\u0009" + txtClienteID.Text + "\u0009" + txtVendedorID.Text + "\u0009" + txtMonto.Text);

            MessageBox.Show("Datos cargados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            swMovimientos.Close();

            txtClienteID.Text = "";
            txtVendedorID.Text = "";
            cboFacturaTipo.Text = "";
            txtFacturaNro.Text = "";
            dtpFecha.Value = DateTime.Today;
            txtMonto.Text = "";
            txtClienteID.Focus();
        }
    }
}
