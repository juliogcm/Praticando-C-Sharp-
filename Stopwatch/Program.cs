// Esse código ativa a contagem regressiva da EXPLOSÃO.

static void Time(int finalTime)
{
    int currentTime = 0;

    do
    {
        Console.Clear();
        Console.WriteLine($"Falta {finalTime - currentTime} segundo(s) para o fim.");
        currentTime++;
        Thread.Sleep(1000);

    } while (currentTime < finalTime);

    Console.Clear();
    Console.WriteLine($"((( BOOMM )))");
    Thread.Sleep(1000);
    Console.Clear();

}

static void Exit()
{
    Console.Clear();
    System.Environment.Exit(0);
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Segundos");
    Console.WriteLine("M - Minutos");
    Console.WriteLine("E - Exit");
    Console.WriteLine("Digite o tempo que quer contar e a forma de contagem dentre as acima: ");
    string opcao = Console.ReadLine().ToLower();
    char tipo = char.Parse(opcao.Substring(opcao.Length - 1, 1));
    int tempo = int.Parse(opcao.Substring(0, opcao.Length - 1));

    switch (tipo)
    {
        case 's': Time(tempo); break;
        case 'm': Time(tempo * 60); break;
        case 'e': Exit(); break;
        default: Console.WriteLine("Opção inválida."); Menu(); break;
    }
}

Menu();