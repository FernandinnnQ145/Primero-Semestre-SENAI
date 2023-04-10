int pValor, sValor, resultado;
pValor=1;
sValor=1;
Console.WriteLine($"{pValor}");
Console.WriteLine($"{sValor}");



do{

    resultado = pValor + sValor;
    Console.WriteLine($"{resultado}");
    sValor=pValor;
    pValor=resultado;
    
    
}while(resultado<500);
