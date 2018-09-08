using FactoryPatternAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    class InventoryDecorator
    {
        Inventory inventory;
        ProductFactory productFactory;
        IDisplayPrice displayPriceStrategy;
        public InventoryDecorator()
        {
            inventory = new Inventory();
            productFactory = new ProductFactory();
        }
        public List<IProduct> GetProductList(int choice)
        {
            List<IProduct> productList=null;
            List<IProduct> newProductList = new List<IProduct>();
            switch (choice)
            {
                case 1:
                    {
                        productList = inventory.AirProductList;
                        displayPriceStrategy = new AirDisplayPriceStrategy();
                        break;
                    }
                case 2:
                    {
                        productList = inventory.ActivityProductList;
                        displayPriceStrategy = new AirDisplayPriceStrategy();
                        break;
                    }
                case 3:
                    {
                        productList = inventory.CarProductList;
                        displayPriceStrategy = new CarDisplayPriceStrategy();
                        break;
                    }
                case 4:
                    {
                        productList = inventory.HotelProductList;
                        displayPriceStrategy = new HotelDisplayPriceStrategy();
                        break;
                    }
            }
            foreach (IProduct product in productList)
            {
                IProduct newProduct = productFactory.GetProduct(choice);
                newProduct.Id = product.Id;
                newProduct.Name = product.Name;
                newProduct.Price = displayPriceStrategy.GetTotalFare(product.Price);
                newProduct.IsBooked = false;
                newProductList.Add(newProduct);    
            }
            return newProductList;
        }
    }
}
