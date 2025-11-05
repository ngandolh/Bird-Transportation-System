namespace BTSManagementWinApp
{
    partial class frmRegisterCus
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
            label1 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtAddress = new System.Windows.Forms.TextBox();
            lbAddress = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            lbPhone = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbCustomerName = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(168, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 25);
            label1.TabIndex = 25;
            label1.Text = "Register";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(271, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(87, 419);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(168, 323);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(196, 27);
            txtAddress.TabIndex = 22;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new System.Drawing.Point(50, 325);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(62, 20);
            lbAddress.TabIndex = 21;
            lbAddress.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(168, 264);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(196, 27);
            txtPhone.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(168, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(196, 27);
            txtPassword.TabIndex = 19;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(168, 143);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(196, 27);
            txtCustomerName.TabIndex = 18;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(66, 264);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 16;
            lbPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(50, 203);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 15;
            lbPassword.Text = "Password";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new System.Drawing.Point(18, 145);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(112, 20);
            lbCustomerName.TabIndex = 14;
            lbCustomerName.Text = "CustomerName";
            // 
            // frmRegisterCus
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(408, 483);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(lbAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtCustomerName);
            Controls.Add(lbPhone);
            Controls.Add(lbPassword);
            Controls.Add(lbCustomerName);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmRegisterCus";
            Text = "Register Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCustomerName;
    }
}