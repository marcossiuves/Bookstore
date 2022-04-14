using System.Text.Json.Serialization;
using Bookstore.CustomTypes;

namespace Bookstore.Models
{

    public class Book
    {
        public Isbn isbn { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }   
        public string publishing { get; set; }
        public string author { get; set; }
        public string genre{ get; set; }
        //public DateTime registerDAte { get; set; }  
        [JsonIgnore]
        public int id { get; set; }
    }
}
