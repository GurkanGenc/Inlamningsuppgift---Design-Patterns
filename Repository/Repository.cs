using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            //var data = SimulatedDatabase.Load("Dataset A");
            //var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
            //var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
            //SimulatedDatabase.Save(data);
            //SimulatedDatabase.Save(customer);
            //SimulatedDatabase.Save(animal);

            NewSimulatedDatabase newSimulatedDatabase = new();

            var data = newSimulatedDatabase.Load("Dataset A");
            var customer = newSimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
            var animal = newSimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
            newSimulatedDatabase.Save(data);
            newSimulatedDatabase.Save(customer);
            newSimulatedDatabase.Save(animal);

            Console.WriteLine();
        }
    }
}