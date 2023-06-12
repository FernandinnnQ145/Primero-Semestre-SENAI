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


        public static List<Produto> ListaDeProduto = new List<Produto>();





        public Produto()
        {
        }

        public Produto(string _codigo, string _nomeDoProduto, float _preco, DateTime _dataDeCadastro, string _marca)
        {
            Codigo = _codigo;
            NomeDoProduto = _nomeDoProduto;
            Preco = _preco;
            DataDeCadastro = _dataDeCadastro;
            Marca = _marca;


        }

        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produto\n");
            Console.WriteLine("Digite o código do produto:");
            string codigo = Console.ReadLine()!;
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Digite o preço do produto:");
            float preco = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a marca do produto:");
            string marca = Console.ReadLine()!;
            DataDeCadastro = DateTime.Now;

            ListaDeProduto.Add(new Produto(codigo, nome, preco, DataDeCadastro, marca));
            Console.WriteLine("\nProduto cadastrado com sucesso! Pressione enter para continuar.");
            Console.ReadLine();
        }

        public void Listar()
        {
            Console.Clear();


            if (ListaDeProduto.Count > 0)
            {
                foreach (Produto prod in ListaDeProduto)
                {
                    Console.WriteLine(@$"
Codigo: {prod.Codigo}
Nome: {prod.NomeDoProduto}
Preço: {prod.Preco}
Data de cadastro: {prod.DataDeCadastro}
Marca: {prod.Marca}");






                }
                Console.WriteLine($"\nAperte enter para voltar");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Não tem nenhum usuario cadastrado");
                Console.ResetColor();
                Console.WriteLine($"\nAperte enter para voltar");

                Console.ReadLine();


            }
        }

        public void RemoverProduto()
        {
            Console.Clear();
            if (ListaDeProduto.Count > 0)
            {

                Console.WriteLine($"Digite o nome do usuario que deseja remover");
                string nomeParaRemover = Console.ReadLine()!;
                Console.WriteLine($"\nDigite a senha do usuario que deseja remover");
                string codigoParaRemover = Console.ReadLine()!;
                Console.Clear();
                if (ListaDeProduto.Exists(x => x.NomeDoProduto == nomeParaRemover && x.Codigo == codigoParaRemover))
                {
                    Produto produtoRemover = ListaDeProduto.Find(x => x.NomeDoProduto == nomeParaRemover && x.Codigo == codigoParaRemover);
                    ListaDeProduto.Remove(produtoRemover);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Removido com sucesso");
                    Console.ResetColor();
                    Console.WriteLine($"Aperte enter para voltar");


                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Usuário não encontrado ou senha incorreta");
                    Console.ResetColor();
                    Console.WriteLine($"Aperte enter para voltar");

                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Programa ja esta sem usuarios");

                Console.WriteLine($"\nAperte enter para remover");
                Console.ReadLine();

            }
        }

    }


}
