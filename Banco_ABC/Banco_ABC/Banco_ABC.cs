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

    public partial class Banco_ABC : Form
    {
        public Banco_ABC()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_nueva_cuenta_Click(object sender, EventArgs e)
        {
            using (Reg_C_Ahorros ventanaR_C_Ahorros = new Reg_C_Ahorros())
                ventanaR_C_Ahorros.ShowDialog();
        }

        private void btmRealizarConsginación_Click(object sender, EventArgs e)
        {
            using (Consignas ventanaConsignaciones = new Consignas())
                ventanaConsignaciones.ShowDialog();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            using (Retiros ventanaRetiros = new Retiros())
                ventanaRetiros.ShowDialog();
        }

        private void btnTansferir_Click(object sender, EventArgs e)
        {
            using (Transferencias ventanaTrasnferencias = new Transferencias())
                ventanaTrasnferencias.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            using (Consultas ventanaConsultas = new Consultas())
                ventanaConsultas.ShowDialog();
        }

        private void Banco_ABC_Load(object sender, EventArgs e)
        {

        }
    }
}
