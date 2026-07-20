using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadTables();
        }

        private void LoadTables()
        {
            dvgParts.DataSource = Inventory.AllParts;
            dvgProducts.DataSource = Inventory.Products;

            dvgParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dvgParts.MultiSelect = false;
            dvgProducts.MultiSelect = false;

            dvgParts.ReadOnly = true;
            dvgProducts.ReadOnly = true;
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtPartSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dvgParts.DataSource = Inventory.AllParts;
                return;
            }

            BindingList<Part> results = new BindingList<Part>(
                Inventory.AllParts
                .Where(p => p.Name.ToLower().Contains(searchText) || p.PartID.ToString() == searchText)
                .ToList()
            );

            dvgParts.DataSource = results;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm form = new AddPartForm();
            form.ShowDialog();
            LoadTables();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dvgParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }

            Part selectedPart = dvgParts.CurrentRow.DataBoundItem as Part;

            ModifyPartForm form = new ModifyPartForm(selectedPart);
            form.ShowDialog();
            LoadTables();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dvgParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            Part selectedPart = dvgParts.CurrentRow.DataBoundItem as Part;

            foreach (Product product in Inventory.Products)
            {
                if (product.AssociatedParts.Contains(selectedPart))
                {
                    MessageBox.Show("Cannot delete a part that is associated with a product.");
                    return;
                }
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this part?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Inventory.deletePart(selectedPart);
                LoadTables();
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtProductSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dvgProducts.DataSource = Inventory.Products;
                return;
            }

            BindingList<Product> results = new BindingList<Product>(
                Inventory.Products
                .Where(p => p.Name.ToLower().Contains(searchText) || p.ProductID.ToString() == searchText)
                .ToList()
            );

            dvgProducts.DataSource = results;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();
            LoadTables();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dvgProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            Product selectedProduct = dvgProducts.CurrentRow.DataBoundItem as Product;

            ModifyProductForm form = new ModifyProductForm(selectedProduct);
            form.ShowDialog();
            LoadTables();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dvgProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selectedProduct = dvgProducts.CurrentRow.DataBoundItem as Product;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Inventory.removeProduct(selectedProduct.ProductID);
                LoadTables();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}