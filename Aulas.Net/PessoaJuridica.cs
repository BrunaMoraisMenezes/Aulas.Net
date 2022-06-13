using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class PessoaJuridica : Cliente
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
