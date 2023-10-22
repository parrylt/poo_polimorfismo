using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_polimorfismo
{
    public class conta
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public virtual void creditar (double valor)
        {
            Saldo += valor;
        }

        public virtual void debitar (double valor)
        {
            Saldo -= valor;
        }
    }

    public class ContaEspecial : conta
    {
        public override void debitar (double valor)
        {
            if (Saldo <= 0)
            {
                Saldo -= (0.01 * valor) + valor;
            }
            else
            {
                Saldo -= valor;
            }
        }
    }

    public class ContaPoupanca: conta
    {
        public override void creditar (double valor)
        {
            Saldo += (0.05 * valor) + valor;
        }

        public override void debitar (double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }
    }
}
