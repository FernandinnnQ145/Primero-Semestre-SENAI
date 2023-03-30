Console.WriteLine($"Digite a frequencia do aluno: ");
float frequencia = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite a nota do aluno: ");
float nota = float.Parse(Console.ReadLine());

if (frequencia < 75){
    Console.WriteLine($"Reprovado");
    
}
else if (frequencia >= 75 && nota < 3 && nota > 7.0){
    Console.WriteLine($"Caso em avaliação");
    
}
else if (frequencia >= 75 && nota >= 7.0){
    Console.WriteLine($"Aprovado");
    
}
else{
    Console.WriteLine($"Reprovado");
    
}


