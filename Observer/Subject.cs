using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Subject
    {
        private string MessageType { get; set; }
        private string CheckMessage { get; set; }

        public Subject(string messageType, string checkMessage)
        {
            MessageType = messageType;
            CheckMessage = checkMessage;
        }

        public string GetMessageType()
        {
            return MessageType;
        }

        public void SetMessage(string messageType)
        {
            this.CheckMessage = messageType;
            Console.WriteLine("This is the Email that notify observers");
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            Console.WriteLine($"This message's type is {MessageType}.");

            Console.WriteLine();

            //foreach (IObserver observer in observers)
            //{
            //    observer.update(CheckMessage);
            //}
        }

        public void RegisterObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void UnregisterObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
