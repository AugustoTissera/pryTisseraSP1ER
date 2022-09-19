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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./clientes.txt") == true)
            {
                bool Bandera = false;

                StreamReader srClientes = new StreamReader("./clientes.txt");

                while (!srClientes.EndOfStream) // Recorremos el archivo hasta el final
                {
                    string[] vecClientes = srClientes.ReadLine().Split('\u0009'); // Creamos un vector por cada renglón que se está leyendo

                    if (vecClientes[0] == txtID.Text) // Preguntamos si el primer elemento del vector (la ID) es igual la ID que estamos cargando
                    {
                        Bandera = true;
                    }
                }
                srClientes.Close();

                if (Bandera == true) // Si la bandera se activa entonces no permite la carga
                {
                    MessageBox.Show("El ID ya se encuentra cargado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter swClientes = new StreamWriter("./clientes.txt", true);
                    swClientes.WriteLine("\n" + txtID.Text + "\u0009" + txtNombre.Text);

                    MessageBox.Show("Datos cargados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    swClientes.Close();

                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtID.Focus();
                }
            
            
            }
            else
            {
                StreamWriter swClientes = new StreamWriter("./clientes.txt", true);
                swClientes.WriteLine("\n" + txtID.Text + "\u0009" + txtNombre.Text);

                MessageBox.Show("Datos cargados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                swClientes.Close();

                txtID.Text = "";
                txtNombre.Text = "";
                txtID.Focus();
            }
        }
    }
}
