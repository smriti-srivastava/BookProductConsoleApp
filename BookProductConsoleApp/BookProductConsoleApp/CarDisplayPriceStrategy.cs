using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    class CarDisplayPriceStrategy : IDisplayPrice
    {
        public float GetTotalFare(float totalFare)
        {
            return (totalFare + totalFare * 0.2F);
        }
    }
}
