using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_HW
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }

        private int Age {
            get {
                return GetAge();
            }
        }

        public string GetGreeting()
        {
            return $"Hello, my name is {Name} {Surname} and I am {Age} years old.";
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            return age;
        }

    }
}
