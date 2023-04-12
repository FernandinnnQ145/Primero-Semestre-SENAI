
string[] nome = new string[5];
int[] idade = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Escreva o seu nome");
    nome[i] = Console.ReadLine();
    Console.WriteLine($"Ecreva sua idade");
    idade[i] = int.Parse(Console.ReadLine());

}


for (int i = 0; i < 5; i++)
{

    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n{i + 1}) nome: {nome[i]}");
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Idade: {idade[i]}");
    Console.ResetColor();


}