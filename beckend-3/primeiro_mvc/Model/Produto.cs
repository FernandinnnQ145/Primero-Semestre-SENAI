using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using primeiro_mvc.View;

namespace primeiro_mvc.Model
{
    public class Produto
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }


        private const string PATH = "database/Produto.csv";
        public Produto()
        {
            // Criar a logica para gerar a pasta e o arquivo

            // Obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            // Verificar se no caminho ja existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Verificar se no caminho ja existe um arquivo 
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }
        
        public List<Produto> Ler(){
            List<Produto> produtos = new List<Produto>();

        string[] linhas = File.ReadAllLines(PATH);
        
        foreach (var item in linhas)
        {
                                // item retira ; ou seja a cada ";" entra o proximo array
            string[] atributos = item.Split(";");

            Produto p = new Produto();

            p.Codigo = int.Parse(atributos[0]);
            p.Nome = atributos[1];
            p.Preco = float.Parse(atributos[2]);

            produtos.Add(p);
        }


            return produtos;
        }

        // Metodo para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCSV(Produto p){
            return $"{p.Codigo};{p.Nome};{p.Preco:C}";
            // Exemplo      1020;Coca;6,50
        }

        // Metodo para inserir um produto na linha do csv
        public void Inserir(Produto p){
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }

      
    }
}