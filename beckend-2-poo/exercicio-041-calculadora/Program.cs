using exercicio_041_calculadora;

calculadora resultado = new calculadora();

int escolha;

    Console.WriteLine(@$"Digite qual opção voce deseja:
1-soma
2-subtração
3-multiplicação
4-divisão");

    escolha = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"\nDigite o primeiro valor:");
    float n1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine($"Digite o segundo valor:");
    float n2 = float.Parse(Console.ReadLine()!);


    switch (escolha)
    {

        case 1:
        Console.Clear();
            Console.WriteLine($"Seu resultado: {resultado.adicao(n1, n2)}");
               Console.WriteLine($"Aperte enter para encerrar");
        Console.ReadLine();
            break;
        case 2:
        Console.Clear();
            Console.WriteLine($"Seu resultado: {resultado.subtracao(n1, n2)}");
               Console.WriteLine($"Aperte enter para encerrar");
        Console.ReadLine();
            break;
        case 3:
        Console.Clear();
            Console.WriteLine( $"Seu resultado: {resultado.multiplicacao(n1, n2)}");
               Console.WriteLine($"Aperte enter para encerrar");
        Console.ReadLine();
            break;
        case 4:
        Console.Clear();
            Console.WriteLine($"Seu resultado: {resultado.divisao(n1, n2)}");
             Console.WriteLine($"Aperte enter para encerrar");
        Console.ReadLine();
            break;
        
        default:
         Console.Clear();
        Console.WriteLine($"Opção invalida, aperte enter para encerrar");
        Console.ReadLine();
        
        
            break;

    }

