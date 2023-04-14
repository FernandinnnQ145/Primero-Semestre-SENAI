static float impostoNulo(float salario){
    float r = salario=0;
    return r;
}


static float impostoBaixo(float salario){
    float r = (20/100f)*salario;
    return r;
}
static float impostoMedio(float salario){
    float r = (25/100f)*salario;
    return r;
}
static float impostoAlto(float salario){
     float r = (35/100f)*salario;
    return r;
}

Console.WriteLine($"Digite seu salario");
float salario = float.Parse(Console.ReadLine());

if(salario <= 1500){
    Console.WriteLine($"\nTotal de imposto a pagar é {impostoNulo(salario)}");
    
}
else if(salario<=3500){
    Console.WriteLine($"\nTotal a pagar é {impostoBaixo(salario)}");
    
}
else if (salario<=6000){
    Console.WriteLine($"\nTotal a pagar é {impostoMedio(salario)}");
    
}
else{
    Console.WriteLine($"\nTotal a pagar é {impostoAlto(salario)}");
}


