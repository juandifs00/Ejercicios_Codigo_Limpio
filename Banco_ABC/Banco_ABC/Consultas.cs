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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValor_total_consignas_Click(object sender, EventArgs e)
        {
            txtbxTotal_Consignas.Text = CuentaAhorros.totalConsignaciones.ToString();
        }

        private void btnTotal_Retiros_Click(object sender, EventArgs e)
        {
            txtbxTotal_Retiros.Text = CuentaAhorros.totalRetiros.ToString();
        }

        private void btnTotal_Operaciones_Click(object sender, EventArgs e)
        {
            txtbxTotal_Operaciones.Text = CuentaAhorros.totalTransacciones.ToString();
        }

        private void btnCliente_mayor_Consigna_Click(object sender, EventArgs e)
        {
            txtbxCliente_Mayor_Consigna.Text = CuentaAhorros.clienteMayorConsignacion;
        }
    }
}
