using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class ActivityProduct : IProduct
    {
        
        public void Book()
        {
            Console.WriteLine("Acitivity Product Booked");
        }

        public string GetTypeOfProduct()
        {
            return "ActivityProduct";
        }

        public void Save()
        {
            Console.WriteLine("Acitivity Product Saved");
        }
    }
}
