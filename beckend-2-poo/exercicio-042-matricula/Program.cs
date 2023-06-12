using exercicio_042_matricula;

cadastro informacoes = new cadastro();
int escolha;
string resultadoBolsista;

do
{
    Console.Clear();
    Console.WriteLine(@$"Digite:
    
1-cadastrar aluno
2-informacoes do aluno

0-sair");

    escolha = int.Parse(Console.ReadLine()!);

    switch (escolha)
    {
        case 1:
            Console.Clear();
            Console.WriteLine($"Digite o nome do aluno:");
            informacoes.nome = Console.ReadLine()!;


            Console.WriteLine($"Digite o curso do aluno:");
            informacoes.curso = Console.ReadLine()!;


            Console.WriteLine($"Digite o idade do aluno:");
            informacoes.idade = Console.ReadLine()!;

            Console.WriteLine($"Digite o RG do aluno:");
            informacoes.rg = Console.ReadLine()!;


            Console.WriteLine($"O aluno é bolsista? s/n:");
            string vBolsista = Console.ReadLine()!;
            if (vBolsista == "s")
            {
                informacoes.bolsista = true;
            }
            else
            {
                informacoes.bolsista = false;
            }



            Console.WriteLine($"Digite a media final do aluno:");
            informacoes.mediaFinal = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o valor da mensalidade:");
            informacoes.valorMensalidade = float.Parse(Console.ReadLine()!);
            break;


        case 2:
            Console.Clear();
            Console.WriteLine($"Aluno: {informacoes.nome}");
            Console.WriteLine($"Curso: {informacoes.curso}");
            Console.WriteLine($"Idade: {informacoes.idade}");
            Console.WriteLine($"Rg: {informacoes.rg}");
            resultadoBolsista = informacoes.bolsista == true ? "O aluno é bolsista" : "O aluno não é bolsista";
            Console.WriteLine($"{resultadoBolsista}");
            Console.WriteLine($"");
            Console.WriteLine(@$"Digite:
    1-para ver a media final
    2-Para ver a mensalidade");
            string escolha2 = Console.ReadLine()!;
            switch (escolha2)
            {
                case "1":
                    {
                        Console.Clear();
                        informacoes.verMediaFinal();
                        Console.WriteLine($"Aperte enter para voltar");
                        Console.ReadLine();
                        
                        
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        informacoes.verMensalidade();
                        Console.WriteLine($"Aperte enter para voltar");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Resposta invalida, aperte enter para voltar:");
                    Console.ReadLine();
                    break;
            }
            break;

        case 0:
            Console.Clear();
            System.Environment.Exit(0);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção invalida, aperte enter para voltar");
            break;





    }


} while (escolha != 0);
