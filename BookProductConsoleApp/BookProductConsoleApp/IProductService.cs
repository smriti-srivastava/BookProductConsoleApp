using FactoryPatternAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    interface IProductService
    {
        void Save(IProduct product, IRepository<IProduct> repository);
        void Book(IProduct product, IRepository<IProduct> repository);
    }
}
