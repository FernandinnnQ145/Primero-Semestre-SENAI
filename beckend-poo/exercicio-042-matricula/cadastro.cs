using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_042_matricula
{
    public class cadastro
    {
        public string nome;
        public string curso;
        public string idade;
        public string rg;
        public bool bolsista;
     
        public float mediaFinal;
        public float valorMensalidade;

        public void verMediaFinal(){
           Console.WriteLine($"{this.mediaFinal}");
           
           
             
         }

         public void verMensalidade(){
            float valor;
            if(this.mediaFinal >=8 && this.bolsista == true){
                valor = this.valorMensalidade/2;
            }
            else if(this.mediaFinal >=6 && this.bolsista == true){
                valor = this.valorMensalidade*0.70f;
            }
            else{
                valor = this.valorMensalidade;
            }
            Console.WriteLine($"O valor da mensalidade é: R${valor}");
            
         }
    }
}