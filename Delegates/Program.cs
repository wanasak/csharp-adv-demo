using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHanlder = filters.ApplyBrightness;
            filterHanlder += filters.ApplyContrast;
            filterHanlder += filters.Resize;
            filterHanlder += RemoveColor;   // Custom filter

            photoProcessor.Processor("C:\\image1.png", filterHanlder);

            Console.ReadKey();
        }
        // Custom filter
        static void RemoveColor(Photo photo)
        {
            Console.WriteLine("Remove Color");
        }
    }
}
