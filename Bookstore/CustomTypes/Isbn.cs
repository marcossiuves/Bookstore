namespace Bookstore.CustomTypes
{
    public class Isbn
    {
        public string isbn { get; set; }

        public Isbn()
        {
        }

        public Boolean isValidIsbn(String isb)
        {
            return isbn.Length == 9;
        }
    }
}
