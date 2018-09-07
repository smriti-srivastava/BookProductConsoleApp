using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class ProductFactory
    {
        public IProduct GetProduct(string productName)
        {
            Type type = ProductTypeMap.GetProductType(productName);
            return (IProduct)Activator.CreateInstance(type);
        }
    }

}
