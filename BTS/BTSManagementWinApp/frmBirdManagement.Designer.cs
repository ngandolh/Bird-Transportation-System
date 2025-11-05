namespace BTSManagementWinApp
{
    partial class frmBirdManagement
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
            txtPicture = new System.Windows.Forms.PictureBox();
            txtOrigin = new System.Windows.Forms.TextBox();
            txtBirdName = new System.Windows.Forms.TextBox();
            txtBirdID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbOrigin = new System.Windows.Forms.Label();
            lbBirdName = new System.Windows.Forms.Label();
            btnProfile = new System.Windows.Forms.Button();
            dgvBird = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            Search = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            txtPrice = new System.Windows.Forms.TextBox();
            lbPrice = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)txtPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBird).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPicture
            // 
            txtPicture.Location = new System.Drawing.Point(667, 43);
            txtPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new System.Drawing.Size(172, 116);
            txtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            txtPicture.TabIndex = 26;
            txtPicture.TabStop = false;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new System.Drawing.Point(224, 121);
            txtOrigin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(259, 23);
            txtOrigin.TabIndex = 25;
            // 
            // txtBirdName
            // 
            txtBirdName.Location = new System.Drawing.Point(224, 80);
            txtBirdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBirdName.Name = "txtBirdName";
            txtBirdName.Size = new System.Drawing.Size(259, 23);
            txtBirdName.TabIndex = 24;
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(224, 43);
            txtBirdID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(259, 23);
            txtBirdID.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(565, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 15);
            label3.TabIndex = 22;
            label3.Text = "Picture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(86, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 21;
            label2.Text = "Bird ID";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new System.Drawing.Point(90, 121);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new System.Drawing.Size(40, 15);
            lbOrigin.TabIndex = 20;
            lbOrigin.Text = "Origin";
            // 
            // lbBirdName
            // 
            lbBirdName.AutoSize = true;
            lbBirdName.Location = new System.Drawing.Point(86, 80);
            lbBirdName.Name = "lbBirdName";
            lbBirdName.Size = new System.Drawing.Size(63, 15);
            lbBirdName.TabIndex = 19;
            lbBirdName.Text = "Bird Name";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnProfile.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProfile.Location = new System.Drawing.Point(913, 4);
            btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(100, 36);
            btnProfile.TabIndex = 18;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // dgvBird
            // 
            dgvBird.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvBird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBird.Location = new System.Drawing.Point(56, 227);
            dgvBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvBird.Name = "dgvBird";
            dgvBird.RowHeadersWidth = 51;
            dgvBird.RowTemplate.Height = 29;
            dgvBird.Size = new System.Drawing.Size(957, 166);
            dgvBird.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(395, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 19);
            label1.TabIndex = 16;
            label1.Text = "Bird Information";
            // 
            // Search
            // 
            Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Search.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Search.Location = new System.Drawing.Point(243, 187);
            Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(70, 22);
            Search.TabIndex = 50;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(137, 188);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(110, 23);
            txtSearch.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(259, 207);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 15);
            label4.TabIndex = 44;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDelete.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(667, 186);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(565, 188);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(82, 22);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSave.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(464, 188);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(82, 22);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCreate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(366, 188);
            btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(82, 22);
            btnCreate.TabIndex = 51;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(223, 152);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(260, 23);
            txtPrice.TabIndex = 55;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(83, 160);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(33, 15);
            lbPrice.TabIndex = 56;
            lbPrice.Text = "Price";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { orderToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1068, 27);
            menuStrip1.TabIndex = 57;
            menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            orderToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLogout.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(931, 397);
            btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(82, 22);
            btnLogout.TabIndex = 58;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmBirdManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1068, 441);
            Controls.Add(btnLogout);
            Controls.Add(lbPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(Search);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(txtPicture);
            Controls.Add(txtOrigin);
            Controls.Add(txtBirdName);
            Controls.Add(txtBirdID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOrigin);
            Controls.Add(lbBirdName);
            Controls.Add(btnProfile);
            Controls.Add(dgvBird);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmBirdManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBirdManagement";
            Load += frmBirdManagement_Load;
            ((System.ComponentModel.ISupportInitialize)txtPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBird).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox txtPicture;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtBirdName;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Label lbBirdName;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.DataGridView dgvBird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
    }
}