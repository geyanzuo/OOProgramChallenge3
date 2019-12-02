using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIcomputers.Models
{
    public class ModelFactory
    {
        public Authors Create(Author author)
        {
            return new Authors
            {
                ID = author.id,
                Firstname = author.Firstname,
                Surename = author.Surname,

                books = author.Books.Select(b =>Create(b)),
            };

        }

        public Books Create(Book book)
        {
            return new Books
            {
                ISBN = book.ISBN,
                Title = book.title,

                
            };

        }
        public Borrowers Create(Borrower borrower)
        {
            return new Borrowers
            {
                ID = borrower.id,
                Firstname = borrower.Firstname,
                Surename = borrower.Surname,
                DOB = borrower.DOB,

                books = borrower.Books.Select(b => Create(b)),
            };

        }
    }
}