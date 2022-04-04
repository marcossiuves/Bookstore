using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bookstore.Models
{

    [Table("Books")]
    public class Book
    {
        [Key]
        public string isbn { get; set; }
        [Required]
        public string title { get; set; }
        public string subtitle { get; set; }   
        [Required]
        public string publishing { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string genre{ get; set; }

    }
}
