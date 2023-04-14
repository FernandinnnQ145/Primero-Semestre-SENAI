
int[] numeros = new int[15];

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Entre com o {i + 1}º numero");

    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"\n");
Console.WriteLine($"Agora a ordem inversa:");


for(int i =14; i>0; i--){
    Console.WriteLine($"{numeros[i]}");
    
}

