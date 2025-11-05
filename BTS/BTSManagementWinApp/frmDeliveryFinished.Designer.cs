namespace BTSManagementWinApp
{
    partial class frmDeliveryFinished
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
            dgvOrderDetail = new System.Windows.Forms.DataGridView();
            btnConfirm = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtDelivery = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new System.Drawing.Point(237, 20);
            dgvOrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new System.Drawing.Size(536, 272);
            dgvOrderDetail.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnConfirm.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Location = new System.Drawing.Point(108, 86);
            btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(100, 30);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "OrderDetail";
            // 
            // txtDelivery
            // 
            txtDelivery.Location = new System.Drawing.Point(108, 40);
            txtDelivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDelivery.Name = "txtDelivery";
            txtDelivery.Size = new System.Drawing.Size(110, 23);
            txtDelivery.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(125, 268);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogout.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(652, 296);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(121, 31);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmDeliveryFinished
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(810, 338);
            Controls.Add(btnLogout);
            Controls.Add(btnCancel);
            Controls.Add(txtDelivery);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(dgvOrderDetail);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmDeliveryFinished";
            Text = "frmDeliveryFinished";
            Load += frmDeliveryFinished_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogout;
    }
}