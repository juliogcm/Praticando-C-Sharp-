namespace Xuyor.ContentContext
{
    public class Carrer : Content
    {
        public Carrer(string title, string url) : base(title, url)
        {
            Items = new List<CarrerItem>();
        }

        public IList<CarrerItem> Items { get; set; }

        // Expression Body: public int TotalCourses => Items.Count;
        public int TotalCourses
        {
            get
            {
                return Items.Count;
            }
        }

    }

}