namespace BTSManagementWinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lbPhone = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnStop = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(328, 159);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 0;
            lbPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(328, 233);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(411, 156);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(261, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(411, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(261, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnLogin.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.Location = new System.Drawing.Point(421, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(99, 49);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("VNI-Revue", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(482, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 33);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SkyBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(321, 485);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.LightCyan;
            label4.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(11, 62);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(291, 23);
            label4.TabIndex = 8;
            label4.Text = "Bird  Transportation  System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Azure;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(321, 485);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("VNI-Revue", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(27, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(271, 33);
            label2.TabIndex = 8;
            label2.Text = "Bird Transportation Bird";
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 23);
            label1.TabIndex = 0;
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnStop.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStop.Location = new System.Drawing.Point(574, 327);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(98, 49);
            btnStop.TabIndex = 9;
            btnStop.Text = "Cancel";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnRegister.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegister.Location = new System.Drawing.Point(482, 419);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(122, 45);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(698, 485);
            Controls.Add(btnRegister);
            Controls.Add(btnStop);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(lbPassword);
            Controls.Add(lbPhone);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRegister;
    }
}
