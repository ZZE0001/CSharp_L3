using System;

namespace ConsoleApp3_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Janis",
                Surname = "Berzins",
                DateOfBirth = new DateTime(2000, 12, 26),
                Gender = "Male",
                Hobby = "Hockey"
            };

            Console.WriteLine(person.GetGreeting());
        }
    }
}
