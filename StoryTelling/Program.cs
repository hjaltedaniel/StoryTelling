using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryTelling.Objects;

namespace StoryTelling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Storytime app, by the world famous company.");
            Console.WriteLine("Let me start to know your name:");

            Person individualPerson = new Person();
            individualPerson.Name = Console.ReadLine();

            Console.WriteLine("That is a nice name. When were you born?");
            individualPerson.YearOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("And who is your father?");
            individualPerson.FathersName = Console.ReadLine();

            Console.WriteLine("And your lovely and caring mother is?");
            individualPerson.MothersName = Console.ReadLine();

            Console.WriteLine("And in what city did you welcome this world?");
            individualPerson.CityOfBirth = Console.ReadLine();

            Console.WriteLine(individualPerson.LifeStory());

            Console.Read();
        }
    }
}
