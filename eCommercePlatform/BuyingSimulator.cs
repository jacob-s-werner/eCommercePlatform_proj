using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    class BuyingSimulator
    {
        public void RunSimulator()
        {
            Console.WriteLine("SIMULATION STARTING....");
            
            Consumer Jake = new Consumer();
            Platform platform = new Platform();

            Console.WriteLine("Creating products.....");
            
            Product boots = platform.CreateNewProduct(1,"Boots", "Clothing", 36.99);
            Product shoes = platform.CreateNewProduct(2, "Shoes", "Clothing", 24.99);
            Product pants = platform.CreateNewProduct(3, "Pants", "Clothing", 37.99);
            Product shirt = platform.CreateNewProduct(4, "Shirt", "Clothing", 14.99);

            Console.WriteLine("Populating inventory...");

            platform.PopulateInventory(boots);
            platform.PopulateInventory(shoes);
            platform.PopulateInventory(pants);
            platform.PopulateInventory(shirt);


            platform.UsePlatform(Jake);

            Console.WriteLine("END OF SIMULATION");
            Console.ReadLine();
        }
    }
    
}
