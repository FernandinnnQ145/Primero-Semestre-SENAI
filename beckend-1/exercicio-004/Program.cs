
/*Console.WriteLine($"Digite quantos kg de arroz voce quer:");

float kg = float.Parse(Console.ReadLine());
float valor;

// Valor do kg pre-definido

valor = kg * 6;

Console.WriteLine($"O valor a ser pago sera R$ {valor}");
*/









// valor banana 4 reais ameixa 3 e laranja 7

Console.WriteLine($"Digite 1 se voce deseja comprar banana (4 reais por kg)");
Console.WriteLine($"Digite 2 se voce deseja comprar ameixa (3 reais por kg)");
Console.WriteLine($"Digite 3 se voce deseja comprar laranja (7 reais o kg)");

int escolha = int.Parse(Console.ReadLine());
float kg, valor;
switch (escolha)
{
    case 1:
        Console.WriteLine($"Digite quantos kg de banana deseja comprar:");
        kg = float.Parse(Console.ReadLine());
        valor = kg *4;

        Console.WriteLine($"Voce deve pagar R${valor}");
        
        break;


    case 2:
        Console.WriteLine($"Digite quantos kg de ameixa deseja comprar:");
        kg = float.Parse(Console.ReadLine());
        valor = kg *4;
        Console.WriteLine($"Voce deve pagar R${valor}");
        break;


    case 3:
        Console.WriteLine($"Digite quantos kg de laranja deseja comprar:");
        kg = float.Parse(Console.ReadLine());
        valor = kg *4;
        Console.WriteLine($"Voce deve pagar R${valor}");
        break;


    default:
        Console.WriteLine($"Não temos essa opção");
        break;
    
}







