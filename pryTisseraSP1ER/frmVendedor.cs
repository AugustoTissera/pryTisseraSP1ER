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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string varComision;
            if (cboComision.Text == "Sí")
            {
                varComision = "1";
            }
            else
            {
                varComision = "0";
            }

            string varActivo;
            if (cboActivo.Text == "Sí")
            {
                varActivo = "1";
            }
            else
            {
                varActivo = "0";
            }

            if (File.Exists("./vendedores.txt") == true)
            {
                bool Bandera = false;

                StreamReader srVendedores = new StreamReader("./vendedores.txt");
                while (!srVendedores.EndOfStream)
                {
                    string[] vecVendedores = srVendedores.ReadLine().Split('\u0009');

                    if (vecVendedores[0] == txtID.Text)
                    {
                        Bandera = true;
                    }
                }
                srVendedores.Close();

                if (Bandera == true)
                {
                    MessageBox.Show("El ID ya se encuentra cargado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter swVendedores = new StreamWriter("./vendedores.txt", true);
                    swVendedores.WriteLine(txtID.Text + "\u0009" + txtNombre.Text + "\u0009" + varActivo + "\u0009" + varComision);

                    MessageBox.Show("Datos cargados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    swVendedores.Close();

                    txtID.Text = "";
                    txtNombre.Text = "";
                    cboActivo.Text = "";
                    cboComision.Text = "";
                    txtID.Focus();
                }
            
            
            }
            else
            {
                StreamWriter swVendedores = new StreamWriter("./vendedores.txt", true);
                swVendedores.WriteLine(txtID.Text + "\u0009" + txtNombre.Text + "\u0009" + cboActivo.Text + "\u0009" + cboComision.Text);

                MessageBox.Show("Datos cargados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                swVendedores.Close();

                txtID.Text = "";
                txtNombre.Text = "";
                cboActivo.Text = "";
                cboComision.Text = "";
                txtID.Focus();
            }
            
        }
    }
}
