using System.Collections.Generic;

namespace Bookstore.Models
{ 
     interface IBookDAL
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        void UpdateBook(Book book);
        Book GetBook(int? id);
        void DeleteBook(int? id);   
    }
}
