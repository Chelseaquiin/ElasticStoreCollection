using ElasticStoreCollection.Database;
using System;
using System.Collections.Generic;

namespace ElasticStoreCollection.BLL.Implementation
{
    public class ProductServices
    {
        public ProductDB pd = new ProductDB();
        public ProductDB Products { get; } = new ProductDB();
        public void DisplayProducts()
        {
            foreach (var product in Products.ProductList)
            {
                Console.WriteLine($"{product.ID} {product.Name} {product.Quantity} {product.Price} {product.Category} {product.OrderCount}");

            }
            
        }

        public void DisplaySelectedInfo()
        {
            Console.WriteLine("Input the Details that you want to see\nID, Name, Quantity, Price, Category, or OrderCount\nTo avoid invalid input, separate with a comma");
            string x = Console.ReadLine().ToLower().Replace(" ", "");
            string[] list = x.Split(',');
            foreach (var product in Products.ProductList)
            {
                foreach (var item in list)
                {
                    switch (item)
                    {
                        case "id":
                            Console.Write($"{product.ID} ");
                            break;
                        case "name":
                            Console.Write($"{product.Name} ");
                            break;
                        case "quantity":
                            Console.Write($"{product.Quantity} ");
                            break;
                        case "price":
                            Console.Write($"{product.Price} ");
                            break;
                        case "category":
                            Console.Write($"{product.Category} ");
                            break;
                        case "ordercount":
                            Console.Write($"{product.OrderCount} ");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("Please select an option\n1. Display all products and details\n2. Select the details you want to see\n3. Exit");

                int UserInput;

                int.TryParse(Console.ReadLine(), out UserInput);

                switch (UserInput)
                {
                    case 1:
                        Console.Clear();
                        DisplayProducts();
                        break;
                    case 2:
                        Console.Clear();
                        DisplaySelectedInfo();
                        break;
                    case 3:
                        Console.WriteLine("Bye");
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
        }
    }
}
