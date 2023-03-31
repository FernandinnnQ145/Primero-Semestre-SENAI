
Console.WriteLine($"digite em numeros o dia em que voce nasceu");
int dia = int.Parse(Console.ReadLine());


Console.WriteLine($"digite em numeros o mes em que voce nasceu");
int mes = int.Parse(Console.ReadLine());


Console.WriteLine($"digite em numeros o ano em que voce nasceu");
int ano = int.Parse(Console.ReadLine());

if (dia > 31){
    Console.WriteLine($"Nao existe mes com mais de 31 dias, dia invalido");
    
}

else if (mes > 12)
{
    Console.WriteLine($"Nao existe ano com mais de 12 meses, mes invalido");
    
}

else if (ano > 2013) {
    Console.WriteLine($"Estamos em 2013, ano invalido");
    
}
else {
    Console.WriteLine($"Data valida");
    
}

