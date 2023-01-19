using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElasticStoreCollection;
using ElasticStoreCollection.Database;

namespace ElasticStoreCollection.BLL.Implementation
{
    public class ProductServices
    {
        public ProductDB Products { get; } = new ProductDB();
        public void DisplayProducts()
        {
            foreach(var product in Products.ProductList)
            {
                Console.WriteLine($"{product.ID} {product.Name} {product.Quantity} {product.Price} {product.Category} {product.OrderCount}");

            }
        }

        public void DisplaySelectedInfo()
        {
            
            Console.WriteLine($"What options do you want to display\n1. ID\n2. Name\n3. Quantity\n4. Price\n5. Category\n6. OrderCount");
            
            foreach(var product in Products.ProductList)
            {
                
            }
        }
    }
}
