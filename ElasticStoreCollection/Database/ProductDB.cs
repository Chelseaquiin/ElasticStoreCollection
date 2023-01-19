using ElasticStoreCollection.Domain;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ElasticStoreCollection.Database
{
    public class ProductDB
    {
        public IList<Product> ProductList { get; set; } = new List<Product> 
        {
            new Product(){ID = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000},
            new Product(){ID = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chair", OrderCount = 4000},
            new Product(){ID = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000}
        };

    }
}
