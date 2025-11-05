namespace BTSManagementWinApp
{
    partial class frmHistoryOrder
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
            label1 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnDetail = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new System.Drawing.Point(53, 121);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new System.Drawing.Size(921, 321);
            dgvOrder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(400, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 24);
            label1.TabIndex = 1;
            label1.Text = "History Order";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(799, 463);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(118, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDetail.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDetail.Location = new System.Drawing.Point(400, 463);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(126, 34);
            btnDetail.TabIndex = 3;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(873, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(130, 30);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.Yellow;
            btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnStop.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStop.Location = new System.Drawing.Point(53, 468);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(94, 29);
            btnStop.TabIndex = 21;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(78, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 20);
            label2.TabIndex = 22;
            label2.Text = "Order";
            // 
            // txtOrderID
            // 
            txtOrderID.AutoSize = true;
            txtOrderID.Location = new System.Drawing.Point(143, 75);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(50, 20);
            txtOrderID.TabIndex = 23;
            txtOrderID.Text = "label3";
            // 
            // frmHistoryOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1026, 547);
            Controls.Add(txtOrderID);
            Controls.Add(label2);
            Controls.Add(btnStop);
            Controls.Add(btnLogout);
            Controls.Add(btnDetail);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(dgvOrder);
            Name = "frmHistoryOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmHistoryOrder";
            Load += frmHistoryOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtOrderID;
    }
}