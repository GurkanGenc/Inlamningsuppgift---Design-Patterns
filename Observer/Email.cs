using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }
        public string Message { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void UpdateMessage()
        {
            Message = "This is the new email";
            NotifyObservers();
        }
    }
}