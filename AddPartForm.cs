using System;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class AddPartForm : Form
    {
        private static int nextPartID = 3;

        public AddPartForm()
        {
            InitializeComponent();

            txtID.Text = nextPartID.ToString();
            txtID.ReadOnly = true;

            rbInhouse.Checked = true;
            label8.Text = "Machine ID";
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            Part newPart;

            if (rbInhouse.Checked)
            {
                newPart = new Inhouse
                {
                    PartID = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    InStock = int.Parse(txtInventory.Text),
                    Price = decimal.Parse(txtPrice.Text),
                    Max = int.Parse(txtMax.Text),
                    Min = int.Parse(txtMin.Text),
                    MachineID = int.Parse(txtMachineCompany.Text)
                };
            }
            else
            {
                newPart = new Outsourced
                {
                    PartID = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    InStock = int.Parse(txtInventory.Text),
                    Price = decimal.Parse(txtPrice.Text),
                    Max = int.Parse(txtMax.Text),
                    Min = int.Parse(txtMin.Text),
                    CompanyName = txtMachineCompany.Text
                };
            }

            Inventory.addPart(newPart);
            nextPartID++;

            this.Close();
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

            if (rbInhouse.Checked && !int.TryParse(txtMachineCompany.Text, out int machineID))
            {
                MessageBox.Show("Machine ID must be a number.");
                return false;
            }

            if (rbOutsourced.Checked && string.IsNullOrWhiteSpace(txtMachineCompany.Text))
            {
                MessageBox.Show("Company Name is required.");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}