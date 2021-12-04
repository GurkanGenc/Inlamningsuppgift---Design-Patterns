﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer : IObserver
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Email message = new();

            Console.WriteLine("Observer");

            message.UpdateMessage();

            //var email = "";
            //while (string.IsNullOrEmpty(email))
            //{
            //    email = Email();
            //}
            //Console.WriteLine(email);
            Console.WriteLine();
        }

        public void Update(string message)
        {
            throw new NotImplementedException();
        }
    }
}
