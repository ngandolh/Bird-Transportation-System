namespace BTSManagementWinApp
{
    partial class frmHistoryDetail
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtBackpack = new System.Windows.Forms.TextBox();
            txtVehicel = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtAddressTo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(217, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 33);
            label1.TabIndex = 0;
            label1.Text = "Detail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(87, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Back pack";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(97, 325);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 24);
            label3.TabIndex = 2;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(106, 174);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Vehicel";
            // 
            // txtBackpack
            // 
            txtBackpack.Location = new System.Drawing.Point(217, 122);
            txtBackpack.Name = "txtBackpack";
            txtBackpack.Size = new System.Drawing.Size(268, 27);
            txtBackpack.TabIndex = 4;
            // 
            // txtVehicel
            // 
            txtVehicel.Location = new System.Drawing.Point(217, 174);
            txtVehicel.Name = "txtVehicel";
            txtVehicel.Size = new System.Drawing.Size(268, 27);
            txtVehicel.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(217, 223);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(268, 27);
            txtAddress.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(398, 325);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(87, 24);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(67, 223);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 20);
            label5.TabIndex = 8;
            label5.Text = "Address From";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(420, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(105, 44);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(90, 267);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 20);
            label6.TabIndex = 9;
            label6.Text = "Address To";
            // 
            // txtAddressTo
            // 
            txtAddressTo.Location = new System.Drawing.Point(217, 267);
            txtAddressTo.Name = "txtAddressTo";
            txtAddressTo.Size = new System.Drawing.Size(268, 27);
            txtAddressTo.TabIndex = 10;
            // 
            // frmHistoryDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(537, 474);
            Controls.Add(txtAddressTo);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(lblTotal);
            Controls.Add(txtAddress);
            Controls.Add(txtVehicel);
            Controls.Add(txtBackpack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHistoryDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmHistoryDetail";
            Load += frmHistoryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBackpack;
        private System.Windows.Forms.TextBox txtVehicel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddressTo;
    }
}