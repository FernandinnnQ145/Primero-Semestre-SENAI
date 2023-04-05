
Console.WriteLine($"DIgite s caso for solteiro");

Console.WriteLine($"DIgite c caso for casado");

Console.WriteLine($"DIgite v caso for viuvo");

Console.WriteLine($"DIgite d caso for divorciado");

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