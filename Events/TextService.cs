using System;

namespace Events
{
    public class TextService
    {
        public void Send()
        {
            Console.WriteLine("Sending Text...");
        }
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending Text... " + args.Video.Title);
        }
    }
}
