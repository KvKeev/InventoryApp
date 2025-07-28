using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public Product (int id, string name, int stock, string description, decimal price)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Description = description;
            Price = price;
            CreatedAt = DateTime.Now;

        }

        public void UpdatePrice (decimal newPrice)
        {
            if (newPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            Price = newPrice;
        }

        public void UpdateStock(int newStock)
        {
            if (newStock < 0)
            {
                throw new ArgumentException("Stock cannot be negative.");
            }
            Stock = newStock;
        }

        public void Rename(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            Name = newName;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Stock: {Stock}, Description: {Description}, Price: {Price:C}, CreatedAt: {CreatedAt}";
        }
    }
}
