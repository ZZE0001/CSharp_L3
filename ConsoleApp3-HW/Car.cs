using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_HW
{
    class Car
    {
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }


        public string StartRide()
        {
            return $"Starting ride...";
        }

        public void SpeedUp(int addedSpeed)
        {
            Speed += addedSpeed;
        }
        public void StopRide()
        {
            Speed = 0;
        }
        public string Beep()
        {
            return $"Beep beep";
        }
    }
}
