namespace Bookstore.Models
{
    public class BookExample
    {

        Book book = new Book();
        public Book BookSample()
        {

            return new Book()
            {

               //isbn = "1233",
                title = "Titulo",
                subtitle = "subtitulo",
                publishing = "editora",
                author = "autor",
                genre = "genero",
                id = 1

            };

        }      

              //  Pets = new List<string> { "Fido", "Polly", "Spot" }
    }
}
