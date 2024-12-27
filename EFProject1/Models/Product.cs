using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
