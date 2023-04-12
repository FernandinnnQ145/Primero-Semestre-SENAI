int[] arrayNumeros = new int[5];

for (int i=0;i<5;i++){
    Console.WriteLine($"Digite o {i+1}º de 5, valor para descubrir o seu dobro:");
    arrayNumeros[i] = int.Parse(Console.ReadLine());
}
foreach (int numero in arrayNumeros)
{
    Console.WriteLine($"o dobro de {numero} é: {numero*2}");
    
}

