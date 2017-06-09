using System;

namespace Events
{
    public class TextService
    {
        public void Send()
        {
            Console.WriteLine("Sending Text...");
        }
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending Text...");
        }
    }
}
