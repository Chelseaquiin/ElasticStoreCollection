using ElasticStoreCollection.Database;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Xml.Linq;

namespace ElasticStoreCollection.BLL.Implementation
{
    public class ProductServices
    {
        public ProductDB Products { get; } = new ProductDB();

        public void dynamicList()
        {
            dynamic pcs, chairs, tables;

            pcs = new ExpandoObject();
            pcs.ID = 1;
            pcs.Name = "Dell xps";
            pcs.Quantity = 30;
            pcs.Price = 1500;
            pcs.Category = "Pcs";
            pcs.OrderCount = 1000;

            chairs = new ExpandoObject();
            chairs.ID = 2;
            chairs.Name = "Ergonomical Chair";
            chairs.Quantity = 50;
            chairs.Price = 250;
            chairs.Category = "Chairs";
            chairs.OrderCount = 3000;

            tables = new ExpandoObject();
            tables.ID = 3;
            tables.Name = "Tables";
            tables.Quantity = 50;
            tables.Price = 300;
            tables.Category = "Tables";
            tables.OrderCount = 4000;

            ListAllProducts(pcs);
            ListAllProducts(chairs);
            ListAllProducts(tables);

           /* ListSelectedInfo(pcs);
            ListSelectedInfo(chairs);
            ListSelectedInfo(tables);
*/


        }
        public void ListAllProducts(dynamic properties)
        {
            Console.WriteLine($"{properties.ID} {properties.Name} {properties.Quantity} {properties.Price} {properties.Category} {properties.OrderCount}");

        }

        /*public void ListSelectedInfo(dynamic name)
        {
            Console.WriteLine("Input the Details that you want to see\nID, Name, Quantity, Price, Category, or OrderCount\nTo avoid invalid input, separate with a comma");
            string x = Console.ReadLine().ToLower().Replace(" ", "");
            string[] list = x.Split(',');
            foreach (var product in name)
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
        }*/
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
                        dynamicList();
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
