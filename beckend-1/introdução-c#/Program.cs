// variaveis

// declarando uma variavel
/*string nome;

 Console.WriteLine("Digite seu nome:");


nome = (Console.ReadLine());

if (nome == "Fernando")
{
    Console.WriteLine("Seu lindo");
    
} 
else{
    Console.WriteLine("Sai do pc");
    
}

*/






// Crie um programa que calcule o imc da pessoa

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
------Programa para calcular o imc-----------

");


Console.BackgroundColor = ConsoleColor.Green;

Console.WriteLine($"Digite seu nome:");
string nome = (Console.ReadLine());
float peso, altura;

Console.WriteLine($"Digite seu peso:");
peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua altura:");
altura = float.Parse(Console.ReadLine());

// processamento

Console.BackgroundColor = ConsoleColor.Magenta;

float imc = peso/((float)Math.Pow(altura,2));

Console.WriteLine("O IMC do " + nome + " é de "+ imc);





Console.ResetColor();
Console.ReadLine();