Console.WriteLine($"Digite uma letra para descubrir se ela é vogal ou consoante");

string letra = Console.ReadLine();

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") {
    Console.WriteLine($"Letra vogal");
    
}
else{
    Console.WriteLine($"Letra consoante");
    
}