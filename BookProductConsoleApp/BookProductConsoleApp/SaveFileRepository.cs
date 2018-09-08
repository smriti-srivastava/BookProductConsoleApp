using FactoryPatternAssignment;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    class SaveFileRepository: IFileRepository<IProduct>
    {
        private string _filePath;
        public SaveFileRepository()
        {
            this._filePath = @"C:\SaveFile.txt";
        }
        public void Save(IProduct product)
        {
            File.AppendAllText(this._filePath, "Product Type: "+ product.GetTypeOfProduct() + "| Product Id:" + product.Id + "| Product Name:"+ product.Name + "| Prodcut Price: "+ product.Price+"| Is Product Booked:" + product.IsBooked + Environment.NewLine);
            Logger.getLogger().LogMessage("Product Saved To File");
        }
    }
}
