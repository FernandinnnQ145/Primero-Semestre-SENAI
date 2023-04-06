

for (int quantidade = 0; quantidade < 10; quantidade++)
{




    Console.WriteLine($"Escreva a sua idade");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"Escreva o seu peso");
    int peso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Escreva seu sexo, m/f");
    int sexo = int.Parse(Console.ReadLine());
    if (sexo != 'f' && sexo != 'm')
    {
        Console.WriteLine($"Resposta invalida, tente outra");

    }
    
}




