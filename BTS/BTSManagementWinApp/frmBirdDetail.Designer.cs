namespace BTSManagementWinApp
{
    partial class frmBirdDetail
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
            pictureBoxBird = new System.Windows.Forms.PictureBox();
            txtOrigin = new System.Windows.Forms.TextBox();
            txtBirdName = new System.Windows.Forms.TextBox();
            txtBirdID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbOrigin = new System.Windows.Forms.Label();
            lbBirdName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            btnUploadImage = new System.Windows.Forms.Button();
            txtFile = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBird
            // 
            pictureBoxBird.Location = new System.Drawing.Point(751, 104);
            pictureBoxBird.Name = "pictureBoxBird";
            pictureBoxBird.Size = new System.Drawing.Size(197, 155);
            pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxBird.TabIndex = 24;
            pictureBoxBird.TabStop = false;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new System.Drawing.Point(228, 208);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(295, 27);
            txtOrigin.TabIndex = 23;
            // 
            // txtBirdName
            // 
            txtBirdName.Location = new System.Drawing.Point(228, 154);
            txtBirdName.Name = "txtBirdName";
            txtBirdName.Size = new System.Drawing.Size(295, 27);
            txtBirdName.TabIndex = 22;
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(228, 104);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(295, 27);
            txtBirdID.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(654, 111);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 20);
            label3.TabIndex = 20;
            label3.Text = "Picture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(75, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
            label2.TabIndex = 19;
            label2.Text = "Bird ID";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new System.Drawing.Point(75, 208);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new System.Drawing.Size(50, 20);
            lbOrigin.TabIndex = 18;
            lbOrigin.Text = "Origin";
            // 
            // lbBirdName
            // 
            lbBirdName.AutoSize = true;
            lbBirdName.Location = new System.Drawing.Point(70, 154);
            lbBirdName.Name = "lbBirdName";
            lbBirdName.Size = new System.Drawing.Size(80, 20);
            lbBirdName.TabIndex = 17;
            lbBirdName.Text = "Bird Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("VNI-Revue", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(518, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 33);
            label1.TabIndex = 16;
            label1.Text = "Bird Detail";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(456, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 58;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnThoat
            // 
            btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnThoat.Location = new System.Drawing.Point(587, 362);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(94, 29);
            btnThoat.TabIndex = 57;
            btnThoat.Text = "Cancel";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new System.Drawing.Point(965, 104);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new System.Drawing.Size(117, 34);
            btnUploadImage.TabIndex = 59;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new System.Drawing.Point(751, 286);
            txtFile.Name = "txtFile";
            txtFile.Size = new System.Drawing.Size(125, 27);
            txtFile.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(77, 261);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 74;
            label4.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(228, 270);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(295, 27);
            txtPrice.TabIndex = 75;
            // 
            // frmBirdDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(1188, 475);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtFile);
            Controls.Add(btnUploadImage);
            Controls.Add(btnSave);
            Controls.Add(btnThoat);
            Controls.Add(pictureBoxBird);
            Controls.Add(txtOrigin);
            Controls.Add(txtBirdName);
            Controls.Add(txtBirdID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOrigin);
            Controls.Add(lbBirdName);
            Controls.Add(label1);
            Name = "frmBirdDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBirdDetail";
            Load += frmBirdDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBird;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtBirdName;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Label lbBirdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
    }
}