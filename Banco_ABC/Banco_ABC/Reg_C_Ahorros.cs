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
    public partial class Reg_C_Ahorros : Form
    {
        static public List<CuentaAhorros> cuentas = new List<CuentaAhorros>();
        public Reg_C_Ahorros()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConf_Registro_Click(object sender, EventArgs e)
        {
            double saldo = Double.Parse(txtbxSaldo.Text);
            if (saldo >= 2000000)
            {
                saldo = saldo + (saldo * 0.05);
            }
            cuentas.Add(new CuentaAhorros(txtbxNumCuenta.Text, txtbxNomTitular.Text, txtbxNumDocumento.Text, saldo));
            MessageBox.Show("Registro creado exitosamente", "Banco_ABC",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtbxNumCuenta.Text = "";
            txtbxNomTitular.Text = "";
            txtbxNumDocumento.Text = "";
            txtbxSaldo.Text = "";
            MessageBox.Show("pausa", "Banco_ABC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void controlBotones()
        {
            if (txtbxNumCuenta.Text.Trim() != string.Empty && txtbxNumCuenta.Text.All(char.IsNumber))
            {
                btnConf_Registro.Enabled = true;
                errorProvider1.SetError(txtbxNumCuenta, "");
            }
            else
            {
                if (!(txtbxNumCuenta.Text.All(char.IsNumber)))
                {
                    errorProvider1.SetError(txtbxNumCuenta, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider1.SetError(txtbxNumCuenta, "Debe introducir un número de cuenta");
                }
                btnConf_Registro.Enabled = false;
                txtbxNumCuenta.Focus();
            }

            if (txtbxNomTitular.Text.Trim() != string.Empty && txtbxNomTitular.Text.All(char.IsLetter))
            {
                btnConf_Registro.Enabled = true;
                errorProvider2.SetError(txtbxNomTitular, "");
            }
            else
            {
                if (!(txtbxNomTitular.Text.All(char.IsLetter)))
                {
                    errorProvider2.SetError(txtbxNomTitular, "El espacio solo debe contener letras");
                }
                else
                {
                    errorProvider2.SetError(txtbxNomTitular, "Debe introducir un nombre");
                }
                btnConf_Registro.Enabled = false;
                txtbxNomTitular.Focus();
            }
            
            if (txtbxNumDocumento.Text.Trim() != string.Empty && txtbxNumDocumento.Text.All(char.IsNumber))
            {
                btnConf_Registro.Enabled = true;
                errorProvider3.SetError(txtbxNumDocumento, "");
            }
            else
            {
                if (!(txtbxNumDocumento.Text.All(char.IsNumber)))
                {
                    errorProvider3.SetError(txtbxNumDocumento, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider3.SetError(txtbxNumDocumento, "Debe introducir un número de documento");
                }
                btnConf_Registro.Enabled = false;
                txtbxNumDocumento.Focus();
            }

            if (txtbxSaldo.Text.Trim() != string.Empty && txtbxSaldo.Text.All(char.IsNumber))
            {
                btnConf_Registro.Enabled = true;
                errorProvider4.SetError(txtbxSaldo, "");
            }
            else
            {
                if (!(txtbxSaldo.Text.All(char.IsNumber)))
                {
                    errorProvider4.SetError(txtbxSaldo, "El espacio solo debe contener números");
                }
                btnConf_Registro.Enabled = false;
                txtbxSaldo.Focus();
            }
        }

        private void Reg_C_Ahorros_Load(object sender, EventArgs e)
        {
            btnConf_Registro.Enabled = false;
        }

        private void txtbxNumCuenta_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxNomTitular_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxNumDocumento_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxSaldo_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
