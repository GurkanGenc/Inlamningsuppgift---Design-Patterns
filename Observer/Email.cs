using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }
        public string message { get; set; }

        public Email()
        {
            Observers = new();
        }

        //internal static string Check()
        //{
        //    var evenMinute = DateTime.Now.Minute % 2;
        //    if (evenMinute==0)
        //    {
        //        return "this is the email";
        //    }
        //    return null;
        //}

        public void NotifyObservers()
        {
            foreach (Observer observer in Observers)
            {
                observer.Update(message);
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
            message = "This is the new email";
            Console.WriteLine(message);

            NotifyObservers();
        }
    }
}