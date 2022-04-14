using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bookstore.Models;
using Bookstore.CustomTypes;
namespace BookstoreTests
{
    [TestClass]
    public class BookDalTest
    {
        [TestMethod]
        public void IsbnInvalidShouldReturnFalse()
        {

            string invalidIsbn = "1234";

           var isbn = new Isbn(invalidIsbn);






        }
    }
}