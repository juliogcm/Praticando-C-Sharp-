using Xuyor.NotificationContext;
using Xuyor.SharedContext;

namespace Xuyor.ContentContext
{
    public class CarrerItem : Base
    {
        public CarrerItem(int order, string title, string description, Course course)
        {
            if (course == null)
            {
                // Não bloqueia a execução do programa.
                AddNotification(new Notification("Course", "Curso inválido"));
            }

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Course Course { get; set; }

    }
}