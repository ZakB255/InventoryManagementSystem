using System;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AddSampleData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void AddSampleData()
        {
            Inventory.addPart(new Inhouse
            {
                PartID = 1,
                Name = "Wheel",
                Price = 12.11m,
                InStock = 15,
                Min = 5,
                Max = 25,
                MachineID = 123
            });

            Inventory.addPart(new Outsourced
            {
                PartID = 2,
                Name = "Pedal",
                Price = 8.22m,
                InStock = 11,
                Min = 5,
                Max = 25,
                CompanyName = "ABC Parts"
            });

            Inventory.addProduct(new Product
            {
                ProductID = 1,
                Name = "Red Bicycle",
                Price = 15.44m,
                InStock = 15,
                Min = 1,
                Max = 25
            });
        }
    }
}