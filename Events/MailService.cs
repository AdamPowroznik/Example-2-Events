namespace Events
{
    class MailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            System.Console.WriteLine("Sending an E-mail...." + e.Video.Title);
        }
    }
    
}
