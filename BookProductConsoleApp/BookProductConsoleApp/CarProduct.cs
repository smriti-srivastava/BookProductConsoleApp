using BookProductConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class CarProduct : IProduct
    {
        public int Id { get; set; }
        public Boolean IsBooked { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string GetTypeOfProduct()
        {
            return "CarProduct";
        }
    }
}
