using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        private MailService _mailService;
        private TextService _textService;

        public VideoEncoder()
        {
            _mailService = new MailService();
            _textService = new TextService();
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            _textService.Send();
            _mailService.Send();
        }
    }
}
