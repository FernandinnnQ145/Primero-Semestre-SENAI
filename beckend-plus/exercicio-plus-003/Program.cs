
Console.WriteLine($"Telefonou para vitima? Sim ou nao");
string resposta1 = Console.ReadLine();


Console.WriteLine($"Esteve no local do crime? Sim ou nao");
string resposta2 = Console.ReadLine();


Console.WriteLine($"Mora perto da vítima? Sim ou nao");
string resposta3 = Console.ReadLine();


Console.WriteLine($"Devia para a vítima? Sim ou nao");
string resposta4 = Console.ReadLine();


Console.WriteLine($"Já trabalhou com a vítima? Sim ou nao");
string resposta5 = Console.ReadLine();


Console.WriteLine($"Quantos vezes voce colocou sim, digite em numeros");

int quantosValores = int.Parse(Console.ReadLine());
switch (quantosValores){
    case 0:
    Console.WriteLine($"Inocente");
    break;
    case 1:
    Console.WriteLine($"Inocente");
    break;
    case 2:
    Console.WriteLine($"Suspeito");
    break;
    case 3:
    Console.WriteLine($"Cumplice");
    break;
    case 4:
    Console.WriteLine($"Cumplice");
    break;
    case 5:
    Console.WriteLine($"Culpado");
    break;
    default:
    Console.WriteLine($"Temos apenas 5 opções");
    break;
    

}


