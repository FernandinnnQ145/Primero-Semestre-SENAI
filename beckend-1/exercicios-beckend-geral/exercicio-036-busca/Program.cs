string[] nomes = new string[10];
for(int i =0; i<3;i++){
    Console.WriteLine($"Digite o {i+1}º nome:");
    nomes[i]=Console.ReadLine();
    
    
}

Console.WriteLine($"Digite um nome para conferir se ele esta na lista:");
string bNome = Console.ReadLine();

if(nomes.Contains(bNome)){
Console.WriteLine($"Achei :)");

}
else{
    Console.WriteLine($"Nao achei :(");
    
}

