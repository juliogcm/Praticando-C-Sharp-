// See https://aka.ms/new-console-template for more information
static void Exit()
{
    Console.Clear();
    System.Environment.Exit(0);
}

static void Salvar(string texto)
{
    string path = "textos/arquivo.txt";

    // Abre e fecha os arquivos para que não seja esquecido e cause uma falha no sistema.
    using (var arquivo = new StreamWriter(path))
    {
        arquivo.Write(texto);
    }

    Console.WriteLine($" Arquivo salvo em {path} com sucesso.");
}

static void Criar()
{
    Console.Clear();
    string texto = "";

    Console.WriteLine("Digite o texto que deseja salvar: ");
    Console.WriteLine("---------------------");

    do
    {

        texto += Console.ReadLine();
        texto += Environment.NewLine;

    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.Clear();
    Salvar(texto);
    Menu();

}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do arquivo que deseja ler: ");
    string nome = Console.ReadLine();
    string path = "textos/" + nome + ".txt";

    using (var arquivo = new StreamReader(path))
    {
        string conteudo = arquivo.ReadToEnd();
        Console.WriteLine("Exibindo conteúdo do arquivo: ");
        Console.WriteLine(conteudo);
    }

    Console.WriteLine("");
    Console.ReadLine();

    Console.Clear();
    Menu();

}

static void Menu()
{
    Console.WriteLine("1 - Criar um arquivo de texto");
    Console.WriteLine("2 - Abrir um arquivo de texto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha o que deseja fazer: ");

    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0: Exit(); break;
        case 1: Criar(); break;
        case 2: Abrir(); break;
        default: Menu(); break;
    }

}

Menu();
