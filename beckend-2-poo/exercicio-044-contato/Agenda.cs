using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_044_contato
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Listar()
        {
            throw new NotImplementedException();
        }



       public void IAgenda.Adicionar(Contato _contato)
        {
            contatos.Add(_contato);
        }


    }
}