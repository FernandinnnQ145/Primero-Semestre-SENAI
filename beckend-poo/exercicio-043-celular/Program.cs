using exercicio_043_celular;

celular celular1 = new celular();
string escolhaMensagem;
string escolhaLigacao;

Console.WriteLine($"Seu celular esta desiligado, aperte L para ligar:");
string botao = Console.ReadLine()!.ToLower();
string escolha;

while (botao != "l")
{
    Console.WriteLine($"O celular permanece desligado");
    botao = Console.ReadLine()!;

}
if (botao == "l")
{
    { celular1.ligar(); }
    celular1.ligado = true;
}
else
{
    celular1.ligado = false;
}

do
{
    Console.Clear();
    Console.WriteLine(@$"Voce deseja:
1-Enviar mensagem
2-fazer ligação

0-Desligar");

    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            do
            {
                Console.Clear();
                Console.WriteLine(@$"Para qual contato deseja enviar mensagem?
        1-Cleitinho
        2-Klebinho
        3-Luizinho");
                string mensagem;
                escolhaMensagem = Console.ReadLine();
            } while (escolhaMensagem != "2" && escolhaMensagem != "1" && escolhaMensagem != "3");
            { celular1.mensagem(); }
            break;

        case "2":
            do
            {
                Console.Clear();
                Console.WriteLine(@$"Para qual contato deseja ligar?
        1-Cleitinho
        2-Klebinho
        3-Luizinho");
                string mensagem;
                escolhaLigacao = Console.ReadLine();
            } while (escolhaLigacao != "2" && escolhaLigacao != "1" && escolhaLigacao != "3");
            { celular1.ligacao(); }
            break;

        case "0":
            { celular1.desligar(); }
            System.Environment.Exit(0);
            break;

    }
} while (escolha != "0");
