using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_002_mvc.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }

        private const string PATH = "database/Evento.csv";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];


            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

            
        }

         public List<Evento> Ler(){
            List<Evento> produtos = new List<Evento>();

        string[] linhas = File.ReadAllLines(PATH);
        
        foreach (var item in linhas)
        {
                                // item retira ; ou seja a cada ";" entra o proximo array
            string[] atributos = item.Split(";");

            Evento e = new Evento();

            e.Nome = atributos[0];
            e.Descricao = atributos[1];
            e.Data = atributos[2];

            produtos.Add(e);
        }


            return produtos;
        }

        // Metodo para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCSV(Evento e){
            return $"{e.Nome};{e.Descricao};{e.Data}";
            // Exemplo      1020;Coca;6,50
        }

        // Metodo para inserir um produto na linha do csv
        public void Inserir(Evento e){
            string[] linhas = {PrepararLinhasCSV(e)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}