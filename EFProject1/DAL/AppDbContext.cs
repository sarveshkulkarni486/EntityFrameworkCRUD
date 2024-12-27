using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFProject1.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDetails;Integrated Security=True");
        }
    }
}
