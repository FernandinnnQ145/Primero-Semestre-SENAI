// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro
// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.




static float alcool(float litros)
{

    if (litros <= 20)
    {
        float r = (litros*4.90f)*0.97f;
        return r;
    }
    else
    {
        float r = (litros*4.90f)*0.95f;
        return r;
    }
}


static float gasolina(float litros)
{
    if (litros <= 20)
    {
        float r = (litros*5.30f)*0.96f;
        return r;
    }
    else
    {
        float r = (litros*5.30f)*0.94f;
        return r;
    }

}
char escolha;
do
{
    Console.WriteLine(@$"Selecione qual tipo de combustivel voce deseja:
a-alcool 
g-gasolina");
     escolha = char.Parse(Console.ReadLine().ToLower());


    switch (escolha)
    {
        case 'a':
            Console.WriteLine($"\nQuantos litros voce deseja?");
            float litros = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nVoce devera pagar R${alcool(litros)}");
            break;


        case 'g':
            Console.WriteLine($"\nQuantos litros voce deseja?");
            litros = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nVoce devera pagar R${gasolina(litros)}");
            break;
        default:
            Console.WriteLine($"Resposta invalida, tente outra:");
            escolha = char.Parse(Console.ReadLine().ToLower());
            break;
    }






} while ((escolha != 'a' && escolha != 'g'));




