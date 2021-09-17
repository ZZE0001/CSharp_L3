using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_HW
{
    class Product
    {
        public string Width { get; }
        public string Length { get; }
        public string Height { get; }
        public string Weigth { get; set; }

        public string SetProduct()
        {
            return $"Creating product...";
        }

        public string GetProduct()
        {
            return $"Getting product...";
        }
    }
}
