using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Services
{
    public class InventoryManager
    {
        private List<Product> products = new List<Product>();


        public Product FindById(int id)
        {

            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative.");
            }

            if (products.Count == 0)
            {
                throw new InvalidOperationException("No products available.");
            }

            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                throw new KeyNotFoundException($"Product with Id {id} not found.");
            }

            return product;
        }
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }

            if (product.Id < 0)
            {
                throw new ArgumentException("Product Id cannot be negative.");
            }

           if(products.Any(p => p.Id == product.Id))
            {
                throw new InvalidOperationException($"Product with Id {product.Id} already exists.");
            }

            products.Add(product);
        }

        public void RemoveProductById(int id)
        {

            var product = FindById(id);
            products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            if (products.Count == 0)
            {
                throw new InvalidOperationException("No products available.");
            }

            return  new List<Product>(products);
        }


    }
}
