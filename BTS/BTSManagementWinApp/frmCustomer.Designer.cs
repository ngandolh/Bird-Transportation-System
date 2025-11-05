namespace BTSManagementWinApp
{
    partial class frmCustomer
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
            txtDelAcc = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtAddress = new System.Windows.Forms.TextBox();
            lbAddress = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtCustomerID = new System.Windows.Forms.TextBox();
            lbPhone = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbCustomerName = new System.Windows.Forms.Label();
            lbCustomerID = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtDelAcc
            // 
            txtDelAcc.Location = new System.Drawing.Point(127, 293);
            txtDelAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDelAcc.Name = "txtDelAcc";
            txtDelAcc.Size = new System.Drawing.Size(115, 22);
            txtDelAcc.TabIndex = 27;
            txtDelAcc.Text = "Delete Account";
            txtDelAcc.UseVisualStyleBackColor = true;
            txtDelAcc.Click += txtDelAcc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(132, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 20);
            label1.TabIndex = 26;
            label1.Text = "Information";
            label1.Click += label1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(250, 293);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 22);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(38, 293);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(82, 22);
            btnSave.TabIndex = 24;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(160, 245);
            txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(172, 23);
            txtAddress.TabIndex = 23;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new System.Drawing.Point(57, 247);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(49, 15);
            lbAddress.TabIndex = 22;
            lbAddress.Text = "Address";
            lbAddress.Click += lbAddress_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(160, 201);
            txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(172, 23);
            txtPhone.TabIndex = 21;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(160, 153);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(172, 23);
            txtPassword.TabIndex = 20;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(160, 110);
            txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(172, 23);
            txtCustomerName.TabIndex = 19;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(160, 65);
            txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(172, 23);
            txtCustomerID.TabIndex = 18;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(71, 201);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(41, 15);
            lbPhone.TabIndex = 17;
            lbPhone.Text = "Phone";
            lbPhone.Click += lbPhone_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(57, 155);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 16;
            lbPassword.Text = "Password";
            lbPassword.Click += lbPassword_Click;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new System.Drawing.Point(29, 112);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(91, 15);
            lbCustomerName.TabIndex = 15;
            lbCustomerName.Text = "CustomerName";
            lbCustomerName.Click += lbCustomerName_Click;
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new System.Drawing.Point(42, 65);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(70, 15);
            lbCustomerID.TabIndex = 14;
            lbCustomerID.Text = "CustomerID";
            lbCustomerID.Click += lbCustomerID_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(360, 338);
            Controls.Add(txtDelAcc);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(lbAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(lbPhone);
            Controls.Add(lbPassword);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCustomerID);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtDelAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerID;
    }
}