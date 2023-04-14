
static float multiplicacao(float n1, float n2){
    float r = n1*n2;
    return r;
}
static float subtracao(float n1, float n2){
    
    float r = n1-n2;
    return r;
}
static float divisao(float n1, float n2){

   
    float r = n1/n2;
    
    return r;
}





Console.WriteLine($"aperte m para multiplicar, s para subtrair ou d para dividir");
char escolha = char.Parse(Console.ReadLine());

while (escolha !='m' && escolha!='s' && escolha!='d')
{
        Console.WriteLine($"Resposta invalida, tente outra:");
        escolha = char.Parse(Console.ReadLine());
}


if (escolha == 'm'){
    Console.WriteLine($"Entre com o primeiro valor");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Entre com o segundo valor");
    float n2 = float.Parse(Console.ReadLine());
    
    Console.WriteLine($"Resultado = {multiplicacao(n1,n2)}");
}
else if (escolha == 's'){
    

    Console.WriteLine($"Entre com o primeiro valor");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Entre com o segundo valor");
    float n2 = float.Parse(Console.ReadLine());


    Console.WriteLine($"Resultado = {subtracao(n1,n2)}");
}
else{
Console.WriteLine($"Entre com o primeiro valor");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Entre com o segundo valor");
    float n2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Resultado = {divisao(n1,n2)}");

}