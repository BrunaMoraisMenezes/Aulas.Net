using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public string Cargo { get; private set; }
        public decimal Salario { get; private set; }

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public Funcionario(string nome, string cpf) : this(nome)
        {
            CPF = cpf;
        }

        public Funcionario(string nome, string cpf, decimal salario) : this(nome, cpf)
        {
            Salario = salario;
        }

        public Funcionario(string nome, string cpf, string cargo, decimal salario) : this(nome, cpf, salario)
        {
            Cargo = cargo;
        }
        public decimal GetSalario()
        {
            return Salario;
        }
        private void SetSalario(decimal salario)
        {
            if (salario <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Salario = salario;
            }
        }

        public decimal Comissao()
        {
            return Salario += 1000;
        }

        public override string ToString()
        {
            return $"O funcionário {Nome}, cujo CPF é {CPF}, trabalha como {Cargo} e o salário com comissão resulta em {Comissao():F2}";
        }
    }
}
