using System;
using System.Threading;

namespace Delegate_and_Event_Program
{
    public class VideoEncoder {
       // public delegate void VideoEncoderEvent(Object s, VideoEventArgs a);

        //public event VideoEncoderEvent VideoEncode;  
        public event EventHandler<VideoEventArgs> VideoEncode;
        // public event EventHandler VideoEncode; //you can Write That Way Also
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video .....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncode != null)
            {
                VideoEncode(this,new VideoEventArgs (){Video=video });
            }
        }
    
    }
}
