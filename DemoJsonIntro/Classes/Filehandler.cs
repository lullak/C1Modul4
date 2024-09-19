using System.Text.Json;

namespace DemoJsonIntro.Classes
{
    public class Filehandler
    {
        private readonly string _filePath;

        public Filehandler(string filePath)
        {
            _filePath = filePath;
        }

        public void AddProduct(Product product)
        {
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string productsJSON = reader.ReadToEnd();
                products = JsonSerializer.Deserialize<List<Product>>(productsJSON);
            }

            return products;
        }
    }
}
