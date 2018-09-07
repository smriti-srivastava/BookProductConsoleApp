using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternAssignment;

namespace BookProductConsoleApp
{
    class ProductService : IProductService
    {
        public void Book(IProduct product, IRepository<IProduct> repository)
        {
            product.IsBooked = true;
            repository.Save(product);
            Logger.getLogger().LogMessage("Product Booked");
        }

        public void Save(IProduct product, IRepository<IProduct> repository)
        {
            repository.Save(product);
            Logger.getLogger().LogMessage("Product Saved");
        }
    }
}
