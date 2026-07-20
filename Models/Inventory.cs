using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;

namespace InventoryManagementSystem.Models
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();

        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            Product foundProduct = Products.FirstOrDefault(p => p.ProductID == productID);

            if (foundProduct != null)
            {
                Products.Remove(foundProduct);
                return true;
            }

            return false;
        }

        public static Product lookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public static void updateProduct(int productID, Product newProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = newProduct;
                    break;
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static Part lookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public static void updatePart(int partID, Part newPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = newPart;
                    break;
                }
            }
        }
    }
}