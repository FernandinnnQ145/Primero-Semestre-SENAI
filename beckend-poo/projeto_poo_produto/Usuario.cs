using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_poo_produto
{
    public class Usuario
    {
                     public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeCadastro { get; set; }

        public static List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario(){
            
        }

        public Usuario(string _codigo, string _nome, string _email, string _senha, DateTime _dataDeCadastro)
        {
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataDeCadastro = _dataDeCadastro;
        }


        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine($"Digite seu código:");
            string Codigo = Console.ReadLine()!;

            Console.WriteLine($"Digite seu nome:");
            string Nome = Console.ReadLine()!;

            Console.WriteLine($"Digite seu email:");
            string Email = Console.ReadLine()!;

            Console.WriteLine($"Digite sua senha:");
            string Senha = Console.ReadLine()!;

            var DataDeCadastro = DateTime.Now;

            Usuario usuario = new Usuario(Codigo, Nome, Email, Senha, DataDeCadastro);

            ListaUsuario.Add(usuario);


        }


        public void Listar()
        {
            Console.Clear();


            if (ListaUsuario.Count > 0)
            {
                foreach (Usuario user in ListaUsuario)
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
        }



        public static bool Existe(string nome, string senha)
        {
            return ListaUsuario.Exists(x => x.Nome == nome && x.Senha == senha);
        }
        public void Remover()
        {
            Console.Clear();
            if (ListaUsuario.Count > 0)
            {

                Console.WriteLine($"Digite o nome do usuario que deseja remover");
                string nomeParaRemover = Console.ReadLine()!;
                Console.WriteLine($"\nDigite a senha do usuario que deseja remover");
                string senhaParaRemover = Console.ReadLine()!;
                Console.Clear();
                if (ListaUsuario.Exists(x => x.Nome == nomeParaRemover && x.Senha == senhaParaRemover))
                {
                    Usuario usuarioRemover = ListaUsuario.Find(x => x.Nome == nomeParaRemover && x.Senha == senhaParaRemover);
                    ListaUsuario.Remove(usuarioRemover);
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