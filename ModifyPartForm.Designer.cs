namespace InventoryManagementSystem
{
    partial class ModifyPartForm
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
            label1 = new Label();
            rbInhouse = new RadioButton();
            rbOutsourced = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblMachineCompany = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtInventory = new TextBox();
            txtPrice = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            txtMachineCompany = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            // 
            // rbInhouse
            // 
            rbInhouse.AutoSize = true;
            rbInhouse.Checked = true;
            rbInhouse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbInhouse.Location = new Point(189, 26);
            rbInhouse.Name = "rbInhouse";
            rbInhouse.Size = new Size(106, 29);
            rbInhouse.TabIndex = 1;
            rbInhouse.TabStop = true;
            rbInhouse.Text = "In-House";
            rbInhouse.UseVisualStyleBackColor = true;
            rbInhouse.CheckedChanged += rbInhouse_CheckedChanged;
            // 
            // rbOutsourced
            // 
            rbOutsourced.AutoSize = true;
            rbOutsourced.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOutsourced.Location = new Point(338, 26);
            rbOutsourced.Name = "rbOutsourced";
            rbOutsourced.Size = new Size(126, 29);
            rbOutsourced.TabIndex = 2;
            rbOutsourced.Text = "Outsourced";
            rbOutsourced.UseVisualStyleBackColor = true;
            rbOutsourced.CheckedChanged += rbOutsourced_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 77);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 123);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 173);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 215);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 6;
            label5.Text = "Price/Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 251);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 7;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 251);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 8;
            label7.Text = "Min";
            // 
            // lblMachineCompany
            // 
            lblMachineCompany.AutoSize = true;
            lblMachineCompany.Location = new Point(78, 295);
            lblMachineCompany.Name = "lblMachineCompany";
            lblMachineCompany.Size = new Size(132, 20);
            lblMachineCompany.TabIndex = 9;
            lblMachineCompany.Text = "Machine Company";
            // 
            // txtID
            // 
            txtID.Location = new Point(160, 77);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 11;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(160, 166);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(125, 27);
            txtInventory.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 208);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 13;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(121, 248);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 14;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(292, 248);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 15;
            // 
            // txtMachineCompany
            // 
            txtMachineCompany.Location = new Point(216, 292);
            txtMachineCompany.Name = "txtMachineCompany";
            txtMachineCompany.Size = new Size(125, 27);
            txtMachineCompany.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(99, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 52);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(239, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 52);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMachineCompany);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtPrice);
            Controls.Add(txtInventory);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblMachineCompany);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rbOutsourced);
            Controls.Add(rbInhouse);
            Controls.Add(label1);
            Name = "ModifyPartForm";
            Text = "ModifyPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbInhouse;
        private RadioButton rbOutsourced;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblMachineCompany;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtInventory;
        private TextBox txtPrice;
        private TextBox txtMax;
        private TextBox txtMin;
        private TextBox txtMachineCompany;
        private Button btnSave;
        private Button btnCancel;
    }
}