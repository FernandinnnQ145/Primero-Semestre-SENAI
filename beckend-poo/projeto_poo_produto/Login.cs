using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_poo_produto
{
    public class Login
    {

        public bool Logado = false;
        string? opcao;
        public Usuario Usuario;
        public Produto Produto;
        public Marca Marca;
        string? opcaoDois;



        public Login()
        {
            Usuario = new Usuario();
            Produto = new Produto();
            Marca = new Marca();
            Logar(Usuario);



        }




        public void Logar(Usuario _usuario)
        {


            do
            {
                Console.Clear();
                Console.WriteLine(@$"
Bem vindo ao sistema de produtos de nossa loja

Voce deseja?
[1] Cadastrar
[2] Ver usuarios
[3] Entrar
[4] Deletar usuario

[0] Sair");
                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        Usuario.Cadastrar();

                        Console.WriteLine($"Aperte enter para voltar");

                        Console.ReadLine();

                        break;



                    case "2":
                        Usuario.Listar();

                        break;




                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Digite seu nome:");
                        string nome = Console.ReadLine()!;
                        Console.WriteLine($"\nDigite sua senha:");
                        string senha = Console.ReadLine()!;
                        if (Usuario.Existe(nome, senha))
                        {

                            Logado = true;

                            GerarMenu();



                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorreto");
                            Console.ResetColor();
                            Console.WriteLine($"Aperte enter para voltar");

                            Console.ReadLine();
                        }


                        break;






                    case "4":
                        Usuario.Remover();






                        break;


                    case "0":
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalida, aperte enter para voltar");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                }



            } while (opcao != "0");


        }










        public void GerarMenu()
        {

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
Escolha a opção desejada
        
[1] Cadastrar produto
[2] Listar produto
[3] Remover produto
        
[4] Cadastrar marca
[5] Listar marca
[6] Remover marca
        
[7] Voltar
[0] Sair");

                opcaoDois = Console.ReadLine()!;

                switch (opcaoDois)
                {
                    case "1":
                        Produto.Cadastrar();
                        break;




                    case "2":
                        Produto.Listar();





                        break;

                    case "3":
                        Produto.RemoverProduto();
                        break;

                    case "4":
                        Marca.Cadastrar();
                        break;

                    case "5":
                        Marca.Listar();
                        break;

                    case "6":
                        Marca.RemoverMarca();
                        break;

                    case "7":
                        Logado = false;
                        break;

                    case "0":
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine($"Opção inválida, aperte enter para voltar");
                        Console.ReadLine();
                        break;
                }



            } while (opcaoDois != "0" && opcaoDois != "7");
        }
    }
}
