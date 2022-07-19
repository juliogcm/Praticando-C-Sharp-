using System.Text;


namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Modo Editor: ");
            Start();
        }

        public static void Start()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja armazenar o arquivo?");
            Viewer.Show(arquivo.ToString());
        }

    }
}
