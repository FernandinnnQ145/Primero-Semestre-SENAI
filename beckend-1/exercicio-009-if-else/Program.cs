
float qMaçã, valor;

Console.WriteLine($"Escreva quantas maçãs voce deseja");
qMaçã = float.Parse(Console.ReadLine());

if (qMaçã < 12){
    valor = qMaçã * 0.30f;
    Console.WriteLine($"O valor das maçãs sera R${valor}");
    

}
else 
{
    valor = qMaçã * 0.25f;
    Console.WriteLine($"O valor das maçãs sera R${valor}");
    
}

