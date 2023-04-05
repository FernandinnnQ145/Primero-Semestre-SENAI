
Console.WriteLine($"Escreva sua idade:");
int idade = int.Parse(Console.ReadLine());

while (idade <= 0 || idade >= 100)
{
    Console.WriteLine($"Idade invalida, digite outra: ");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Idade vaida");
