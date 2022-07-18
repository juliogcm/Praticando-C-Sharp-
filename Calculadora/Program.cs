// See https://aka.ms/new-console-template for more information
Console.Clear();

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("Oção 1 - Soma");
    Console.WriteLine("Oção 2 - Subtração");
    Console.WriteLine("Oção 3 - Divisão");
    Console.WriteLine("Oção 4 - Multiplicação");
    Console.WriteLine("Oção 5 - Sair");

    Console.WriteLine("------------------");
    Console.WriteLine("Selecione uma das opções acima: ");

    short key = short.Parse(Console.ReadLine());

    switch (key)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Sair(); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro número: ");
    float primeiroNumero = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número: ");
    float segundoNumero = float.Parse(Console.ReadLine());

    float resultadoSoma = primeiroNumero + segundoNumero;
    Console.WriteLine($"O resultado da Soma é {resultadoSoma}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro número: ");
    float primeiroNumero = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número: ");
    float segundoNumero = float.Parse(Console.ReadLine());

    float resultadoSubtracao = primeiroNumero - segundoNumero;
    Console.WriteLine($"O resultado da Soma é {resultadoSubtracao}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro número: ");
    float primeiroNumero = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número: ");
    float segundoNumero = float.Parse(Console.ReadLine());

    float resultadoDivisao = primeiroNumero / segundoNumero;
    Console.WriteLine($"O resultado da Soma é {resultadoDivisao}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroNumero = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float segundoNumero = float.Parse(Console.ReadLine());

    Console.WriteLine($"Resultado da Multiplicação é {primeiroNumero * segundoNumero}");
    Console.ReadKey();
    Menu();
}

static void Sair()
{
    Console.Clear();
    System.Environment.Exit(0);
}