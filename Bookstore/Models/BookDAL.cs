using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Bookstore.Models
{
    public class BookDAL: IBookDAL
    {
        string connectionString = @"Data Source=Marcos; Initial Catalog = BookstoreDB; Integrated security=True ";

        public IEnumerable<Book> GetAllBooks()
        {
            List<Book> bookList = new List<Book>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT isbn, title, subtitle, publishing, author, genre from Books");
                cmd.CommandType = CommandType.Text;
                
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book();

                    book.isbn = reader["isbn"].ToString() ;
                    book.title = reader["title"].ToString() ;  
                    book.subtitle = reader["subtitle"].ToString();
                    book.author = reader["author"].ToString();
                    book.genre = reader["genre"].ToString();

                    bookList.Add(book);
                    
                }
                connection.Close();
            }

            return bookList;

        }

        void IBookDAL.AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        void IBookDAL.DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Book> IBookDAL.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        Book IBookDAL.GetBook(int? id)
        {
            throw new NotImplementedException();
        }

        void IBookDAL.UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
