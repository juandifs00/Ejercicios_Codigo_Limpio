using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_ABC
{
    public partial class Retiros : Form
    {
        public Retiros()
        {
            InitializeComponent();
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizar_Retiro_Click(object sender, EventArgs e)
        {
            double valorRetiro = Double.Parse(txtbxCantidad_Retirar.Text);
            MessageBox.Show(CuentaAhorros.Retirar(txtbxNumCuenta3.Text, valorRetiro, Reg_C_Ahorros.cuentas), "Banco_ABC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtbxNumCuenta3.Text = "";
            txtbxCantidad_Retirar.Text = "";
        }

        private void controlBotones()
        {
            if (txtbxNumCuenta3.Text.Trim() != string.Empty && txtbxNumCuenta3.Text.All(char.IsNumber))
            {
                btnRealizar_Retiro.Enabled = true;
                errorProvider1.SetError(txtbxNumCuenta3, "");
            }
            else
            {
                if (!(txtbxNumCuenta3.Text.All(char.IsNumber)))
                {
                    errorProvider1.SetError(txtbxNumCuenta3, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider1.SetError(txtbxNumCuenta3, "Debe introducir un número de cuenta");
                }
                btnRealizar_Retiro.Enabled = false;
            }

            if (txtbxCantidad_Retirar.Text.Trim() != string.Empty && txtbxCantidad_Retirar.Text.All(char.IsNumber))
            {
                btnRealizar_Retiro.Enabled = true;
                errorProvider2.SetError(txtbxCantidad_Retirar, "");
            }
            else
            {
                if (!(txtbxCantidad_Retirar.Text.All(char.IsNumber)))
                {
                    errorProvider2.SetError(txtbxCantidad_Retirar, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider2.SetError(txtbxCantidad_Retirar, "Debe introducir una cantidad a retirar");
                }
                btnRealizar_Retiro.Enabled = false;
            }
        }

        private void txtbxNumCuenta3_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxCantidad_Retirar_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void Retiros_Load(object sender, EventArgs e)
        {
            btnRealizar_Retiro.Enabled = false;
        }
    }
}
