namespace Bookstore.Models
{

    public class Book
    {

        
        public string isbn { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }   
        public string publishing { get; set; }
        public string author { get; set; }
        public string genre{ get; set; }

        public int Id { get; set; }

    }
}
