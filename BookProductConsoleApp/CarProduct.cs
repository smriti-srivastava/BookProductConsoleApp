using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class CarProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Car Product Booked");
        }

        public string GetTypeOfProduct()
        {
            return "Car";
        }

        public void Save()
        {
            Console.WriteLine("Car Product Saved");
        }
    }
}
