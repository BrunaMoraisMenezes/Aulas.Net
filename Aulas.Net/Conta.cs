using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    class Conta
    {
        public string Titular { get; set; }
        private decimal Saldo { get; set; }

        public Conta()
        {
        }

        protected decimal exibirSaldo()
        {
            return Saldo;
        }

        internal void Processar(decimal saldo)
        {
            if (Saldo > 0)
            {
                Saldo = saldo;
            }
        }
    }
}
