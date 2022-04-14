using FluentValidation;
using Bookstore.Models;

namespace Bookstore.CustomTypes
{
    public class BookValidator : AbstractValidator<Book>
    {

        public BookValidator()
        {
            RuleFor(book => book.isbn)
                .NotEmpty()
                .Must(x => x.isbn.Length == 9);

            RuleFor(book => book.author)
                .NotEmpty();
        }
       
    }
}
