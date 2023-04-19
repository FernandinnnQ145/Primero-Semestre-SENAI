
string[] nome = new string[6];
float[] preco = new float[6];
char[] promocao = new char[6];
bool[] valorPromocao = new bool[6];
string opcao;
do

{
    static void menu()
    {
        Console.WriteLine(@$"Voce deseja:
            ------------------------------       
           |   1-Cadastrar produtos       |
           |                              |
           |  2-ver a lista dos produtos  |
            ------------------------------



0-sair");
    }
    Console.Clear();
    { menu(); }

    opcao = Console.ReadLine()!;
    Console.Clear();
    switch (opcao)
    {

        case "1":
            for (int i = 0; i < 6; i++)
            {
                Console.Clear();
                Console.WriteLine($"Digite o nome do produto");
                nome[i] = Console.ReadLine()!;
                Console.WriteLine($"Digite o valor do produto");
                preco[i] = float.Parse(Console.ReadLine()!);
                Console.WriteLine($"O produto esta em promoção? s/n");

                promocao[i] = char.Parse(Console.ReadLine()!.ToLower());
                while (promocao[i] != 's' && promocao[i] != 'n')
                {
                    Console.WriteLine($"Opção invalida, tente outra:");
                    promocao[i] = char.Parse(Console.ReadLine()!.ToLower());

                }
            }
            Console.WriteLine($"\nAperte enter para voltar");
            Console.ReadLine();

            break;
        case "2":
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (i == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                if (i == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }


                Console.WriteLine($"");

                Console.WriteLine($"O nome do {i + 1}º produto: {nome[i]}");
                Console.WriteLine($"O valor do {i + 1}º produto: {preco[i]}");
                if (promocao[i] == 's')
                {
                    valorPromocao[i] = true;
                }
                else
                {
                    valorPromocao[i] = false;
                }
                Console.WriteLine($"O {i + 1}º produto esta com desconto: {valorPromocao[i]}");

                Console.ResetColor();


            }
            Console.WriteLine($"\nAperte enter para voltar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            System.Environment.Exit(0);
            break;

        default:
            { menu(); }
            break;

    }
} while (opcao != "0");


