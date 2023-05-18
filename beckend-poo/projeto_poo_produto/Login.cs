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


        public Login()
        {
            Usuario = new Usuario();
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

                        string resultado = usuario.Cadastrar(usuario);







                        break;



                    case "2":
                        Console.Clear();

                        List<Usuario> ListaUsuarios = Usuario.Listar();
                        if (ListaUsuarios.Count > 0)
                        {
                            foreach (Usuario u in ListaUsuarios)
                            {
                                Console.WriteLine(@$"
          Codigo: {u.Codigo}
          Nome: {u.Nome}
          Email: {u.Email}
          Data de cadastro: {u.DataDeCadastro}");






                            }
                            Console.WriteLine($"\nAperte enter para voltar");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(@$"
                          Não tem nenhum usuario cadastrado
                          Aperte enter para voltar");
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
                            Logado = true;
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
                        Console.WriteLine($"Digite o nome do usuario que deseja remover");
                        string nomeParaRemover = Console.ReadLine()!;
                        Console.WriteLine($"\nDigite a senha do usuario que deseja remover");
                        string senhaParaRemover = Console.ReadLine()!;
                        Console.Clear();
                        Usuario.Remover(nomeParaRemover, senhaParaRemover);
                        Console.ReadLine();





                        break;


                    case "0":
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;

                }

            } while (Logado != true);


        }








    public void GerarMenu(){
        
    }
    }
}