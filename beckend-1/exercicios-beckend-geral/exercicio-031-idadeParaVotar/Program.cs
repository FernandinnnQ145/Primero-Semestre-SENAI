Console.WriteLine($"Digite o ano em que nasceu");
int ano = int.Parse(Console.ReadLine());

if (ano >= 2008)
{
    Console.WriteLine($"Voce nao pode votar");

}
else if ((ano >= 2005) && (ano <= 2007))
{
    Console.WriteLine($"Voce tem a opção de votar");

}
else
{
    Console.WriteLine($"VOce é obrigado a votar");

}

