
Console.WriteLine($"Escreva seu nome:");
string nome = Console.ReadLine();
float idade, mes, dias, horas, minutos;

Console.WriteLine($"Digite sua idade:");
idade = float.Parse(Console.ReadLine());

mes = idade * 12;
dias = idade * 365;
horas = idade * 8766;
minutos = idade * 525960;

Console.WriteLine($"{nome} tem {mes} meses, {dias} dias, {horas} horas, {minutos} minutos");




