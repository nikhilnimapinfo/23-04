using System;

namespace Delegate_and_Event_Program
{
    public class MailService {
        public void OnVideoEncoder(Object o, VideoEventArgs e)
        {
            Console.WriteLine("MailService : Mail is Sending....."+e.Video.Title);
        }   
    }
}
