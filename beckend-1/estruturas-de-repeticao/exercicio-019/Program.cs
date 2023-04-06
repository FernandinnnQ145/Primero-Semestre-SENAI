Console.WriteLine($"Escreva um numero para descubrir a sua tabuada: ");
int numero = int.Parse(Console.ReadLine());
int multiplicador = 0;
int resultado;

do{
    multiplicador ++;
    resultado = multiplicador * numero;
    Console.WriteLine($"{resultado}");
    
    

} while (multiplicador < 10);
