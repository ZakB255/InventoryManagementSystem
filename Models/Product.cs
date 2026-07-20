using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            Part foundPart = AssociatedParts.FirstOrDefault(p => p.PartID == partID);

            if (foundPart != null)
            {
                AssociatedParts.Remove(foundPart);
                return true;
            }

            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }
    }
}