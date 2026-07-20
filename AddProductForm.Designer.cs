namespace InventoryManagementSystem
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtPrice = new TextBox();
            txtInventory = new TextBox();
            txtName = new TextBox();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnSearch = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dvgAllParts = new DataGridView();
            dvgAssociatedParts = new DataGridView();
            label7 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 0;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(288, 212);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 1;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(95, 212);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(95, 165);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(95, 123);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(125, 27);
            txtInventory.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(757, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(264, 27);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 126);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 165);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Price/Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 215);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 11;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 215);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 12;
            label6.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(300, 19);
            label8.Name = "label8";
            label8.Size = new Size(185, 41);
            label8.TabIndex = 14;
            label8.Text = "Add Product";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(638, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(682, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(854, 459);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(885, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(854, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dvgAllParts
            // 
            dvgAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAllParts.Location = new Point(580, 71);
            dvgAllParts.Name = "dvgAllParts";
            dvgAllParts.RowHeadersWidth = 51;
            dvgAllParts.Size = new Size(441, 153);
            dvgAllParts.TabIndex = 20;
            // 
            // dvgAssociatedParts
            // 
            dvgAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAssociatedParts.Location = new Point(580, 265);
            dvgAssociatedParts.Name = "dvgAssociatedParts";
            dvgAssociatedParts.RowHeadersWidth = 51;
            dvgAssociatedParts.Size = new Size(441, 153);
            dvgAssociatedParts.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(580, 46);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 22;
            label7.Text = "All Candidate Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(580, 242);
            label9.Name = "label9";
            label9.Size = new Size(229, 20);
            label9.TabIndex = 23;
            label9.Text = "Parts Associated with the product";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 500);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(dvgAssociatedParts);
            Controls.Add(dvgAllParts);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(txtName);
            Controls.Add(txtInventory);
            Controls.Add(txtPrice);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(txtID);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)dvgAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgAssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtPrice;
        private TextBox txtInventory;
        private TextBox txtName;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btnSearch;
        private Button btnSave;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dvgAllParts;
        private DataGridView dvgAssociatedParts;
        private Label label7;
        private Label label9;
    }
}