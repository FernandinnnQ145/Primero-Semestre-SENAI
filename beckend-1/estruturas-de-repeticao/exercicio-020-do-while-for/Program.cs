int sim = 0;
int nao = 0;
int mResposta = 0;
int hResposta = 0;
int masculino = 0;




for (int quantidade = 0; quantidade<3 ;quantidade++){

    Console.WriteLine($"Voce é do sexo masculino ou feminino? m/f");
    char sexo = char.Parse(Console.ReadLine());
    if(sexo != 'm' && sexo !='f'){
        Console.WriteLine($"Invalida, tente outra:");
        sexo = char.Parse(Console.ReadLine());
        
    }
    else if(sexo == 'm'){
        masculino++;
    }
    

    

    Console.WriteLine($"Voce gostou do nosoo produto? s/n");
    char resposta = char.Parse(Console.ReadLine());
    if(resposta != 's' && resposta !='n'){
        Console.WriteLine($"Invalida, tente outra:");
        resposta = char.Parse(Console.ReadLine());
        
    }
    else if(resposta == 's'){
        sim++;
    }
    else if (resposta == 'n'){
        nao++;
    }




   if((sexo == 'f') && (resposta == 's'))
   {
    mResposta++;
   }
   if ((sexo) == 'm' && (resposta == 'n'))
   {
    hResposta++;
   }
    

    
}

double pHomem;
pHomem = Math.Round(((double)hResposta/masculino)*100,0);

Console.WriteLine($"{sim} responderam que gostaram");
Console.WriteLine($"{nao} responderam nao gostaram");
Console.WriteLine($"{mResposta} numero de mulheres que responderam que gostaram");
Console.WriteLine($"{pHomem}% dos homens votam quem nao gostaram");









