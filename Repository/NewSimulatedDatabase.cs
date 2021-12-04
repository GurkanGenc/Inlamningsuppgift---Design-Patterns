using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class NewSimulatedDatabase : IDataRepository
    {
        public string Load(string v)
        {
            return v;
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving new data \"{data}\"");
        }
    }
}
