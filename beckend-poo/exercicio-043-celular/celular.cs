using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_043_celular
{
    public class celular
    {
              public string cor = "preto";
        public string modelo = "iphone";
        public string tamanho = "15cm";
        public bool ligado;
        public string enviarMensagem = null;

         public void ligar(){
    
   }

    public void desligar()
    {
        Console.Clear();
        Console.WriteLine($"Samsung");
        Thread.Sleep(10000);
        ligado = false;
    }

    public void mensagem()
    {

        Console.WriteLine($"Escreva sua mensagem:");
        enviarMensagem = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Mensagem enviada, aperte enter para voltar");
        Console.ReadLine();








    }

    public void ligacao()
    {
        Console.WriteLine($"Ligando...");
        Thread.Sleep(10000);
        Console.WriteLine($"Ninguem atendeu, aperte enter para voltar");
        Console.ReadLine();



    }

  


    }
    }
