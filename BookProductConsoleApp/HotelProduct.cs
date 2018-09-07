using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class HotelProduct : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Hotel Booked");
        }

        public string GetTypeOfProduct()
        {
            return "Hotel";
        }

        public void Save()
        {
            Console.WriteLine("Hotel Saved");
        }
    }
}
