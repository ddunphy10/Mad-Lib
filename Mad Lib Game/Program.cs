//This program is a Mad Libs word game
//Author: Dayton Dunphy

using System;

namespace Mad_Lib_Game
{
    class Program
    {
        static void Main(string[] args)
        {
             // Let the user know that the program is starting:
            Console.WriteLine("The Mad Libs game has begun!");

            // Give the Mad Lib a title:
            string title = "Once upon a time";

            Console.WriteLine(title);

            // Define user input and variables:
            Console.WriteLine("Please enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            string adjective_1 = Console.ReadLine();

            Console.WriteLine("Please enter another adjective: ");
            string adjective_2 = Console.ReadLine();

            Console.WriteLine("Please enter a third adjective: ");
            string adjective_3 = Console.ReadLine();

            Console.WriteLine("Please enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            string noun_1 = Console.ReadLine();

            Console.WriteLine("Please enter another noun: ");
            string noun_2 = Console.ReadLine();

            Console.WriteLine("Please enter an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Please enter a food: ");
            string food = Console.ReadLine();

            Console.WriteLine("Please enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Please enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.WriteLine("Please enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Please enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Please enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:
            string story = $"This morning {name} woke up feeling {adjective_1}. 'It is going to be a {adjective_2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun_1}, " +
                $"which made all the {fruit}s very {adjective_3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun_2}s ruled " +
                $"the world.";

            // Print the story:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(story);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I hope you found this somewhat entertaining?");
            Console.WriteLine();
            Console.WriteLine("The Mad Libs game is over.");

        }
    }
}
