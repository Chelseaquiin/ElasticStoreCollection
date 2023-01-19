
using ElasticStoreCollection.BLL.Implementation;

namespace ElasticCollection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            ProductServices ps = new();

            ps.Start();
        }
    }
}