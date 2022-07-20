// Como não bloquear a execução do programa.

namespace Xuyor.NotificationContext
{
    // Classe selada para que ninguém possa estendê-la e criar variantes.
    public sealed class Notification
    {
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public Notification()
        {
            // Construto vazio caso queira instanciar a classe com nada.
        }

        // Propriedade que apresenta o erro.
        public string Property { get; set; }

        // Mensagem de erro.
        public string Message { get; set; }
    }
}