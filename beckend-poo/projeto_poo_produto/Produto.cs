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
        public string? Marca { get; set; }

        public Usuario? CadastradoPor { get; set; }
        public static List<Produto> ListaDeProduto= new List<Produto>();

        public static List<Produto> ListaDeProdutos = new List<Produto>();
        internal object marca;

        public Produto()
        {

        }

        public Produto(string _codigo, string _nomeDoProduto, float _preco, DateTime _dataDeCadastro, string _marca, Usuario _nomeEncontrado)
        {
            Codigo = _codigo;
            NomeDoProduto = _nomeDoProduto;
            Preco = _preco;
            DataDeCadastro = _dataDeCadastro;
            Marca = _marca;
            CadastradoPor = _nomeEncontrado;

        }

        public string Cadastrar(Produto _produto)
        {
            ListaDeProdutos.Add(_produto);
            return "Cadastrado";
        }

        public static List<Produto> Listar()
        {
            return ListaDeProduto;
        }

        // public void Remover(string codigoParaRemover)
        // {
        //     if (ListaDeProdutos.Exists(x => x.Codigo == codigoParaRemover))
        //     {
        //             Usuario usuarioRemover = ListaDeProdutos.Find(x => x.Codigo == codigoParaRemover);
        //     ListaDeProdutos.Remove(produtoRemover); 
        //     Console.Clear();
        //     Console.WriteLine($"Removido com sucesso");
        //     Console.WriteLine($"Aperte enter para voltar");


        //     }
        //     else{
        //         Console.Clear();
        //         Console.WriteLine($"Usuário não encontrado ou senha incorreta");
        //         Console.WriteLine($"Aperte enter para voltar");

        //     }
        

    }


}
