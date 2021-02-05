using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class ShoppingCart
    {   /* i.This class represents the consumer’s shopping cart.When a consumer decides on a product they want to purchase, the product will be placed in the shopping cart.*/

        // Member Variables (Has A)
        public List<Product> products;
        public double totalCostProducts;


        // Constructor
        public ShoppingCart()
        {
            products = new List<Product>();
            totalCostProducts = 0;
        }


        //Member Methods (Can do)
        public void UpdateTotalCostOfProducts()
        {
            totalCostProducts = 0;

            foreach (Product product in products)
            {
                totalCostProducts += product.price;
            }
        }
        public void RemoveProductFromCart(Product product)
        {
            products.Remove(product);
            totalCostProducts -= product.price;
        }

    }
}
