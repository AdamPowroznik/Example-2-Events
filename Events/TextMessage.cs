using System;

namespace Events
{
    class TextMessage
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("Sending text message..." + e.Video.Title);
        }
    }
    
}
