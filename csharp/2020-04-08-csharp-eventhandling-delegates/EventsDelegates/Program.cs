namespace EventsDelegates
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // pointer to an event handler method
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
