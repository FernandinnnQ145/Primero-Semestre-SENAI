int masculino = 0;
int feminino = 0;
int iMasculino = 0;
int iFeminino = 0;

for (int quantidade = 0; quantidade < 10; quantidade++)
{




    Console.WriteLine($"Escreva a sua idade");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"Escreva o seu peso");
    int peso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Escreva seu sexo, m/f");
    char sexo = char.Parse(Console.ReadLine());
    if (sexo != 'f' && sexo != 'm')
    {
        Console.WriteLine($"Resposta invalida, tente outra");
        sexo = char.Parse(Console.ReadLine());

    }
    else if (sexo == 'm'){
        masculino++;
        iMasculino += idade;
    }
    else{
        feminino++;
        iFeminino += idade;
    }
}

Console.WriteLine($"Total de homens é {masculino}");
Console.WriteLine($"Total de feminino é {feminino}");
Console.WriteLine($"Total da media de idades dos homens é {iMasculino / masculino}");
Console.WriteLine($"Total da media de idades das mulheres é {iFeminino / feminino}");





