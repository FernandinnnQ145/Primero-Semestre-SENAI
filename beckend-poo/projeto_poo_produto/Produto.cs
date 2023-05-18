using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_poo_produto
{
    public class Produto
    {
        public string? Codigo { get; set; }
        public string? NomeDoProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataDeCadastro { get; set; }

        public Marca? marca { get; set; }
        public Usuario? CadastradoPor { get; set; }


        List<Produto> ListaDeProdutos = new List<Produto>();
    }
}