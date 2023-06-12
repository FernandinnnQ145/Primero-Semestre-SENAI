using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using primeiro_mvc.Model;
namespace primeiro_mvc.View
{
    public class ProdutoView
    {
        // Metodo para exibir os dados da lista no console
        public void Listar(List<Produto> produto){
            foreach (var item in produto)
            {
                Console.WriteLine(@$"
Codigo: {item.Codigo}
Nome : {item.Nome}
Preço: {item.Preco:C}");
                
            }
        }

        public Produto Cadastar(){
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();
            

            Console.WriteLine($"Informe o preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
            
            
        }
    }
}