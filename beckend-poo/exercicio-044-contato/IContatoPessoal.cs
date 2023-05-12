using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_044_contato
{
    public interface IContatoPessoal
    {
        bool ValidarCpf(string _cpf);
    }
}