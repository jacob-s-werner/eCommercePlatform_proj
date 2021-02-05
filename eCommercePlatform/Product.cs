using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Product
    {
        /* i.	This class represents the product that is able to be purchased. Each product will have the ability to be rated and reviewed 
         * (we use a List data structure so that we can keep track of multiple reviews for each product)*/

        // Member Variables (Has A)
        public int uniqueIdentifier;
        public string name;
        public string category;
        public double price;
        public double averageRating;
        public List<Review> reviews;

        // Constructor
        public Product(int uniqueIdentifier, string name, string category, double price)
        {
            this.uniqueIdentifier = uniqueIdentifier;
            this.name = name;
            this.category = category;
            this.price = price;
            averageRating = 0;
            reviews = new List<Review>();
        }


        //Member Methods (Can do)
        public void UpdateAverageRating(double rating)
        {
            averageRating += rating;
        }
        public void AddProductReview(Review review)
        {
            reviews.Add(review);

        }

    }
}
