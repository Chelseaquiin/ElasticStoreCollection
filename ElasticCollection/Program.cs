using ElasticStoreCollection;
using ElasticStoreCollection.BLL.Implementation;

namespace ElasticCollection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ProductServices ps = new();

            ps.DisplayProducts();
        }
    }
}