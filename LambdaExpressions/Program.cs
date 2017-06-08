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

            Console.ReadKey();
        }

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
