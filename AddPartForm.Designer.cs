namespace InventoryManagementSystem
{
    partial class AddPartForm
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
            txtMachineCompany = new TextBox();
            txtInventory = new TextBox();
            txtPrice = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            rbInhouse = new RadioButton();
            rbOutsourced = new RadioButton();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(152, 62);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(185, 27);
            txtID.TabIndex = 0;
            // 
            // txtMachineCompany
            // 
            txtMachineCompany.Location = new Point(152, 308);
            txtMachineCompany.Name = "txtMachineCompany";
            txtMachineCompany.Size = new Size(185, 27);
            txtMachineCompany.TabIndex = 1;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(152, 152);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(185, 27);
            txtInventory.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(152, 198);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(185, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(152, 258);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 4;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(328, 258);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 41);
            label1.TabIndex = 7;
            label1.Text = "Add Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 58);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 8;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 106);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 152);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 10;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 194);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 11;
            label5.Text = "Price/Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(68, 257);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 12;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(272, 258);
            label7.Name = "label7";
            label7.Size = new Size(46, 28);
            label7.TabIndex = 13;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 307);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 14;
            label8.Text = "Machine ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(138, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 64);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(314, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 64);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // rbInhouse
            // 
            rbInhouse.AutoSize = true;
            rbInhouse.Checked = true;
            rbInhouse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbInhouse.Location = new Point(150, 24);
            rbInhouse.Name = "rbInhouse";
            rbInhouse.Size = new Size(106, 29);
            rbInhouse.TabIndex = 17;
            rbInhouse.TabStop = true;
            rbInhouse.Text = "In-House";
            rbInhouse.UseVisualStyleBackColor = true;
            rbInhouse.CheckedChanged += rbInhouse_CheckedChanged;
            // 
            // rbOutsourced
            // 
            rbOutsourced.AutoSize = true;
            rbOutsourced.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOutsourced.Location = new Point(293, 27);
            rbOutsourced.Name = "rbOutsourced";
            rbOutsourced.Size = new Size(126, 29);
            rbOutsourced.TabIndex = 18;
            rbOutsourced.Text = "Outsourced";
            rbOutsourced.UseVisualStyleBackColor = true;
            rbOutsourced.CheckedChanged += rbOutsourced_CheckedChanged;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(rbOutsourced);
            Controls.Add(rbInhouse);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtPrice);
            Controls.Add(txtInventory);
            Controls.Add(txtMachineCompany);
            Controls.Add(txtID);
            Name = "AddPartForm";
            Text = "AddPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtMachineCompany;
        private TextBox txtInventory;
        private TextBox txtPrice;
        private TextBox txtMax;
        private TextBox txtMin;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private RadioButton rbInhouse;
        private RadioButton rbOutsourced;
    }
}