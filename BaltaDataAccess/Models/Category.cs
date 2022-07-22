// Cada uma das tabelas do BD vai se tornar uma classe aqui para ser lidada pelo Dapper.
// O desafio nosso em que o Dapper vai ajudar é pegar a informação do SqlServer que vem no 
// formato sqldatarow e tranformar isso para um objeto. 

namespace BaltaDataAccess.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Url { get; set; }

        public string Summary { get; set; }

        public int Order { get; set; }

        public string Description { get; set; }

        public bool Featured { get; set; }

    }

}