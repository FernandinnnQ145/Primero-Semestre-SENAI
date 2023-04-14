Console.WriteLine($"Digite uma nota de 0 a 10:");
float nota = int.Parse(Console.ReadLine());

while (nota < 0 || nota > 10){
    Console.WriteLine($"Nota invalida, tente outra:");
    nota = int.Parse(Console.ReadLine());
    
}
Console.WriteLine($"Nota valida");


