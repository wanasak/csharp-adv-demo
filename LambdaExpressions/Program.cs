using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // () => ...
            // x => ...
            // (x, y, z) => ...

            Func<int, int> square = number => number * number;

            //Console.WriteLine(Square(4));
            Console.WriteLine(square(3));

            var books = new BookRepository().GetBooks();

            //var cheaperBooks = books.FindAll(IsBookCheaperThan10);
            var cheaperBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadKey();
        }

        // Predicate method
        //static bool IsBookCheaperThan10(Book book)
        //{
        //    return book.Price < 10;
        //}

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
