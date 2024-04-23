using System;
namespace Delegate_and_Event_Program
{
    public class MessageService
    {
        public void OnVideoEncoder(object source, VideoEventArgs args) {

            Console.WriteLine("MessageService :- Sending a Text Message...... "+args.Video.Title);
        }
    }
}
