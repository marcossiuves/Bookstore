using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Bookstore.Models
{
    public class BookDAL: IBookDAL
    {


        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();

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
