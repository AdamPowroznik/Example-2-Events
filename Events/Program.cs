using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video(){ Title = "Video 1"};
            VideoEncoder videoEncoder = new VideoEncoder();
            MailService mailService = new MailService();
            TextMessage textMessage = new TextMessage();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textMessage.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
