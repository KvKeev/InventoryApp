using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryApp.Models;

namespace InventoryApp.Views
{
    public enum ProductAction
    {
        Remove,
        Search,
        Update
    }

    public class InventoryView
    {

        //view
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== INVENTORY MANAGEMENT ===");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Remove Product");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Update Stock");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
        }

        //new product
        public Product GetNewProductDetails()
        {
            Console.WriteLine("\n--- NEW PRODUCT ---");
            return new Product(
                id: ReadInteger("Product ID: "),
                name: ReadString("Product Name: "),
                stock: ReadInteger("Initial Stock: "),
                description: ReadString("Description: "),
                price: ReadDecimal("Price: ")
            );
        }
        public int AskForProductId(ProductAction action)
        {
            return ReadInteger($"Enter product ID to {action.ToString().ToLower()}: ");
        }

        public void ShowProducts(List<Product> products)
        {
            Console.WriteLine("\n=== PRODUCT LIST ===");
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            foreach (var p in products)
            {
                Console.WriteLine($"[{p.Id}] {p.Name} | Stock: {p.Stock} | Price: {p.Price:C}");
            }
        }

        public void ShowProductDetails(Product product)
        {
            Console.WriteLine("\n--- PRODUCT DETAILS ---");
            Console.WriteLine($"ID: {product.Id}");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Stock: {product.Stock}");
            Console.WriteLine($"Price: {product.Price:C}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"Created: {product.CreatedAt:d}");
        }


        public void ShowMessage(string message, bool isSuccess = true)
        {
            Console.ForegroundColor = isSuccess ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"\n> {message}");
            Console.ResetColor();
        }

        public int ReadInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    ShowMessage("Invalid number. Please try again.", false);
                }
            }
        }

        private decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal result))
                {  
                    return result;
                }
                else
                {
                    ShowMessage("Invalid decimal value. Please try again.", false);
                }
            }
        }

        private string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }
                else
                {
                    ShowMessage("Input cannot be empty.", false);
                }
            }
        }
    }
}