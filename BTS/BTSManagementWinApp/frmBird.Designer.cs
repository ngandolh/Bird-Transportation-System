namespace BTSManagementWinApp
{
    partial class frmBird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBird));
            label1 = new System.Windows.Forms.Label();
            dgvBird = new System.Windows.Forms.DataGridView();
            btnOrder = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnProfile = new System.Windows.Forms.Button();
            btnHistory = new System.Windows.Forms.Button();
            lbBirdName = new System.Windows.Forms.Label();
            lbOrigin = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtBirdID = new System.Windows.Forms.TextBox();
            txtBirdName = new System.Windows.Forms.TextBox();
            txtOrigin = new System.Windows.Forms.TextBox();
            txtPicture = new System.Windows.Forms.PictureBox();
            birdRepoBindingSource = new System.Windows.Forms.BindingSource(components);
            lbPrice = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            btnLogout = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)birdRepoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(490, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Bird Information";
            label1.Click += label1_Click;
            // 
            // dgvBird
            // 
            dgvBird.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvBird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBird.Location = new System.Drawing.Point(42, 241);
            dgvBird.Name = "dgvBird";
            dgvBird.RowHeadersWidth = 51;
            dgvBird.RowTemplate.Height = 29;
            dgvBird.Size = new System.Drawing.Size(1094, 221);
            dgvBird.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrder.Location = new System.Drawing.Point(277, 539);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(197, 48);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(941, 539);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(195, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnProfile
            // 
            btnProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            btnProfile.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.Location = new System.Drawing.Point(1057, 19);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(114, 44);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnHistory.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHistory.Location = new System.Drawing.Point(507, 539);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new System.Drawing.Size(187, 48);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History Order";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // lbBirdName
            // 
            lbBirdName.AutoSize = true;
            lbBirdName.Location = new System.Drawing.Point(75, 123);
            lbBirdName.Name = "lbBirdName";
            lbBirdName.Size = new System.Drawing.Size(80, 20);
            lbBirdName.TabIndex = 6;
            lbBirdName.Text = "Bird Name";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new System.Drawing.Point(105, 164);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new System.Drawing.Size(50, 20);
            lbOrigin.TabIndex = 8;
            lbOrigin.Text = "Origin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(101, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
            label2.TabIndex = 9;
            label2.Text = "Bird ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(623, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 20);
            label3.TabIndex = 10;
            label3.Text = "Picture";
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(233, 72);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(295, 27);
            txtBirdID.TabIndex = 11;
            // 
            // txtBirdName
            // 
            txtBirdName.Location = new System.Drawing.Point(233, 123);
            txtBirdName.Name = "txtBirdName";
            txtBirdName.Size = new System.Drawing.Size(295, 27);
            txtBirdName.TabIndex = 12;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new System.Drawing.Point(233, 161);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(295, 27);
            txtOrigin.TabIndex = 13;
            // 
            // txtPicture
            // 
            txtPicture.Location = new System.Drawing.Point(739, 72);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new System.Drawing.Size(197, 155);
            txtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            txtPicture.TabIndex = 15;
            txtPicture.TabStop = false;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(105, 204);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 16;
            lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(229, 204);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(299, 27);
            txtPrice.TabIndex = 17;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.Location = new System.Drawing.Point(42, 539);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(197, 48);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNew
            // 
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnNew.Location = new System.Drawing.Point(1057, 90);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(114, 40);
            btnNew.TabIndex = 20;
            btnNew.Text = "Other";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frmBird
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1183, 620);
            Controls.Add(btnNew);
            Controls.Add(btnLogout);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtPicture);
            Controls.Add(txtOrigin);
            Controls.Add(txtBirdName);
            Controls.Add(txtBirdID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOrigin);
            Controls.Add(lbBirdName);
            Controls.Add(btnHistory);
            Controls.Add(btnProfile);
            Controls.Add(btnCancel);
            Controls.Add(btnOrder);
            Controls.Add(dgvBird);
            Controls.Add(label1);
            Name = "frmBird";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBird";
            Load += frmBird_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)birdRepoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBird;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lbBirdName;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.TextBox txtBirdName;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.PictureBox txtPicture;
        private System.Windows.Forms.BindingSource birdRepoBindingSource;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNew;
    }
}