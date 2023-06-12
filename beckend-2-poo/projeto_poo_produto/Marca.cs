using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_poo_produto
{
    public class Marca
    {
        public string? Codigo { get; set; }
        public string? NomeDaMarca { get; set; }

        public DateTime DataDeCadastro { get; set; }



        public static List<Marca> ListaDeMarca = new List<Marca>();





        public Marca()
        {
        }

        public Marca(string _codigo, string _nomeDaMarca, DateTime _dataDeCadastro)
        {
            Codigo = _codigo;
            NomeDaMarca = _nomeDaMarca;

            DataDeCadastro = _dataDeCadastro;



        }

        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de marca\n");
            Console.WriteLine("Digite o código da marca:");
            string codigo = Console.ReadLine()!;
            Console.WriteLine("Digite o nome da marca:");
            string nome = Console.ReadLine()!;

            DataDeCadastro = DateTime.Now;

            ListaDeMarca.Add(new Marca(codigo, nome, DataDeCadastro));
            Console.WriteLine("\nProduto cadastrado com sucesso! Pressione enter para continuar.");
            Console.ReadLine();
        }

        public void Listar()
        {
            Console.Clear();


            if (ListaDeMarca.Count > 0)
            {
                foreach (Marca marc in ListaDeMarca)
                {
                    Console.WriteLine(@$"
Codigo: {marc.Codigo}
Nome: {marc.NomeDaMarca}

Data de cadastro: {marc.DataDeCadastro}");







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

        public void RemoverMarca()
        {
            Console.Clear();
            if (ListaDeMarca.Count > 0)
            {

                Console.WriteLine($"Digite o nome do usuario que deseja remover");
                string nomeParaRemover = Console.ReadLine()!;
                Console.WriteLine($"\nDigite a senha do usuario que deseja remover");
                string codigoParaRemover = Console.ReadLine()!;
                Console.Clear();
                if (ListaDeMarca.Exists(x => x.NomeDaMarca == nomeParaRemover && x.Codigo == codigoParaRemover))
                {
                    Marca marcaRemover = ListaDeMarca.Find(x => x.NomeDaMarca == nomeParaRemover && x.Codigo == codigoParaRemover);
                    ListaDeMarca.Remove(marcaRemover);
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