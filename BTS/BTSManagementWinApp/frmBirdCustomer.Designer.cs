namespace BTSManagementWinApp
{
    partial class frmBirdCustomer
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
            txtPrice = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtFile = new System.Windows.Forms.TextBox();
            btnUploadImage = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            pictureBoxBird = new System.Windows.Forms.PictureBox();
            txtOrigin = new System.Windows.Forms.TextBox();
            txtBirdName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lbOrigin = new System.Windows.Forms.Label();
            lbBirdName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).BeginInit();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(282, 270);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(296, 27);
            txtPrice.TabIndex = 87;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(164, 270);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 20);
            label2.TabIndex = 86;
            label2.Text = "Price";
            // 
            // txtFile
            // 
            txtFile.Location = new System.Drawing.Point(792, 326);
            txtFile.Name = "txtFile";
            txtFile.Size = new System.Drawing.Size(125, 27);
            txtFile.TabIndex = 85;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new System.Drawing.Point(1006, 147);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new System.Drawing.Size(117, 34);
            btnUploadImage.TabIndex = 84;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(499, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 83;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnThoat
            // 
            btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnThoat.Location = new System.Drawing.Point(632, 350);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(94, 29);
            btnThoat.TabIndex = 82;
            btnThoat.Text = "Cancel";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBoxBird
            // 
            pictureBoxBird.Location = new System.Drawing.Point(792, 147);
            pictureBoxBird.Name = "pictureBoxBird";
            pictureBoxBird.Size = new System.Drawing.Size(197, 155);
            pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxBird.TabIndex = 81;
            pictureBoxBird.TabStop = false;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new System.Drawing.Point(283, 208);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(295, 27);
            txtOrigin.TabIndex = 80;
            // 
            // txtBirdName
            // 
            txtBirdName.Location = new System.Drawing.Point(283, 154);
            txtBirdName.Name = "txtBirdName";
            txtBirdName.Size = new System.Drawing.Size(295, 27);
            txtBirdName.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(695, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 20);
            label3.TabIndex = 78;
            label3.Text = "Picture";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new System.Drawing.Point(155, 211);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new System.Drawing.Size(50, 20);
            lbOrigin.TabIndex = 77;
            lbOrigin.Text = "Origin";
            // 
            // lbBirdName
            // 
            lbBirdName.AutoSize = true;
            lbBirdName.Location = new System.Drawing.Point(125, 154);
            lbBirdName.Name = "lbBirdName";
            lbBirdName.Size = new System.Drawing.Size(80, 20);
            lbBirdName.TabIndex = 76;
            lbBirdName.Text = "Bird Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("VNI-Revue", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(559, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 33);
            label1.TabIndex = 75;
            label1.Text = "Bird Detail";
            // 
            // frmBirdCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1248, 450);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtFile);
            Controls.Add(btnUploadImage);
            Controls.Add(btnSave);
            Controls.Add(btnThoat);
            Controls.Add(pictureBoxBird);
            Controls.Add(txtOrigin);
            Controls.Add(txtBirdName);
            Controls.Add(label3);
            Controls.Add(lbOrigin);
            Controls.Add(lbBirdName);
            Controls.Add(label1);
            Name = "frmBirdCustomer";
            Text = "frmBirdCustomer";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBoxBird;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtBirdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Label lbBirdName;
        private System.Windows.Forms.Label label1;
    }
}