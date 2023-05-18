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

        public Usuario()
        {

        }

        public Usuario(string _codigo, string _nome, string _email, string _senha, DateTime _dataDeCadastro)
        {
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataDeCadastro = _dataDeCadastro;

        }


        public string Cadastrar(Usuario _usuario)
        {
            ListaUsuario.Add(_usuario);
            return "Cadastrado";
        }
        public string Deletar(Usuario _usuario)
        {
            ListaUsuario.Remove(_usuario);
            return "Deletado";
        }

        public static List<Usuario> Listar()
        {
            return ListaUsuario;
        }

        public static bool Existe(string nome, string senha)
        {
            return ListaUsuario.Exists(x => x.Nome == nome && x.Senha == senha);
        }
        public void Remover(string nomeParaRemover, string senhaParaRemover)
        {
            if (ListaUsuario.Exists(x => x.Nome == nomeParaRemover && x.Senha == senhaParaRemover))
            {
                    Usuario usuarioRemover = ListaUsuario.Find(x => x.Nome == nomeParaRemover && x.Senha == senhaParaRemover);
            ListaUsuario.Remove(usuarioRemover); 
            Console.Clear();
            Console.WriteLine($"Removido com sucesso");
            Console.WriteLine($"Aperte enter para voltar");
            
            
            }
            else{
                Console.Clear();
                Console.WriteLine($"Usuário não encontrado ou senha incorreta");
                Console.WriteLine($"Aperte enter para voltar");
                
            }
            
        }
    }
}