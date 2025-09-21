using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAstudilloSp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CalcularContraseña();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";

            txtContraseña.Text = "";

            cmbMódulo.SelectedIndex = -1;

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
            }
            else
            {
                txtContraseña.Enabled = true;

            }

        }

        private void CalcularContraseña()
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string modulo = cmbMódulo.SelectedItem.ToString();
            int intentosFallidos = 0;

            bool acceso = false;

            if (usuario == "adm" && contraseña == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
            {
                acceso = true;
            }
            else if (usuario == "John" && contraseña == "*2b" && modulo == "SIST")
            {
                acceso = true;
            }
            else if (usuario == "Ceci" && contraseña == "@3c" && (modulo == "VTA" || modulo == "ADM"))
            {
                acceso = true;
            }
            else if (usuario == "God" && contraseña == "*@#4d")
            {
                acceso = true;
            }

            if (acceso)
            {
                intentosFallidos = 0;
                this.Hide();
                frmInicio frmInicio = new frmInicio();
                frmInicio.ShowDialog();
                this.Show();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");

                if (intentosFallidos >= 2)
                {
                    this.Close();
                }
            }
        }
    }
}

