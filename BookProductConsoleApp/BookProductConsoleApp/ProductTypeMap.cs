using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    public static class ProductTypeMap
    {
        private static Dictionary<int, Type> productType = new Dictionary<int, Type> {
            {1, Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.AirProduct") },
            {2, Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.ActivityProduct") },
            {3, Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.CarProduct") },
            {4, Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.HotelProduct") }
        };
        public static Type GetProductType(int productTypeId)
        {
            return productType[productTypeId];
        }   
    }
}
