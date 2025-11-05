namespace BTSManagementWinApp
{
    partial class frmBST
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
            btnLogout = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(1026, 456);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmBST
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1132, 497);
            Controls.Add(btnLogout);
            Name = "frmBST";
            Text = "frmBST";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
    }
}