namespace InventoryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvgParts = new DataGridView();
            dvgProducts = new DataGridView();
            txtProductSearch = new TextBox();
            txtPartSearch = new TextBox();
            btnPartSearch = new Button();
            btnAddPart = new Button();
            btnModifyPart = new Button();
            btnDeletePart = new Button();
            btnProductSearch = new Button();
            btnAddProduct = new Button();
            btnModifyProduct = new Button();
            btnDeleteProduct = new Button();
            btnExit = new Button();
            lblProducts = new Label();
            lblParts = new Label();
            lblInventoryManagementSystem = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).BeginInit();
            SuspendLayout();
            // 
            // dvgParts
            // 
            dvgParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgParts.Location = new Point(12, 81);
            dvgParts.Name = "dvgParts";
            dvgParts.RowHeadersWidth = 51;
            dvgParts.Size = new Size(479, 330);
            dvgParts.TabIndex = 0;
            // 
            // dvgProducts
            // 
            dvgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducts.GridColor = SystemColors.Menu;
            dvgProducts.Location = new Point(562, 81);
            dvgProducts.Name = "dvgProducts";
            dvgProducts.RowHeadersWidth = 51;
            dvgProducts.Size = new Size(488, 330);
            dvgProducts.TabIndex = 1;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(743, 48);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(207, 27);
            txtProductSearch.TabIndex = 2;
            // 
            // txtPartSearch
            // 
            txtPartSearch.Location = new Point(177, 47);
            txtPartSearch.Name = "txtPartSearch";
            txtPartSearch.Size = new Size(214, 27);
            txtPartSearch.TabIndex = 3;
            // 
            // btnPartSearch
            // 
            btnPartSearch.Location = new Point(397, 46);
            btnPartSearch.Name = "btnPartSearch";
            btnPartSearch.Size = new Size(94, 29);
            btnPartSearch.TabIndex = 4;
            btnPartSearch.Text = "Search";
            btnPartSearch.UseVisualStyleBackColor = true;
            btnPartSearch.Click += btnPartSearch_Click;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(12, 417);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(94, 29);
            btnAddPart.TabIndex = 5;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnModifyPart
            // 
            btnModifyPart.Location = new Point(152, 417);
            btnModifyPart.Name = "btnModifyPart";
            btnModifyPart.Size = new Size(94, 29);
            btnModifyPart.TabIndex = 6;
            btnModifyPart.Text = "Modify";
            btnModifyPart.UseVisualStyleBackColor = true;
            btnModifyPart.Click += btnModifyPart_Click;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(279, 417);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(94, 29);
            btnDeletePart.TabIndex = 7;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnProductSearch
            // 
            btnProductSearch.Location = new Point(956, 48);
            btnProductSearch.Name = "btnProductSearch";
            btnProductSearch.Size = new Size(94, 29);
            btnProductSearch.TabIndex = 9;
            btnProductSearch.Text = "Search";
            btnProductSearch.UseVisualStyleBackColor = true;
            btnProductSearch.Click += btnProductSearch_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(589, 417);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 10;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnModifyProduct
            // 
            btnModifyProduct.Location = new Point(711, 417);
            btnModifyProduct.Name = "btnModifyProduct";
            btnModifyProduct.Size = new Size(94, 29);
            btnModifyProduct.TabIndex = 11;
            btnModifyProduct.Text = "Modify";
            btnModifyProduct.UseVisualStyleBackColor = true;
            btnModifyProduct.Click += btnModifyProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(828, 417);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(94, 29);
            btnDeleteProduct.TabIndex = 12;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(985, 436);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 72);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducts.Location = new Point(562, 35);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(135, 41);
            lblProducts.TabIndex = 14;
            lblProducts.Text = "Products";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParts.Location = new Point(12, 37);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(82, 41);
            lblParts.TabIndex = 15;
            lblParts.Text = "Parts";
            // 
            // lblInventoryManagementSystem
            // 
            lblInventoryManagementSystem.AutoSize = true;
            lblInventoryManagementSystem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryManagementSystem.Location = new Point(306, 2);
            lblInventoryManagementSystem.Name = "lblInventoryManagementSystem";
            lblInventoryManagementSystem.Size = new Size(431, 41);
            lblInventoryManagementSystem.TabIndex = 16;
            lblInventoryManagementSystem.Text = "Inventory Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 522);
            Controls.Add(lblInventoryManagementSystem);
            Controls.Add(lblParts);
            Controls.Add(lblProducts);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnModifyProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnProductSearch);
            Controls.Add(btnDeletePart);
            Controls.Add(btnModifyPart);
            Controls.Add(btnAddPart);
            Controls.Add(btnPartSearch);
            Controls.Add(txtPartSearch);
            Controls.Add(txtProductSearch);
            Controls.Add(dvgProducts);
            Controls.Add(dvgParts);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgParts;
        private DataGridView dvgProducts;
        private TextBox txtProductSearch;
        private TextBox txtPartSearch;
        private Button btnPartSearch;
        private Button btnAddPart;
        private Button btnModifyPart;
        private Button btnDeletePart;
        private Button btnProductSearch;
        private Button btnAddProduct;
        private Button btnModifyProduct;
        private Button btnDeleteProduct;
        private Button btnExit;
        private Label lblProducts;
        private Label lblParts;
        private Label lblInventoryManagementSystem;
    }
}
