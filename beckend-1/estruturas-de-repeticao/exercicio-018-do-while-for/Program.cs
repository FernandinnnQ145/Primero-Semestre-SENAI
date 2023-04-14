Console.WriteLine($"Digite o nome do seu usuario:");
string usuario = Console.ReadLine();

Console.WriteLine($"Digite a sua senha: ");
string senha = Console.ReadLine();

while (usuario == senha){
    Console.WriteLine($"Senha igual o nome do usuario, tente outra:");
    senha = Console.ReadLine();
    
    
}
Console.WriteLine($"Senha valida");


