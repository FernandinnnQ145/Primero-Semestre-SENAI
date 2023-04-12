int[] numeros=new int[6];
int par=0;
int impar = 0;

for (int i = 0; i<6;i++){
    Console.WriteLine($"Digite o {i+1}º valor");
    numeros[i] =int.Parse(Console.ReadLine());
    if(numeros[i] %2 ==0){
        par++;
    }
    else{
        impar++;
    }

}
Console.WriteLine($"Temos {par} numeros pares");
Console.WriteLine($"Temos {impar} numeros impar");



