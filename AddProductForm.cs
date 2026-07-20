using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class AddProductForm : Form
    {
        private static int nextProductID = 2;
        private BindingList<Part> associatedParts = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();

            txtID.Text = nextProductID.ToString();
            txtID.ReadOnly = true;

            dvgAllParts.DataSource = Inventory.AllParts;
            dvgAssociatedParts.DataSource = associatedParts;

            dvgAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dvgAllParts.MultiSelect = false;
            dvgAssociatedParts.MultiSelect = false;

            dvgAllParts.ReadOnly = true;
            dvgAssociatedParts.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dvgAllParts.DataSource = Inventory.AllParts;
                return;
            }

            BindingList<Part> results = new BindingList<Part>(
                Inventory.AllParts
                .Where(p => p.Name.ToLower().Contains(searchText) || p.PartID.ToString() == searchText)
                .ToList()
            );

            dvgAllParts.DataSource = results;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dvgAllParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }

            Part selectedPart = dvgAllParts.CurrentRow.DataBoundItem as Part;

            if (selectedPart != null)
            {
                associatedParts.Add(selectedPart);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show("Please select an associated part to delete.");
                return;
            }

            Part selectedPart = dvgAssociatedParts.CurrentRow.DataBoundItem as Part;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this associated part?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                associatedParts.Remove(selectedPart);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            Product newProduct = new Product
            {
                ProductID = int.Parse(txtID.Text),
                Name = txtName.Text,
                InStock = int.Parse(txtInventory.Text),
                Price = decimal.Parse(txtPrice.Text),
                Max = int.Parse(txtMax.Text),
                Min = int.Parse(txtMin.Text)
            };

            foreach (Part part in associatedParts)
            {
                newProduct.addAssociatedPart(part);
            }

            Inventory.addProduct(newProduct);
            nextProductID++;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }

            if (!int.TryParse(txtInventory.Text, out int inventory))
            {
                MessageBox.Show("Inventory must be a number.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a number.");
                return false;
            }

            if (!int.TryParse(txtMax.Text, out int max))
            {
                MessageBox.Show("Max must be a number.");
                return false;
            }

            if (!int.TryParse(txtMin.Text, out int min))
            {
                MessageBox.Show("Min must be a number.");
                return false;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return false;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return false;
            }

            return true;
        }
    }
}