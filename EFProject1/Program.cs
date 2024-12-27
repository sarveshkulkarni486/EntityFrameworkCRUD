using EFProject1.DAL;
using EFProject1.Models;

namespace EFProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productRepo = new ProductRepository();

            productRepo.AddProduct(new Product { Name = "Laptop", price = 1200 });
            var products = productRepo.GetProducts();
            Console.WriteLine("\n----Product List----");
            foreach (var p in products)
            {
                Console.WriteLine($"Product Id: {p.Id}, ProductName: {p.Name}, Product Price: {p.price}, Product MFG Date: {p.CreatedAt}");
            }
            productRepo.UpdateProduct(1, "Gaming Laptop", 1500);

            productRepo.DeleteProduct(1);
        }
    }
}
