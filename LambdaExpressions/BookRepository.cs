using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title = "Title 1", Price = 4 },
                new Book { Title = "Title 2", Price = 6 },
                new Book { Title = "Title 3", Price = 11 },
            };
        }
    }
}
