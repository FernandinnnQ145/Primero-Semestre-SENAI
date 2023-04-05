
Console.WriteLine($"Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a)");


char resposta = char.Parse(Console.ReadLine());

while (resposta != 's' && resposta != 'c' && resposta != 'v' && resposta != 'd')
{
    Console.WriteLine($"Resposta invalida, tente outra: ");
    resposta = char.Parse(Console.ReadLine());


}
if (resposta == 's')
{
    Console.WriteLine($"Voce é solteiro");

}
else if (resposta == 'c')
{
    Console.WriteLine($"Voce é casado");

}
else if (resposta == 'v')
{
    Console.WriteLine($"Voce é viuvo");

}
else
{
    Console.WriteLine($"Voce é divorciado");

}




