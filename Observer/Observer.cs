using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Email email = new();
            EmailWatcher emailWatcher = new();

            Console.WriteLine("Observer");
            email.RegisterObserver(emailWatcher);

            email.UpdateMessage();

            Console.WriteLine();
        }
    }
}
