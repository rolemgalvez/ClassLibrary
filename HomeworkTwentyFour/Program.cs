using HomeworkTwentyFour.Library;
using HomeworkTwentyFour.Library.Models;
using System;

namespace HomeworkTwentyFour
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                Prefix = "Mr.",
                LastName = "Cruz"
            };
            Messages message = new Messages();

            Console.WriteLine(message.Welcome(person.Prefix, person.LastName));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(message.Farewell(person.Prefix, person.LastName));

            Console.ReadLine();
        }
    }
}
