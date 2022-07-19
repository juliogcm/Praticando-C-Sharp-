namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            DrawScreen();
            WriteOptions();

            short opcao = short.Parse(Console.ReadLine());
        }

        public static void DrawScreen()
        {
            int tamanhoAltura = 10;
            int tamanhoLargura = 50;

            for (int linhas = 0; linhas <= tamanhoAltura; linhas++)
            {
                Console.Write("\n");

                // Se for a primeira ou última coluna.
                if (linhas == 0 || linhas == tamanhoAltura)
                {
                    for (int colunas = 0; colunas < tamanhoLargura; colunas++)
                    {
                        if (colunas == 0 || colunas == tamanhoLargura - 1)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                }
                // Demais colunas.
                else
                {
                    for (int colunas = 0; colunas < tamanhoLargura; colunas++)
                    {
                        if (colunas == 0 || colunas == tamanhoLargura - 1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }

            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor Html");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("--------------");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Seleciona uma das opções abaixo: ");

            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir arquivo");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}