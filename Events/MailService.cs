using System;

namespace Events
{
    public class MailService
    {
        public void Send()
        {
            Console.WriteLine("Sending Mail...");
        }
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending Mail...");
        }
    }
}
