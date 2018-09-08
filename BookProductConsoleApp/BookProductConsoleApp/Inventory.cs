using FactoryPatternAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    class Inventory
    {
        public List<IProduct> CarProductList = new List<IProduct>()
        {
            new CarProduct() {Id=1, Name="Car1", IsBooked=false, Price=100 },
            new CarProduct() {Id=2, Name="Car2", IsBooked=false, Price=200  },
            new CarProduct() {Id=3, Name="Car3", IsBooked=false, Price=500  },
        };

        public List<IProduct> HotelProductList = new List<IProduct>()
        {
            new HotelProduct() {Id=1, Name="Hotel1", IsBooked=false, Price=500  },
            new HotelProduct() {Id=2, Name="Hotel2", IsBooked=false, Price=400  },
            new HotelProduct() {Id=3, Name="Hotel3", IsBooked=false, Price=300  },
        };

        public List<IProduct> ActivityProductList = new List<IProduct>()
        {
            new ActivityProduct() {Id=1, Name="Activity1", IsBooked=false, Price=100  },
            new ActivityProduct() {Id=2, Name="Activity2", IsBooked=false, Price=200  },
            new ActivityProduct() {Id=3, Name="Activity3", IsBooked=false, Price=300  },
        };

        public List<IProduct> AirProductList = new List<IProduct>()
        {
            new AirProduct() {Id=1, Name="Air1", IsBooked=false, Price=100  },
            new AirProduct() {Id=2, Name="Air2", IsBooked=false, Price=200  },
            new AirProduct() {Id=3, Name="Air3", IsBooked=false, Price=700  },
        };
    }
}
