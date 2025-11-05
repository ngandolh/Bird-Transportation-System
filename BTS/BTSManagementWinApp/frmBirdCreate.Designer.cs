namespace ProjectManagementWinApp_NGUYENTHIMINHNGUYET
{
    partial class frmBirdCreate
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
            txtFile = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).BeginInit();
            SuspendLayout();
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new System.Drawing.Point(998, 147);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new System.Drawing.Size(117, 34);
            btnUploadImage.TabIndex = 71;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(491, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 70;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnThoat
            // 
            btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnThoat.Location = new System.Drawing.Point(624, 350);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(94, 29);
            btnThoat.TabIndex = 69;
            btnThoat.Text = "Cancel";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBird
            // 
            pictureBoxBird.Location = new System.Drawing.Point(784, 147);
            pictureBoxBird.Name = "pictureBoxBird";
            pictureBoxBird.Size = new System.Drawing.Size(197, 155);
            pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxBird.TabIndex = 68;
            pictureBoxBird.TabStop = false;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new System.Drawing.Point(275, 208);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(295, 27);
            txtOrigin.TabIndex = 67;
            // 
            // txtBirdName
            // 
            txtBirdName.Location = new System.Drawing.Point(275, 154);
            txtBirdName.Name = "txtBirdName";
            txtBirdName.Size = new System.Drawing.Size(295, 27);
            txtBirdName.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(687, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 20);
            label3.TabIndex = 64;
            label3.Text = "Picture";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new System.Drawing.Point(147, 211);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new System.Drawing.Size(50, 20);
            lbOrigin.TabIndex = 62;
            lbOrigin.Text = "Origin";
            // 
            // lbBirdName
            // 
            lbBirdName.AutoSize = true;
            lbBirdName.Location = new System.Drawing.Point(117, 154);
            lbBirdName.Name = "lbBirdName";
            lbBirdName.Size = new System.Drawing.Size(80, 20);
            lbBirdName.TabIndex = 61;
            lbBirdName.Text = "Bird Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("VNI-Revue", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(551, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 33);
            label1.TabIndex = 60;
            label1.Text = "Bird Detail";
            // 
            // txtFile
            // 
            txtFile.Location = new System.Drawing.Point(784, 326);
            txtFile.Name = "txtFile";
            txtFile.Size = new System.Drawing.Size(125, 27);
            txtFile.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(156, 270);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 20);
            label2.TabIndex = 73;
            label2.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(274, 270);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(296, 27);
            txtPrice.TabIndex = 74;
            // 
            // frmBirdCreate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1218, 450);
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
            Name = "frmBirdCreate";
            Text = "frmBirdCreate";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
    }
}