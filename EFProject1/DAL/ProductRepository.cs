using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFProject1.Models;

namespace EFProject1.DAL;

public class ProductRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductRepository()
    {
        _appDbContext = new AppDbContext();
    }

    internal void AddProduct(Product product)
    {
        _appDbContext.products.Add(product);
        _appDbContext.SaveChanges();
        Console.WriteLine("Product added successfully");
    }


    internal List<Product> GetProducts()
    {
        return _appDbContext.products.ToList();
    }

    internal void UpdateProduct(int id, string newname, int newprice)
    {
        var product = _appDbContext.products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            product.Name = newname;
            product.price = newprice;
            _appDbContext.SaveChanges();
            Console.WriteLine("Data updated successfully");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
    internal void DeleteProduct(int id)
    {
        var product = _appDbContext.products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _appDbContext.Remove(product);
            _appDbContext.SaveChanges();
            Console.WriteLine("Product deleted successfully");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
}
