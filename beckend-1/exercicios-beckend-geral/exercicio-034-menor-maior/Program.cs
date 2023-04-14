int[] numeros = new int[10];

for(int i = 0; i<10;i++){
    Console.WriteLine($"Digite o {i+1}º valor");
    numeros[i] = int.Parse(Console.ReadLine());
    
}
Console.WriteLine($"O seu maior valor é o {numeros.Max()}\nO seu menor valor é o {numeros.Min()}");


