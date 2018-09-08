using BookProductConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternAssignment
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Logger.getLogger().LogMessage("In Main");
            int choice;
            ProductFactory productFactory = new ProductFactory();
            InventoryDecorator inventory = new InventoryDecorator();
            IRepository<IProduct> repository=null;
            while (true)
            {
                Console.WriteLine("-----PRODUCT MENU-----");
                Console.WriteLine("1. Air Product");
                Console.WriteLine("2. Acivity Product");
                Console.WriteLine("3. Car Product");
                Console.WriteLine("4. Hotel Prodcuct");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter Your Choice");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 5)
                {
                    Logger.getLogger().LogMessage("End Of Main");
                    Environment.Exit(0);
                }
                IProduct product = productFactory.GetProduct(choice);
                List<IProduct> productList = inventory.GetProductList(choice);
                Console.WriteLine("-----LIST OF AVAILABLE PRODUCTS-----");
                Console.WriteLine("Product Id\tProduct Name\tProduct Price");
                for (int index = 0; index < productList.Count; index++)
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", productList[index].Id, productList[index].Name, productList[index].Price);
                Console.WriteLine("Enter Your Choice ");
                choice = Int32.Parse(Console.ReadLine());
                product.Id = productList[choice - 1].Id;
                product.Name = productList[choice - 1].Name;
                product.Price = productList[choice - 1].Price;
                product.IsBooked = productList[choice - 1].IsBooked;
                Console.WriteLine("-----OPERATION MENU-----");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Save");
                Console.WriteLine("Enter Your Choice ");
                int operationChoice = Int32.Parse(Console.ReadLine());
                IProductService productService = new ProductService();
                Console.WriteLine("-----REPOSITORY OPTIONS-----");
                Console.WriteLine("1. File");
                Console.WriteLine("2. SQL DB");
                int repoChoice = Int32.Parse(Console.ReadLine());
                if(repoChoice == 1)
                {
                    repository = new SaveFileRepository();
                }
                else if(repoChoice == 2)
                {
                    repository = new SQLRepository();
                }
                if (operationChoice == 1)
                    productService.Book(product, repository);
                else if (operationChoice == 2)
                    productService.Save(product, repository);
            }
        }
    }
}
