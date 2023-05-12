using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto_interface
{
    public class Produto
    {



        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // Construtores
        

        public Produto(int _codigo, string _nome, float _preco)
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }

        public Produto()
        {
        }
    }
}
    
