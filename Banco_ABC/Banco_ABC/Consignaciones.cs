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
    public partial class Consignas : Form
    {
        public Consignas()
        {
            InitializeComponent();
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizar_Consigna_Click(object sender, EventArgs e)
        {
            double valorConsignacion = Double.Parse(txtbxCantidad_Consignar.Text);
            MessageBox.Show(CuentaAhorros.Consignar(Reg_C_Ahorros.cuentas, txtbxNumCuenta2.Text, valorConsignacion), "Banco_ABC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtbxCantidad_Consignar.Text = "";
            txtbxNumCuenta2.Text = "";
        }

        private void Consignas_Load(object sender, EventArgs e)
        {
            btnRealizar_Consignacion.Enabled = false;
        }

        private void controlBotones()
        {
            if (txtbxNumCuenta2.Text.Trim() != string.Empty && txtbxNumCuenta2.Text.All(char.IsNumber))
            {
                btnRealizar_Consignacion.Enabled = true;
                errorProvider1.SetError(txtbxNumCuenta2, "");
            }
            else
            {
                if (!(txtbxNumCuenta2.Text.All(char.IsNumber)))
                {
                    errorProvider1.SetError(txtbxNumCuenta2, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider1.SetError(txtbxNumCuenta2, "Debe introducir un número de cuenta");
                }
                btnRealizar_Consignacion.Enabled = false;
            }

            if (txtbxCantidad_Consignar.Text.Trim() != string.Empty && txtbxCantidad_Consignar.Text.All(char.IsNumber))
            {
                btnRealizar_Consignacion.Enabled = true;
                errorProvider2.SetError(txtbxCantidad_Consignar, "");
            }
            else
            {
                if (!(txtbxCantidad_Consignar.Text.All(char.IsNumber)))
                {
                    errorProvider2.SetError(txtbxCantidad_Consignar, "El espacio solo debe contener números");
                }
                else
                {
                    errorProvider2.SetError(txtbxCantidad_Consignar, "Debe ingresar la cantidad que desea consignar");
                }
                btnRealizar_Consignacion.Enabled = false;
            }
        }

        private void txtbxNumCuenta2_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void txtbxCantidad_Consignar_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}