using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Messages
{
    public class SendFbMsgStrategy : IMessageStrategy
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending \"{message}\" as a facebook message...");
        }
    }
}
