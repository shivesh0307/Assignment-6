using System.Collections.Generic;
using WebApplication2.Entities;
namespace WebApplication2.Repositories
{
    public class BookRepository
    {
        private readonly AssignmentDBContext db;
        public BookRepository()
        {
            this.db = new AssignmentDBContext();
        }
        public List<Book> GetBook()
        {
            
                return db.Books.ToList();
            
        }
        
        public void AddBook(Book book)
        {
            
                db.Books.Add(book);
                db.SaveChanges();
            
        }

        public Book GetBookByName(string BookName)
        {
            Book Book = list.SingleOrDefault(i => i.BookName == BookName);
            return Book;
        }

        public Book GetBookByAuthor(string Author)
        {
            Book Book = list.SingleOrDefault(i => i.Author == Author);
            return Book;
        }

        public Book GetBookByPublisher(string Publisher)
        {
            Book Book = list.SingleOrDefault(i => i.Publisher == Publisher);
            return Book;
        }

        public void DeleteBook(int BookID)
        {
            Book Book = list.SingleOrDefault(i => i.BookID == BookID);
            list.Remove(Book);
        }

        public void EditBook(Book Book)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].BookID == Book.BookId)
                {
                    list[0].BookName = Book.BookId;
                    list[0].Price = Book.Price;
                    list[0].Author = Book.Author;
                    list[0].Lang = Book.Lang;
                    list[0].Publisher = Book.Publisher;
                    break;
                }
            }
        }



    }
}
