namespace BTSManagementWinApp
{
    partial class frmBill
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
            dgvCart = new System.Windows.Forms.DataGridView();
            btnHome = new System.Windows.Forms.Button();
            lbPhone = new System.Windows.Forms.Label();
            lbCustomer = new System.Windows.Forms.Label();
            lbAddressShip = new System.Windows.Forms.Label();
            lbBackpack = new System.Windows.Forms.Label();
            lbVehicel = new System.Windows.Forms.Label();
            lbTotal = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtBackpack = new System.Windows.Forms.TextBox();
            txtVehicel = new System.Windows.Forms.TextBox();
            lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("VNI-Silver", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(168, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 29);
            label1.TabIndex = 0;
            label1.Text = "Bill";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new System.Drawing.Point(34, 301);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new System.Drawing.Size(371, 150);
            dgvCart.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnHome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHome.Location = new System.Drawing.Point(156, 538);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(124, 43);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(34, 117);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Phone";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new System.Drawing.Point(34, 70);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new System.Drawing.Size(72, 20);
            lbCustomer.TabIndex = 4;
            lbCustomer.Text = "Customer";
            // 
            // lbAddressShip
            // 
            lbAddressShip.AutoSize = true;
            lbAddressShip.Location = new System.Drawing.Point(34, 167);
            lbAddressShip.Name = "lbAddressShip";
            lbAddressShip.Size = new System.Drawing.Size(91, 20);
            lbAddressShip.TabIndex = 5;
            lbAddressShip.Text = "AddressShip";
            // 
            // lbBackpack
            // 
            lbBackpack.AutoSize = true;
            lbBackpack.Location = new System.Drawing.Point(34, 215);
            lbBackpack.Name = "lbBackpack";
            lbBackpack.Size = new System.Drawing.Size(75, 20);
            lbBackpack.TabIndex = 6;
            lbBackpack.Text = "Back pack";
            // 
            // lbVehicel
            // 
            lbVehicel.AutoSize = true;
            lbVehicel.Location = new System.Drawing.Point(34, 259);
            lbVehicel.Name = "lbVehicel";
            lbVehicel.Size = new System.Drawing.Size(56, 20);
            lbVehicel.TabIndex = 7;
            lbVehicel.Text = "Vehicel";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotal.Location = new System.Drawing.Point(40, 474);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(65, 28);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "Total ";
            // 
            // txtCustomerName
            // 
            txtCustomerName.ForeColor = System.Drawing.SystemColors.Window;
            txtCustomerName.Location = new System.Drawing.Point(166, 70);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(239, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(166, 117);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(239, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(167, 164);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(238, 27);
            txtAddress.TabIndex = 10;
            // 
            // txtBackpack
            // 
            txtBackpack.Location = new System.Drawing.Point(166, 215);
            txtBackpack.Name = "txtBackpack";
            txtBackpack.Size = new System.Drawing.Size(239, 27);
            txtBackpack.TabIndex = 11;
            // 
            // txtVehicel
            // 
            txtVehicel.Location = new System.Drawing.Point(168, 260);
            txtVehicel.Name = "txtVehicel";
            txtVehicel.Size = new System.Drawing.Size(237, 27);
            txtVehicel.TabIndex = 12;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalPrice.Location = new System.Drawing.Point(299, 474);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(106, 28);
            lblTotalPrice.TabIndex = 13;
            lblTotalPrice.Text = "TotalPrice";
            // 
            // frmBill
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(452, 621);
            Controls.Add(lblTotalPrice);
            Controls.Add(txtVehicel);
            Controls.Add(txtBackpack);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(lbTotal);
            Controls.Add(lbVehicel);
            Controls.Add(lbBackpack);
            Controls.Add(lbAddressShip);
            Controls.Add(lbCustomer);
            Controls.Add(lbPhone);
            Controls.Add(btnHome);
            Controls.Add(dgvCart);
            Controls.Add(label1);
            Name = "frmBill";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBill";
            Load += frmBill_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbAddressShip;
        private System.Windows.Forms.Label lbBackpack;
        private System.Windows.Forms.Label lbVehicel;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBackpack;
        private System.Windows.Forms.TextBox txtVehicel;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dgvCart;
    }
}