using System;

namespace Generics
{
    class Carro : IComparable
    {
        public string Placa { get; set; }
        public double KmInicial { get; set; }
        public double KmFinal { get; set; }

        public Carro(string placa, double kmInicial, double kmFinal)
        {
            Placa = placa;
            KmInicial = kmInicial;
            KmFinal = kmFinal;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Carro))
            {
                throw new ArgumentException("Entrada inválida");
            }
            KmFinal -= KmInicial;
            Carro other = obj as Carro;
            return KmFinal.CompareTo(other.KmFinal);
        }
        public override string ToString()
        {
            return $"Placa: {Placa}, Quantidade de KM rodados: {KmFinal} km";
        }
    }
}
