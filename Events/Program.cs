using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Harry Potter" };
            var videoEncoder = new VideoEncoder();
            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
