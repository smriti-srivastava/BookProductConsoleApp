using FactoryPatternAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    interface IFileRepository<T>:IRepository<T> where T:class
    {
        void Save(T content);
    }
}
