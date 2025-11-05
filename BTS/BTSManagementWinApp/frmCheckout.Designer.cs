namespace BTSManagementWinApp
{
    partial class frmCheckout
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
            lbCustomerName = new System.Windows.Forms.Label();
            lbPhone = new System.Windows.Forms.Label();
            lbAddress = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            dgvCart = new System.Windows.Forms.DataGridView();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbPay = new System.Windows.Forms.Label();
            lbBackpack = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbVehicel = new System.Windows.Forms.Label();
            txtBackpack = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtVehicel = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            lblTotalPrice = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            cboCOD = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            txtAddressFrom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("VNI-Revue", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(169, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 33);
            label1.TabIndex = 0;
            label1.Text = "Check Out";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new System.Drawing.Point(61, 81);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(49, 20);
            lbCustomerName.TabIndex = 1;
            lbCustomerName.Text = "Name";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(61, 141);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 2;
            lbPhone.Text = "Phone";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new System.Drawing.Point(61, 238);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(25, 20);
            lbAddress.TabIndex = 3;
            lbAddress.Text = "To";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(169, 134);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(248, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(169, 231);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(248, 27);
            txtAddress.TabIndex = 6;
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new System.Drawing.Point(495, 197);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new System.Drawing.Size(411, 157);
            dgvCart.TabIndex = 7;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Location = new System.Drawing.Point(138, 364);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(114, 43);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(326, 364);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(113, 43);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbPay
            // 
            lbPay.AutoSize = true;
            lbPay.Location = new System.Drawing.Point(61, 294);
            lbPay.Name = "lbPay";
            lbPay.Size = new System.Drawing.Size(31, 20);
            lbPay.TabIndex = 10;
            lbPay.Text = "Pay";
            // 
            // lbBackpack
            // 
            lbBackpack.AutoSize = true;
            lbBackpack.Location = new System.Drawing.Point(498, 54);
            lbBackpack.Name = "lbBackpack";
            lbBackpack.Size = new System.Drawing.Size(71, 20);
            lbBackpack.TabIndex = 11;
            lbBackpack.Text = "Backpack";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(501, 99);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 12;
            lbPrice.Text = "Price";
            // 
            // lbVehicel
            // 
            lbVehicel.AutoSize = true;
            lbVehicel.Location = new System.Drawing.Point(501, 155);
            lbVehicel.Name = "lbVehicel";
            lbVehicel.Size = new System.Drawing.Size(56, 20);
            lbVehicel.TabIndex = 13;
            lbVehicel.Text = "Vehicel";
            // 
            // txtBackpack
            // 
            txtBackpack.Location = new System.Drawing.Point(595, 47);
            txtBackpack.Name = "txtBackpack";
            txtBackpack.Size = new System.Drawing.Size(311, 27);
            txtBackpack.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(595, 92);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(311, 27);
            txtPrice.TabIndex = 16;
            // 
            // txtVehicel
            // 
            txtVehicel.Location = new System.Drawing.Point(595, 138);
            txtVehicel.Name = "txtVehicel";
            txtVehicel.Size = new System.Drawing.Size(311, 27);
            txtVehicel.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(506, 368);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 28);
            label2.TabIndex = 18;
            label2.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(788, 368);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(74, 20);
            lblTotalPrice.TabIndex = 19;
            lblTotalPrice.Text = "TotalPrice";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(169, 85);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(248, 27);
            txtCustomerName.TabIndex = 20;
            // 
            // cboCOD
            // 
            cboCOD.AutoSize = true;
            cboCOD.Location = new System.Drawing.Point(169, 290);
            cboCOD.Name = "cboCOD";
            cboCOD.Size = new System.Drawing.Size(62, 24);
            cboCOD.TabIndex = 21;
            cboCOD.Text = "COD";
            cboCOD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 20);
            label3.TabIndex = 22;
            label3.Text = "Address From";
            // 
            // txtAddressFrom
            // 
            txtAddressFrom.AcceptsReturn = true;
            txtAddressFrom.Location = new System.Drawing.Point(169, 185);
            txtAddressFrom.Name = "txtAddressFrom";
            txtAddressFrom.Size = new System.Drawing.Size(247, 27);
            txtAddressFrom.TabIndex = 23;
            // 
            // frmCheckout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(918, 450);
            Controls.Add(txtAddressFrom);
            Controls.Add(label3);
            Controls.Add(cboCOD);
            Controls.Add(txtCustomerName);
            Controls.Add(lblTotalPrice);
            Controls.Add(label2);
            Controls.Add(txtVehicel);
            Controls.Add(txtPrice);
            Controls.Add(txtBackpack);
            Controls.Add(lbVehicel);
            Controls.Add(lbPrice);
            Controls.Add(lbBackpack);
            Controls.Add(lbPay);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dgvCart);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(lbAddress);
            Controls.Add(lbPhone);
            Controls.Add(lbCustomerName);
            Controls.Add(label1);
            Name = "frmCheckout";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Label lbBackpack;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbVehicel;
        private System.Windows.Forms.TextBox txtBackpack;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVehicel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.CheckBox cboCOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddressFrom;
    }
}