namespace Xuyor.NotificationContext
{
    // Guardar o log de todas as notificações que forem geradas pelos diferentes objetos.
    public abstract class Notifiable
    {
        protected Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public List<Notification> Notifications { get; set; }

        // Armazena uma única notificação.
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        // Armazena uma lista de notificações.

        public void AddNotifications(List<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        // O objeto só se torna válido se houverem notificações presentes nele.
        // Propriedade informa através de um booleano se tem ou não notificações. 
        // public bool IsInvalid => Notifications.Any();
        public bool IsInvalid
        {
            get
            {
                return Notifications.Any();
            }

        }

    }
}