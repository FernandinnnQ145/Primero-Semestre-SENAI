
float l1,l2,l3;

Console.WriteLine($"Digite o 1 lado do trinagulo");
l1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 2 lado do trinagulo");
l2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 3 lado do trinagulo");
l3 = float.Parse(Console.ReadLine());

if (l1 == l2 && l2 == l3) {
    Console.WriteLine($"Seu triangulo é o equilatero");
}
else if (l1 == l2 || l2 == l3 || l1 == l3){
    Console.WriteLine($"Seu triangulo é o isoceles");
    
}
else{
    Console.WriteLine($"Seu triangulo é o escaleno");
    
}
