using System;

namespace ConsoleApp3_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person
            var person = new Person
            {
                Name = "Janis",
                Surname = "Berzins",
                DateOfBirth = new DateTime(2000, 12, 26),
                Gender = "Male",
                Hobby = "Hockey"
            };

            Console.WriteLine(person.GetGreeting());
            Console.WriteLine();

            // Car
            Car car = new Car();
            car.Brand = "Audi";
            car.Number = "AA-1010";
            car.Speed = 0;

            car.SpeedUp(30);

            Console.WriteLine($"After speeding up, car's speed is {car.Speed} km/h.");

            car.StopRide();

            Console.WriteLine($"After stopping, car's speed is {car.Speed} km/h.");
        }
    }
}
