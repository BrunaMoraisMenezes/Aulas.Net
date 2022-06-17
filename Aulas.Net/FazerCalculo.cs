using System;

namespace Calculadora
{
    public class FazerCalculo : Calculadora
    {
        public double PrimeiroValor { get; set; }
        public double SegundoValor { get; set; }

        public override void Somar() 
        { 
            this.Adicao = PrimeiroValor + SegundoValor; 
        }
        public override void Subtrair()
        {
            this.Subtracao = PrimeiroValor - SegundoValor;
        }
        public override void Multiplicar()
        {
            this.Multiplicacao = PrimeiroValor * SegundoValor;
        }
        public override void Dividir()
        {
            this.Divisao = PrimeiroValor / SegundoValor;
        }
    }
}