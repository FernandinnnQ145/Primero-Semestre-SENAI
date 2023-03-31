
Console.WriteLine($"Digite o primeiro valor");
float v1 = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite o segundo valor");
float v2 = float.Parse(Console.ReadLine());


Console.WriteLine($"Digite o terceira valor");
float v3 = float.Parse(Console.ReadLine());

if (v1>v2 && v1>v3){
    Console.WriteLine($"Seu maior valor é o {v1}");
    
}
else if (v2>v1 && v2>v3){
    Console.WriteLine($"Seu maior valor é o {v2}");
    
}
else {
    Console.WriteLine($"Seu maior valor é o {v3}");
}


if (v1<v2 && v1<v3){
    Console.WriteLine($"Seu menor valor é o {v1}");
    
}
else if (v2<v1 && v2<v3){
    Console.WriteLine($"Seu menor valor é o {v2}");
    
}
else {
    Console.WriteLine($"Seu menor valor é o {v3}");
}


