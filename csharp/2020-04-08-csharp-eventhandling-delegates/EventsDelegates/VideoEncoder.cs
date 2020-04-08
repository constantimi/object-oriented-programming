using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        /// Define a delegate
        /// Define an event based on that delegate
        /// Raise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        /// Another delegates are:
        /// EventHandler
        /// EventHandler<TEventArgs>

        // public EventHandler<VideoEventArgs> VideoEncoded;

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // .NET suggests our event methods to be protected, virtual and void,
        // starting with the word On<the-name-of-the-event>
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
