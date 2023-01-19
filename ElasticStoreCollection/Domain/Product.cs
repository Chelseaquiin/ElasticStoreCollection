using System;

namespace ElasticStoreCollection.Domain
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int OrderCount { get; set; }

    }
}
