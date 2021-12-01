using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler : IMessageStrategy
    {
        private IMessageStrategy messageStrategy;

        public void SetMessageStrategy(IMessageStrategy message)
        {
            this.messageStrategy = message;
        }

        public void SendMessage(string message)
        {
            messageStrategy.SendMessage(message);
        }
    }
}