Console.WriteLine($"Digite seu salario");
float salario = float.Parse(Console.ReadLine());
while (salario <= 0){
    Console.WriteLine($"Salario invalido, tente outro:");
    salario = float.Parse(Console.ReadLine());
}
Console.WriteLine($"Salario valido");
