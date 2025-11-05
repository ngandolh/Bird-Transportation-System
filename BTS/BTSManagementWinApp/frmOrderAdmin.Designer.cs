namespace BTSManagementWinApp
{
    partial class frmOrderAdmin
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
            dgvOrder = new System.Windows.Forms.DataGridView();
            btnCancel = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            lbOrderID = new System.Windows.Forms.Label();
            lbCustomer = new System.Windows.Forms.Label();
            lbOrderDate = new System.Windows.Forms.Label();
            lbOrderStatus = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtOrderDate = new System.Windows.Forms.TextBox();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new System.Drawing.Point(10, 54);
            dgvOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new System.Drawing.Size(821, 289);
            dgvOrder.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.White;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(1012, 309);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(106, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnStart
            // 
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnStart.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(968, 206);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(150, 37);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(861, 54);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(48, 15);
            lbOrderID.TabIndex = 3;
            lbOrderID.Text = "OrderID";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new System.Drawing.Point(861, 86);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new System.Drawing.Size(94, 15);
            lbCustomer.TabIndex = 4;
            lbCustomer.Text = "Customer Name";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(861, 122);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(61, 15);
            lbOrderDate.TabIndex = 5;
            lbOrderDate.Text = "OrderDate";
            // 
            // lbOrderStatus
            // 
            lbOrderStatus.AutoSize = true;
            lbOrderStatus.Location = new System.Drawing.Point(872, 160);
            lbOrderStatus.Name = "lbOrderStatus";
            lbOrderStatus.Size = new System.Drawing.Size(39, 15);
            lbOrderStatus.TabIndex = 6;
            lbOrderStatus.Text = "Status";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(977, 52);
            txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(141, 23);
            txtOrderID.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(977, 86);
            txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(141, 23);
            txtCustomerName.TabIndex = 11;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new System.Drawing.Point(977, 122);
            txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(141, 23);
            txtOrderDate.TabIndex = 12;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(977, 160);
            txtOrderStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new System.Drawing.Size(141, 23);
            txtOrderStatus.TabIndex = 13;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.White;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogout.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(1012, 385);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(106, 34);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmOrderAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1141, 430);
            Controls.Add(btnLogout);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtOrderDate);
            Controls.Add(txtCustomerName);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderStatus);
            Controls.Add(lbOrderDate);
            Controls.Add(lbCustomer);
            Controls.Add(lbOrderID);
            Controls.Add(btnStart);
            Controls.Add(btnCancel);
            Controls.Add(dgvOrder);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmOrderAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmOrderAdmin";
            Load += frmOrderAdmin_Load;
            Click += frmOrderAdmin_Click;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}