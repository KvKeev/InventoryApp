using System;
using System.Collections.Generic;
using InventoryApp.Models;
using InventoryApp.Services;
using InventoryApp.Views;

namespace InventoryApp.Controllers
{
    public class InventoryController
    {
        private InventoryManager _manager = new InventoryManager();
        private InventoryView _view = new InventoryView();

        public InventoryController(InventoryManager manager, InventoryView view)
        {
            _manager = manager;
            _view = view;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    _view.ShowMenu();
                    int option = _view.ReadInteger("");

                    switch (option)
                    {
                        case 1: AddProduct(); 
                                break;
                        case 2: ViewAllProducts(); 
                                break;
                        case 3: RemoveProduct(); 
                                break;
                        case 4: SearchProduct(); 
                                break;
                        case 5: UpdateStock(); 
                                break;
                        case 0: Exit(); 
                                break;
                        default: _view.ShowMessage("Invalid option", false); 
                                break;
                    }
                }
                catch (Exception ex)
                {
                    _view.ShowMessage($"Error: {ex.Message}", false);
                }
                finally
                {
                    if (Environment.UserInteractive)
                    {
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }

        private void AddProduct()
        {
            Product newProduct = _view.GetNewProductDetails();
            _manager.AddProduct(newProduct);
            _view.ShowMessage($"Product '{newProduct.Name}' added successfully!");
        }

        private void ViewAllProducts()
        {
            List<Product> products = _manager.GetAllProducts();
            _view.ShowProducts(products);
        }

        private void RemoveProduct()
        {
            int id = _view.AskForProductId(ProductAction.Remove);
            _manager.RemoveProductById(id);
            _view.ShowMessage($"Product ID {id} removed.");
        }

        private void SearchProduct()
        {
            int id = _view.AskForProductId(ProductAction.Search);
            Product product = _manager.FindById(id);
            _view.ShowProductDetails(product);
        }

        private void UpdateStock()
        {
            int id = _view.AskForProductId(ProductAction.Update);
            Product product = _manager.FindById(id);

            int newStock = _view.ReadInteger($"New stock (current: {product.Stock}): ");
            product.UpdateStock(newStock);

            _view.ShowMessage($"Product ID {id} updated.");
        }

        private void Exit()
        {
            _view.ShowMessage("Closing inventory system...");
            Environment.Exit(0);
        }
    }
}