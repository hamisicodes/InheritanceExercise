using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var parakeet = new Bird();
            parakeet.Name = "Parakeet";
            parakeet.NumberOfLegs = 2;
            parakeet.NumberOfFeathers = 3000;
            parakeet.BeakShape = "curved";
            parakeet.Birdfamily = "Parrot";

            Console.WriteLine($"Bird Details:");
            Console.WriteLine($"Name:{parakeet.Name} , Number of Legs:{parakeet.NumberOfLegs}, Bird Family:{parakeet.Birdfamily}");
            Console.WriteLine($"Number of feathers:{parakeet.NumberOfFeathers} , Beak Shape:{parakeet.BeakShape}\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile();
            lizard.Name = "lizard";
            lizard.NumberOfLegs = 4;
            lizard.LivesOnLand = true;
            lizard.LivesInWater = false;
            lizard.HasScales = true;

            Console.WriteLine($"Reptile Details:");
            Console.WriteLine($"Name:{lizard.Name} , Number of Legs:{lizard.NumberOfLegs}, Lives On land ?:{lizard.LivesOnLand}");
            Console.WriteLine($"Lives in water?:{lizard.LivesInWater} , Has Scales?:{lizard.HasScales}");

        }
    }
}
