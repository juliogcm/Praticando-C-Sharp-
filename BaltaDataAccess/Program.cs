using Microsoft.Data.SqlClient;
using BaltaDataAccess.Models;
using Dapper;

const string connectionString = @"Server=localhost;Database=balta;Trusted_Connection=True;Encrypt=False";

// Fazer o MÍNIMO possível dentro da conexão. Variáveis e objetos podem ser criados fora.

// Irei criar um objeto de conexão proveniente do pacote SqlCliente instalado.
using (var connection = new SqlConnection(connectionString))
{
    // O objetivo é usar o quanto mais de funções do C# quanto possível para que, no lado do SQL, só precisem ser feitas as operações básicas.
    Console.WriteLine("Conectado ao banco!");

    CreateCategory(connection);
    ListCategory(connection);


    // Estrutura dos métodos para lembra de que depois de alocar recursos de conexão, liberá-los;
    //connection.Open();

    // É positivo realizar os comandos dentro do "using" para garantir que não sobrem vestigios deles.
    // using (var command = new SqlCommand())
    // {
    //     Console.WriteLine("Conectado ao banco!");
    //     command.Connection = connection;
    //     command.CommandType = System.Data.CommandType.Text;
    //     command.CommandText = "SELECT [Id], [Title] FROM [Category]";

    //     // É o que é utilizado por baixo dos panos do Dapper, o new SqlDataReader();
    //     var reader = command.ExecuteReader(); // Esse método já retorna o SqlDataReader().

    //     while (reader.Read())
    //     {
    //         Console.WriteLine($"Id - {reader.GetGuid(0)} || Title - {reader.GetString(1)}");
    //     }

    // }
}

static void ListCategory(SqlConnection connection)
{
    // Uma consulta vai ser sempre uma lista para o Dapper.
    var categories = connection.Query<Category>(@"SELECT * FROM [Category]");

    //Criando inserção de dados com o Dapper. Retorna a quantidade de linhas afetadas.
    foreach (var item in categories)
    {
        Console.WriteLine($"Id - {item.Id} || Title - {item.Title} || Summary - {item.Summary}");
    }
}

static void CreateCategory(SqlConnection connection)
{
    // Comando de inserção deve ser primeiro salvo em uma variável para depois ser passado.
    var insertCategory = @"INSERT INTO 
                            [Category] 
                        VALUES(
                            @Id, 
                            @Title, 
                            @Url, 
                            @Summary, 
                            @Order, 
                            @Description, 
                            @Featured
                        )";
    // @ é importante para precauções contra ataque de injeções.


    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS II";
    category.Url = "-amazon-II";
    category.Description = "Categoria destinada aos serviços AWS, nível II.";
    category.Summary = "AWS cloud II.";
    category.Order = 9;
    category.Featured = false;

    var rows = connection.Execute(insertCategory, new
    {
        category.Id,
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
    });
    //Essa query tem os parametros definidos pelos @ anteriores e eles vão ser mapeados pelos parâmetros criados acima.
    Console.WriteLine($"{rows} linhas inseridas");

}


// Se o close for esquecido, a conexão vai existir por um tempo até que o GarbageCollector 
// identifique a sua inatividade e remova ela. Mas é bom evitar que isso aconteça.
//connection.Close();
// connection.Dispose(); Destrói o objeto e é necessário criar uma nova instância (new).

// Também é possível utilizar o "using" para gerenciar essa "connection".
//using(var connection = new SqlConnection(connectionString))
//{
//      Aqui dentro será possível executar os comandos porque o "using" 
//      gerencia as propriedades de criação e destuição do objeto (nesse caso "abrir" e "fechar" conexão).
//      Console.WriteLine("Conectado ao banco!");
//}