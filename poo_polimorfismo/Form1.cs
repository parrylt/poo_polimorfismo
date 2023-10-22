using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_polimorfismo
{
    public partial class Form1 : Form
    {
        ContaEspecial ce = new ContaEspecial();
        ContaPoupanca cp = new ContaPoupanca();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (btnContaEspecial.Checked)
            {
                ce.creditar(Convert.ToDouble(txtValor.Text));
                lblSaldoCE.Text = Convert.ToString(ce.Saldo);
            }
            else
            {
                cp.creditar(Convert.ToDouble(txtValor.Text));
                lblSaldoCP.Text = Convert.ToString(cp.Saldo);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (btnContaEspecial.Checked)
            {
                ce.debitar(Convert.ToDouble(txtValor.Text));
                lblSaldoCE.Text = Convert.ToString(ce.Saldo);
            }
            else
            {
                cp.debitar(Convert.ToDouble(txtValor.Text));
                lblSaldoCP.Text = Convert.ToString(cp.Saldo);
            }
        }
    }
}
