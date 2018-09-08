using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class HotelProduct : IProduct
    {
        public int Id { get; set; }
        public Boolean IsBooked { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public void Book()
        {
            Console.WriteLine("Hotel Booked");
        }
        public string GetTypeOfProduct()
        {
            return "HotelProduct";
        }
    }
}
