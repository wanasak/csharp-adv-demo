using System;

namespace Events
{
    public class MailService
    {
        public void Send()
        {
            Console.WriteLine("Sending Mail...");
        }
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending Mail... " + args.Video.Title);
        }
    }
}
