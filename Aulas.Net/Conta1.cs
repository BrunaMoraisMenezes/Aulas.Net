using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    public class Conta1
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Transferir(Conta1 conta, decimal valor)
        {
            Saldo -= valor;
            conta.Saldo += valor;
        }

        //public void Transferir(Conta conta, decimal valor)
        //{
        //this.Sacar(valor);
        //conta.Depositar(valor);
        //}

        public override string ToString()
        {
            return ($"A conta {NumeroConta}, da agência {Agencia}, pertencente ao titular {Titular}, possui o saldo de {Saldo:F2}");
        }
    }
}
