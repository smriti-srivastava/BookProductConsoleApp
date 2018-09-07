using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class AirProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Air Product Booked");
        }

        public string GetTypeOfProduct()
        {
            return "Air";
        }

        public void Save()
        {
            Console.WriteLine("Air Product Saved");
        }

       
    }
}
