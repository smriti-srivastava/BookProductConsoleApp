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
        private static Dictionary<string, Type> productType = new Dictionary<string, Type>{
            {"air", Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.AirProduct") },
            {"car", Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.CarProduct") },
            {"activity", Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.ActivityProduct") },
            {"hotel", Assembly.GetExecutingAssembly().GetType("FactoryPatternAssignment.HotelProduct") }
        };
        public static Type GetProductType(string productName)
        {
            return productType[productName];
        }
    }
}
