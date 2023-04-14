// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Digite o nome do produto");
string nome = Console.ReadLine();
Console.WriteLine($"Digite a quantidade do produto");
int quantidade = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite o preço do produto");
float preco = float.Parse(Console.ReadLine());

float valor= quantidade*preco;
float desconto;
if(quantidade<=5){
    desconto = valor-((2/100f)*valor);
}


else if(quantidade>5&&quantidade<=10){
    desconto = valor-((3/100f)*valor);
    Console.WriteLine($"Voce pagara R${desconto} pelo {nome}");
}
else{
    desconto = valor-((5/100f)*valor);
    Console.WriteLine($"Voce pagara R${desconto} pelo {nome}");
}