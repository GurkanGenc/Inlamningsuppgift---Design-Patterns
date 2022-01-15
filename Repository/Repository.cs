using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        //private SimulatedDatabase SimulatedDatabase;

        //public Repository(SimulatedDatabase simulatedDatabase)
        //{
        //    SimulatedDatabase = simulatedDatabase;
        //}

        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            var database = new SimulatedDatabase();

            var data = database.GetData();
            var customer = database.GetCustomer();
            var animal = database.GetAnimal();

            database.Save($"New {data}");
            database.Save($"New {customer}");
            database.Save($"New {animal}");

            //var data = SimulatedDatabase.Load("Dataset A");
            //var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
            //var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
            //SimulatedDatabase.Save(data);
            //SimulatedDatabase.Save(customer);
            //SimulatedDatabase.Save(animal);

            Console.WriteLine();
        }
    }
}