
int t1, t2;

Console.WriteLine($"Insira o resultado do time 1");
t1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o resultado do time 2");
t2 = int.Parse(Console.ReadLine());

if (t1>t2){
    Console.WriteLine($"Vitoria do time 1");
    
}
else if (t1<t2){
    Console.WriteLine($"Vitoria do time 2");
    
}
else {
    Console.WriteLine($"Empate");
    
}