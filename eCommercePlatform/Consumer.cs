using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Consumer
    {
        /*  i.	This class represents the consumer who wants to search products and purchase products. 
         *  We will need to keep track of their information to better assist them.*/
       
            
        // Member Variables (Has A)
        public string firstName;
        public string lastName;
        public ShoppingCart shoppingCart;

        // Constructor
        public Consumer()
        {
            Console.WriteLine("CREATING NEW CONSUMER");
            shoppingCart = new ShoppingCart();
        }


        //Member Methods (Can do)
        public void SetConsumerFirstName()
        {
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            
            Console.WriteLine($"Your new first name is {firstName}");
        }

        public void SetConsumerLastName()
        {
            Console.WriteLine("Enter your Last Name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Your new first name is {lastName}");
        }

        public void SearchProductName(List<Product> inventory)
        {
            string userResponse;
            bool foundProductMatch;
            bool tryAgain = true;

            while (tryAgain)
            {
                foundProductMatch = false;

                Console.WriteLine("Enter the product name you are searching for: ");
                string userProductNameSearch = Console.ReadLine();

                foreach (Product product in inventory)
                {
                    if (userProductNameSearch == product.name)
                    {
                        PrintProductInformation(product);
                        foundProductMatch = true;
                    }
                }

                if (!foundProductMatch)
                {
                    Console.WriteLine("No product match found... Would you like to search for a different product? [Type Y/N] ");
                    userResponse = Console.ReadLine();
                    if (userResponse != "Y" || userResponse == "y")
                    {
                        tryAgain = false;
                    }
                }
            }

        }

        public void PrintProductInformation(Product product)
        {
            Console.WriteLine($"The product {product.name}");
            Console.WriteLine($"price is ${product.price}");
            Console.WriteLine($"Average rating is {product.averageRating}");
            
            // Console.WriteLine($"category is {product.category}");
            // Console.WriteLine($"{product.uniqueIdentifier}");
            // gotta make list run through and display each Console.WriteLine($"Reviews -- {product.reviews}");
        }

        public void AddProductToShoppingCart(Product product)
        {
            shoppingCart.products.Add(product);
            Console.WriteLine($"{product} is added to your cart!");
        }

        public Review CreateProductRatingAndReview(double rating, string text)
        {
            Review review = new Review(rating, text);

            return review;
        }
    }
}
