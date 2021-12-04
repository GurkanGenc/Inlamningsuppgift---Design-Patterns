using Design_Patterns_Assignment.Messages;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            var message = "This is the message";
            //MessageHandler.SendEmail(message);
            //MessageHandler.SendSMS(message);
            //MessageHandler.SendFacebookMessage(message);

            Console.WriteLine("Enter the message type : Email | SMS | Facebook");
            string messageType = Console.ReadLine();

            MessageHandler messageHandler = new();

            if ("Email".Equals(messageType, StringComparison.OrdinalIgnoreCase))
            {
                messageHandler.SetMessageStrategy(new SendEmailStrategy());
            }
            else if ("SMS".Equals(messageType, StringComparison.OrdinalIgnoreCase))
            {
                messageHandler.SetMessageStrategy(new SendSmsStrategy());
            }
            else if ("Facebook".Equals(messageType, StringComparison.OrdinalIgnoreCase))
            {
                messageHandler.SetMessageStrategy(new SendFbMsgStrategy());
            }
            else
                Console.WriteLine("Try again...");

            messageHandler.SendMessage(message);
            Console.WriteLine();

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message            
        }
    }
}