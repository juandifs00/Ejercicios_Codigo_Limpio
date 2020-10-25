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
    public partial class Transferencias : Form
    {
        public Transferencias()
        {
            InitializeComponent();
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Transferencias_Load(object sender, EventArgs e)
        {
            btnRealizar_Transferencia.Enabled = false;
        }

        private void controlBotones()
        {
            if (txtbxCuenta_Origen.Text.Trim() != string.Empty && txtbxCuenta_Origen.Text.All(char.IsNumber))
            {
                btnRealizar_Transferencia.Enabled = true;
                errorProvider1.SetError(txtbxCuenta_Origen, "");
            }
            else
            {
                if (!(txtbxCuenta_Origen.Text.All(char.IsNumber)))
                {
                    errorProvider1.SetError(txtbxCuenta_Origen, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider1.SetError(txtbxCuenta_Origen, "Debe introducir un número de cuenta");
                }
                btnRealizar_Transferencia.Enabled = false;
                txtbxCuenta_Origen.Focus();
            }

            if (txtbxCuenta_Destino.Text.Trim() != string.Empty && txtbxCuenta_Destino.Text.All(char.IsNumber))
            {
                btnRealizar_Transferencia.Enabled = true;
                errorProvider2.SetError(txtbxCuenta_Destino, "");
            }
            else
            {
                if (!(txtbxCuenta_Destino.Text.All(char.IsNumber)))
                {
                    errorProvider2.SetError(txtbxCuenta_Destino, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider2.SetError(txtbxCuenta_Destino, "Debe introducir un número de cuenta");
                }
                btnRealizar_Transferencia.Enabled = false;
                txtbxCuenta_Destino.Focus();
            }

            if (txtbxNumCuenta3.Text.Trim() != string.Empty && txtbxNumCuenta3.Text.All(char.IsNumber))
            {
                btnRealizar_Transferencia.Enabled = true;
                errorProvider3.SetError(txtbxNumCuenta3, "");
            }
            else
            {
                if (!(txtbxNumCuenta3.Text.All(char.IsNumber)))
                {
                    errorProvider3.SetError(txtbxNumCuenta3, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider3.SetError(txtbxNumCuenta3, "Debe introducir la cantidad a transferir");
                }
                btnRealizar_Transferencia.Enabled = false;
                txtbxNumCuenta3.Focus();
            }
        }

        private void txtbxCuenta_Origen_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxCuenta_Destino_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxNumCuenta3_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnRealizar_Transferencia_Click(object sender, EventArgs e)
        {
            double valorTransferencia = Double.Parse(txtbxNumCuenta3.Text);
            MessageBox.Show(CuentaAhorros.Transferir(txtbxCuenta_Origen.Text, txtbxCuenta_Destino.Text, valorTransferencia, Reg_C_Ahorros.cuentas), "Banco_ABC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtbxNumCuenta3.Text = "";
            txtbxCuenta_Origen.Text = "";
            txtbxCuenta_Destino.Text = "";
        }
    }
}
