using Xuyor.ContentContext.Enum;

namespace Xuyor.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            // Sempre fazer a inicialização no construtor.
            Modules = new List<Module>();
        }

        public int DurationInMinutes { get; set; }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

        public EContentLevel Level { get; set; }
    }
}