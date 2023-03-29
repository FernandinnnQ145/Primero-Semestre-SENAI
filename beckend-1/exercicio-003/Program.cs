Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

float n1,n2,n3,n4,n5, media;

Console.WriteLine($"Digite a primeira nota:");
n1 = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite a segunda nota:");
n2 = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite a terceira nota:");
n3 = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite a quarta nota:");
n4 = float.Parse(Console.ReadLine());



Console.WriteLine($"Digite a quinta nota:");
n5 = float.Parse(Console.ReadLine());


media = (n1+n2+n3+n4+n5)/5;

Console.WriteLine($"A media do {nome} é {media}");

if (media>=6){
    Console.WriteLine($"Aprovado");
    
}
else{
    Console.WriteLine($"Reprovado");
    
}




