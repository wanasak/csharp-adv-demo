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
            Console.WriteLine(Square(4));

            Console.ReadKey();
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
