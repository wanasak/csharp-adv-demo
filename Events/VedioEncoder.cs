using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //private MailService _mailService;
        //private TextService _textService;

        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        //public VideoEncoder()
        //{
        //    _mailService = new MailService();
        //    _textService = new TextService();
        //}
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            //_textService.Send();
            //_mailService.Send();

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs { Video = video });
        }
    }
}
