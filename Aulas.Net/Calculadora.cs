using System;

namespace Calculadora
{
    public abstract class Calculadora
    {
        public double Adicao { get; set; }
        public double Subtracao { get; set; }
        public double Multiplicacao { get; set; }
        public double Divisao { get; set; }

        public abstract void Somar();
        public abstract void Subtrair();
        public abstract void Multiplicar();
        public abstract void Dividir();
    }
}
