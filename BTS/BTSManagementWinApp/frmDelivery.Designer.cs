namespace BTSManagementWinApp
{
    partial class frmDelivery
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dgvOrderDetail = new System.Windows.Forms.DataGridView();
            lbOrderDetail = new System.Windows.Forms.Label();
            lbAddressFrom = new System.Windows.Forms.Label();
            lbAddressTo = new System.Windows.Forms.Label();
            txtOrderDetailID = new System.Windows.Forms.TextBox();
            txtAddressFrom = new System.Windows.Forms.TextBox();
            txtAddressTo = new System.Windows.Forms.TextBox();
            btnStart = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnFinished = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { processingToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1214, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // processingToolStripMenuItem
            // 
            processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            processingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            processingToolStripMenuItem.Text = "Processing";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new System.Drawing.Point(382, 35);
            dgvOrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new System.Drawing.Size(814, 266);
            dgvOrderDetail.TabIndex = 1;
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Location = new System.Drawing.Point(24, 55);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new System.Drawing.Size(67, 15);
            lbOrderDetail.TabIndex = 2;
            lbOrderDetail.Text = "OrderDetail";
            // 
            // lbAddressFrom
            // 
            lbAddressFrom.AutoSize = true;
            lbAddressFrom.Location = new System.Drawing.Point(24, 97);
            lbAddressFrom.Name = "lbAddressFrom";
            lbAddressFrom.Size = new System.Drawing.Size(80, 15);
            lbAddressFrom.TabIndex = 3;
            lbAddressFrom.Text = "Address From";
            // 
            // lbAddressTo
            // 
            lbAddressTo.AutoSize = true;
            lbAddressTo.Location = new System.Drawing.Point(24, 149);
            lbAddressTo.Name = "lbAddressTo";
            lbAddressTo.Size = new System.Drawing.Size(64, 15);
            lbAddressTo.TabIndex = 4;
            lbAddressTo.Text = "Address To";
            // 
            // txtOrderDetailID
            // 
            txtOrderDetailID.Location = new System.Drawing.Point(148, 53);
            txtOrderDetailID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderDetailID.Name = "txtOrderDetailID";
            txtOrderDetailID.Size = new System.Drawing.Size(186, 23);
            txtOrderDetailID.TabIndex = 5;
            // 
            // txtAddressFrom
            // 
            txtAddressFrom.Location = new System.Drawing.Point(150, 97);
            txtAddressFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAddressFrom.Name = "txtAddressFrom";
            txtAddressFrom.Size = new System.Drawing.Size(184, 23);
            txtAddressFrom.TabIndex = 6;
            // 
            // txtAddressTo
            // 
            txtAddressTo.Location = new System.Drawing.Point(148, 144);
            txtAddressTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAddressTo.Name = "txtAddressTo";
            txtAddressTo.Size = new System.Drawing.Size(186, 23);
            txtAddressTo.TabIndex = 7;
            // 
            // btnStart
            // 
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnStart.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(108, 216);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(82, 28);
            btnStart.TabIndex = 8;
            btnStart.Text = "Go";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(251, 216);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 28);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFinished
            // 
            btnFinished.Location = new System.Drawing.Point(108, 0);
            btnFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnFinished.Name = "btnFinished";
            btnFinished.Size = new System.Drawing.Size(82, 21);
            btnFinished.TabIndex = 10;
            btnFinished.Text = "Finished";
            btnFinished.UseVisualStyleBackColor = true;
            btnFinished.Click += btnFinished_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogout.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(1049, 305);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(147, 28);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmDelivery
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(1214, 338);
            Controls.Add(btnLogout);
            Controls.Add(btnFinished);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(txtAddressTo);
            Controls.Add(txtAddressFrom);
            Controls.Add(txtOrderDetailID);
            Controls.Add(lbAddressTo);
            Controls.Add(lbAddressFrom);
            Controls.Add(lbOrderDetail);
            Controls.Add(dgvOrderDetail);
            Controls.Add(menuStrip1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmDelivery";
            Text = "frmDelivery";
            Load += frmDelivery_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label lbOrderDetail;
        private System.Windows.Forms.Label lbAddressFrom;
        private System.Windows.Forms.Label lbAddressTo;
        private System.Windows.Forms.TextBox txtOrderDetailID;
        private System.Windows.Forms.TextBox txtAddressFrom;
        private System.Windows.Forms.TextBox txtAddressTo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnLogout;
    }
}