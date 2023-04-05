
float salario, gasto;
Console.WriteLine($"Digite seu salario: ");
salario = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite seu gasto: ");
gasto = float.Parse(Console.ReadLine());

if (salario<gasto){
    Console.WriteLine($"Orçamento estourado");
    
}
else 
{
    Console.WriteLine($"Gastos dentro do orçamento");
    
}
