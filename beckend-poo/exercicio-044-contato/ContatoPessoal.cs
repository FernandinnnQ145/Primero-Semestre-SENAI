using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_044_contato
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCpf(string _cpf)
        {
            if(Cpf.Length == 11){
                true;
            }
            else{
                false;
                Console.WriteLine($"CPF invalido");
                
            }
        }
    }
}