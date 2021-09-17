using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_HW
{
    class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string Height { get; set; }

        public string Call()
        {
            return $"Calling...";
        }

        public void SendSms()
        {
           
        }
    }
}
