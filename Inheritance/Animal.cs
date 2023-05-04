using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Move()
        {
            Console.WriteLine("Moving...");
        }


    }
}
