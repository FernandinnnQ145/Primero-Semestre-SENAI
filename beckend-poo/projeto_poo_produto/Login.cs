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
        Usuario nomeEncontrado = null;


        public Login()
        {
            Usuario = new Usuario();
            Logar(Usuario);

            if (Logado == true)
            {
                GerarMenu();
            }
        }




        public void Logar(Usuario _usuario)
        {

            List<Usuario> ListaUsuarios = new List<Usuario>();
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
                        Console.Clear();
                        Console.WriteLine($"Digite seu codigo:");
                        string Codigo = Console.ReadLine()!;

                        Console.WriteLine($"Digite seu nome:");
                        string Nome = Console.ReadLine()!;

                        Console.WriteLine($"Digite seu email:");
                        string Email = Console.ReadLine()!;

                        Console.WriteLine($"Digite sua senha:");
                        string Senha = Console.ReadLine()!;

                        var DataDeCadastro = DateTime.Now;

                        Usuario usuario = new Usuario(Codigo, Nome, Email, Senha, DataDeCadastro);

                        string casdastrado = usuario.Cadastrar(usuario);







                        break;



                    case "2":
                        Console.Clear();

                        
                        if (ListaUsuarios.Count > 0)
                        {
                            foreach (Usuario user in ListaUsuarios)
                            {
                                Console.WriteLine(@$"
          Codigo: {user.Codigo}
          Nome: {user.Nome}
          Email: {user.Email}
          Data de cadastro: {user.DataDeCadastro}");






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

                        break;




                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Digite seu nome:");
                        string nome = Console.ReadLine()!;
                        Console.WriteLine($"\nDigite sua senha:");
                        string senha = Console.ReadLine()!;
                        if (Usuario.Existe(nome, senha))
                        {
                            nomeEncontrado = ListaUsuarios.Find(u => u.Nome == nome);
                            Logado = true;
                            GerarMenu();

                        }
                        else
                        {
                            Console.WriteLine("Incorreto");
                            Console.WriteLine($"Aperte enter para voltar");

                            Console.ReadLine();
                        }


                        break;






                    case "4":
                        Console.Clear();
                        if (ListaUsuarios.Count > 0)
                        {

                            Console.WriteLine($"Digite o nome do usuario que deseja remover");
                            string nomeParaRemover = Console.ReadLine()!;
                            Console.WriteLine($"\nDigite a senha do usuario que deseja remover");
                            string senhaParaRemover = Console.ReadLine()!;
                            Console.Clear();
                            Usuario.Remover(nomeParaRemover, senhaParaRemover);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"Programa ja esta sem usuarios");

                            Console.WriteLine($"\nAperte enter para remover");
                            Console.ReadLine();



                        }






                        break;


                    case "0":
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;

                }

            } while (Logado != true);


        }






        string opcaoDois;

        public void GerarMenu()
        {
            List<Usuario> ListaUsuarios = new List<Usuario>();
            List<Produto> ListaDeProdutos = new List<Produto>();
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
                        Console.Clear();
                        Console.WriteLine($"Digite o codigo do produto:");
                        string Codigo = Console.ReadLine()!;

                        Console.WriteLine($"\nDigite o nome do produto:");
                        string NomeDoProduto = Console.ReadLine()!;

                        Console.WriteLine($"\nDigite o preço do produto:");
                        float Preco = float.Parse(Console.ReadLine()!)!;

                        
                        Console.WriteLine($"Digite a marca do produto:");
                        string marca = Console.ReadLine()!;

                        var DataDeCadastro = DateTime.Now;








                        Produto produto = new Produto(Codigo, NomeDoProduto, Preco, DataDeCadastro, marca, nomeEncontrado);

                        string ProdutoCadastrado = produto.Cadastrar(produto);
                        break;




                    case "2":
                        Console.Clear();


                        if (ListaDeProdutos.Count > 0)
                        {
                            foreach (Produto prod in ListaDeProdutos)
                            {
                                Console.WriteLine(@$"
          Codigo: {prod.Codigo}
          Nome: {prod.NomeDoProduto}
          Preço: {prod.Preco}
          Marca: {prod.marca}
          Data de cadastro: {prod.DataDeCadastro}
        ");
          






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

                        break;




                }

            } while (opcaoDois != "0");
        }
    }
}
