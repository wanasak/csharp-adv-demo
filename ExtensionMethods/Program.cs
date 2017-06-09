using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This tutorial is specially designed to help you learn AngularJS as quickly and efficiently as possible.";
            Console.WriteLine(text.Shorten(5));

            // We often using extension methods instead of creating them
            IEnumerable<int> numbers = new List<int>() { 11, 4, 5, 54, 20 };
            var maxNumber = numbers.Max();

            Console.ReadKey();
        }
    }
}
