using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            ProductFactory productFactory = new ProductFactory();
            IProduct product = productFactory.GetProduct(productName);
            product.Book();
            product.Save();
        }
    }
}
