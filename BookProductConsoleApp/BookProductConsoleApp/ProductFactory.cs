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
        public IProduct GetProduct(int productType)
        {
            Type type = ProductTypeMap.GetProductType(productType);
            IProduct product =  (IProduct)Activator.CreateInstance(type);
            return product;
        }
    }

}
