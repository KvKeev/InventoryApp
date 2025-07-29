using InventoryApp.Controllers;
using InventoryApp.Services;
using InventoryApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Inicializar componentes
            var manager = new InventoryManager();
            var view = new InventoryView();
            var controller = new InventoryController(manager, view);

            // 2. Mensaje inicial
            Console.WriteLine("=== INVENTORY SYSTEM ===");

            // 3. Manejo de errores
            try
            {
                controller.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERROR] {ex.Message}");
                Console.WriteLine("Contact support. Press any key to close.");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("\nApplication closed.");
            }

        }
    }
}
