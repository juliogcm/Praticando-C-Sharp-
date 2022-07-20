using Xuyor.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Novo Artigo", "www.xuyor.com/Novo-Artigo"));
articles.Add(new Article("Mais Um Artigo", "www.xuyor.com/Mais-Um-Artigo"));

foreach (var article in articles)
{
    Console.WriteLine($"Id: {article.Id}");
    Console.WriteLine($"Título: {article.Title}");
    Console.WriteLine($"Url: {article.Url}");
    Console.WriteLine("");
}

var carrers = new List<Carrer>();
var cSharpEspecialist = new Carrer("C# Especialist", "c-sharp-especialist");
var introducao = new Course("Conceitos Introdutórios", "conceitos-introdutorios");
var primeiroItem = new CarrerItem(1, "Comece Aqui", "Comece seus estudos por aqui.", introducao);


cSharpEspecialist.Items.Add(primeiroItem);
carrers.Add(cSharpEspecialist);

foreach (var carrer in carrers)
{
    Console.WriteLine(carrer.Id);
    Console.WriteLine(carrer.Title);
    Console.WriteLine(carrer.Url);
    Console.WriteLine(carrer.TotalCourses);
    foreach (var item in carrer.Items)
    {
        Console.WriteLine($"Título: {item.Title}");
        Console.WriteLine(item.Order);
    }

    Console.WriteLine("");
}
