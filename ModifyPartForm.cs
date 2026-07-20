using InventoryManagementSystem.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem
{
    public partial class ModifyPartForm : Form
    {
        private Part selectedPart;

        public ModifyPartForm(Part part)
        {
            InitializeComponent();

            selectedPart = part;

            txtID.Text = selectedPart.PartID.ToString();
            txtName.Text = selectedPart.Name;
            txtInventory.Text = selectedPart.InStock.ToString();
            txtPrice.Text = selectedPart.Price.ToString();
            txtMax.Text = selectedPart.Max.ToString();
            txtMin.Text = selectedPart.Min.ToString();

            txtID.ReadOnly = true;

            if (selectedPart is Inhouse inhousePart)
            {
                rbInhouse.Checked = true;
                lblMachineCompany.Text = "Machine ID";
                txtMachineCompany.Text = inhousePart.MachineID.ToString();
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                rbOutsourced.Checked = true;
                lblMachineCompany.Text = "Company Name";
                txtMachineCompany.Text = outsourcedPart.CompanyName;
            }
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Machine ID";
        }

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Company Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            Part updatedPart;

            if (rbInhouse.Checked)
            {
                updatedPart = new Inhouse
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
                updatedPart = new Outsourced
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

            Inventory.updatePart(selectedPart.PartID, updatedPart);
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
            Close();
        }
    }
}