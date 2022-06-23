using System;
using System.Collections.Generic;

namespace Arquivo
{
    public interface IArquivo
    {
        List<string> ListaDiretorios();
        List<Funcionario> ListaFuncionarios();
        void MoverArquivoSucesso(string endereco);
        void MoverArquivoErro(string endereco);
    }
}
