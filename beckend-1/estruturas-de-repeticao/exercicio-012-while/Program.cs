Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

while(nome == ""){
    Console.WriteLine($"Nome invalido");
    nome = Console.ReadLine();
    
    
}
Console.WriteLine($"Nome valido");

