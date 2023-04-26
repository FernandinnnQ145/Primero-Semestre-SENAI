using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_041_calculadora
{
    public class calculadora
    {
        public float n1;
        public float n2;

        public float adicao(float n1, float n2){
            return n1+n2;
        }
        public float subtracao(float n1, float n2){
            return n1-n2;
        }
        public float multiplicacao(float n1, float n2){
            return n1*n2;
        }
        public float divisao(float n1, float n2){
            return n1/n2;

            
        }
    }
}