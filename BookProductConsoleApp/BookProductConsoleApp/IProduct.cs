using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    interface IProduct
    {
        Boolean IsBooked { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        float Price { get; set; }
        string GetTypeOfProduct();

    }
}
