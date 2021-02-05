using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Platform
    {
        /*i.This class represents the eCommerce platform where most of the action will take place. 
         * It is the most top-level object in your application. */

        // Member Variables (Has A)
        public List<Product> inventory;

        // Constructor
        public Platform()
        {
            inventory = new List<Product>();
        }


        //Member Methods (Can do)
        public Product CreateNewProduct(int uniqueIdentifier, string name, string category, double price)
        {
            Product product = new Product(uniqueIdentifier, name, category, price);

            return product;
        }
        public void PopulateInventory(Product product)
        {
            inventory.Add(product);
        }
        public void UsePlatform(Consumer consumer)
        {
            bool keepRunningProgram = true;

            while (keepRunningProgram)
            {
                Console.WriteLine("Welcome to WasteMoney.com!");
                Console.WriteLine("/n Type the associated number to access each action.");

                Console.WriteLine("1: Search for a product");
                Console.WriteLine("2: Create a product Rating and Review");
                Console.WriteLine("3: EXIT Program");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        consumer.SearchProductName(inventory);
                        break;

                    case "2":
                        consumer.CreateProductRatingAndReview(rating, review);
                        break;

                    case "3":
                        keepRunningProgram = false;
                        break;

                    default:
                        Console.WriteLine("Invalid number, type 1, 2, or 3");
                        break;
                }


            }

            //consumer.AddProductToShoppingCart(product);
            //consumer.CreateProductRatingAndReview(rating, review);



        }
    }
}
