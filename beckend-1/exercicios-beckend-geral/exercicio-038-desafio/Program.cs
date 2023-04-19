// função para voltar
static void volta()
{
    Console.WriteLine($"\n");

    Console.WriteLine($"Aperte enter para voltar");
    Console.ReadLine();
    Console.Clear();
    opcoes();
}

// função para exercicio concluido
static void concluido()
{
    Console.Clear();
    Console.WriteLine($"Exercicio concluido, aperte enter para continuar");
    Console.ReadLine();

    Console.Clear();
}

// função para exercicio em andamento
static void andamento()
{
    Console.Clear();
    Console.WriteLine($"Exercicio em andamento, aperte qualquer tecla para voltar");
    Console.ReadKey();

    Console.Clear();
    opcoes();
}


// função principal e para as opções
static void opcoes()
{
    Console.WriteLine(@$"Escolha qual exercicio deseja ver:
1-Exercicio idade para votar
2-exercicio posto
3-exercicio desconto
4-exercicio menor e maior
5-exercicio tabuada
6-exercicio busca
7-exercicio ordem
8-Apenas um exemplo de exercicio não concluido

0-para sair");

    int escolha = int.Parse(Console.ReadLine());




    switch (escolha)
    {
        // exercicio 1
        case 1:
            concluido();
            Console.WriteLine($"Digite o ano em que nasceu:");
            int ano = int.Parse(Console.ReadLine());

            if (ano >= 2008)
            {
                Console.WriteLine($"Voce nao pode votar");

            }
            else if ((ano >= 2005) && (ano <= 2007))
            {
                Console.WriteLine($"Voce tem a opção de votar");

            }
            else
            {
                Console.WriteLine($"Voce é obrigado a votar");

            }
            volta();


            break;









        // exercicio 2
        case 2:
            concluido();
            static float alcool(float litros)
            {

                if (litros <= 20)
                {
                    float r = (litros * 4.90f) * 0.97f;
                    return r;
                }
                else
                {
                    float r = (litros * 4.90f) * 0.95f;
                    return r;
                }
            }


            static float gasolina(float litros)
            {
                if (litros <= 20)
                {
                    float r = (litros * 5.30f) * 0.96f;
                    return r;
                }
                else
                {
                    float r = (litros * 5.30f) * 0.94f;
                    return r;
                }

            }
            char escolha1;
            do
            {
                Console.WriteLine(@$"Selecione qual tipo de combustivel voce deseja:
a-alcool 
g-gasolina");
                escolha1 = char.Parse(Console.ReadLine().ToLower());


                switch (escolha1)
                {
                    case 'a':
                        Console.WriteLine($"\nQuantos litros voce deseja?");
                        float litros = float.Parse(Console.ReadLine());
                        Console.WriteLine($"\nVoce devera pagar R${alcool(litros)}");
                        break;


                    case 'g':
                        Console.WriteLine($"\nQuantos litros voce deseja?");
                        litros = float.Parse(Console.ReadLine());
                        Console.WriteLine($"\nVoce devera pagar R${gasolina(litros)}");
                        break;
                    default:
                        Console.WriteLine($"Resposta invalida, tente outra:");
                        escolha1 = char.Parse(Console.ReadLine().ToLower());
                        break;
                }






            } while ((escolha1 != 'a' && escolha1 != 'g'));

            volta();
            break;






        // exercicio 3
        case 3:
            concluido();
            Console.WriteLine($"Digite o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade do produto");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o preço do produto");
            float preco = float.Parse(Console.ReadLine());

            float valor = quantidade * preco;
            float desconto;
            if (quantidade <= 5)
            {
                desconto = valor - ((2 / 100f) * valor);
            }


            else if (quantidade > 5 && quantidade <= 10)
            {
                desconto = valor - ((3 / 100f) * valor);
                Console.WriteLine($"Voce pagara R${desconto} pelo {nome}");
            }
            else
            {
                desconto = valor - ((5 / 100f) * valor);
                Console.WriteLine($"Voce pagara R${desconto} pelo {nome}");
            }


            volta();
            break;









        // exercicio 4
        case 4:
            concluido();
            int[] numerosExercicio4 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor");
                numerosExercicio4[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(@$"O seu maior valor é o {numerosExercicio4.Max()}
            O seu menor valor é o {numerosExercicio4.Min()}");

            volta();
            break;













        // exercicio 5
        case 5:
            concluido();
            int resultado;
            Console.WriteLine($"Aqui esta a tabuada de 1 a 10");

            for (int pMultiplicador = 0; pMultiplicador <= 10; pMultiplicador++)
            {
                for (int sMultiplicador = 0; sMultiplicador <= 10; sMultiplicador++)
                {


                    resultado = sMultiplicador * pMultiplicador;
                    Console.WriteLine($"{pMultiplicador}x{sMultiplicador} = {resultado}");
                }
            }


            volta();
            break;





















        // exercicio 6
        case 6:
            concluido();
            string[] nomes = new string[10];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º nome:");
                nomes[i] = Console.ReadLine().ToLower();


            }

            Console.WriteLine($"Digite um nome para conferir se ele esta na lista:");
            string bNome = Console.ReadLine();

            // if (nomes.Contains(bNome))
            // {
            //     Console.WriteLine($"Achei :)");

            // }
            // else
            // {
            //     Console.WriteLine($"Nao achei :(");

            // }
            string resultadoBusca = nomes.Contains(bNome)? "\nAchei :)":"\nNão achei :(";
            Console.WriteLine($"{resultadoBusca}");
            
            volta();

            break;




        // exercicio 7
        case 7:
            concluido();
            int[] numeros = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Entre com o {i + 1}º numero");

                numeros[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Agora a ordem inversa:");


            for (int i = 14; i > 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");

            }

            volta();
            break;










        // exemplo de exercicio em andamento
        case 8:
            andamento();
            break;




        // para encerrar o programa
        case 0:
            Console.Clear();
            System.Environment.Exit(0);
            break;














        default:

            Console.Clear();
            opcoes();
            break;


    }
}
{
    opcoes();
}




