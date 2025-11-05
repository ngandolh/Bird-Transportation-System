using BusinessObject;
using DataAccessObjects;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTSManagementWinApp
{
    public partial class frmLogin : Form
    {
        private frmBirdManagement frmBirdManagement;
        public Action<object?, EventArgs> Logout { get; internal set; }

        ICustomerRepo cus = new CustomerRepo();
        ICarrierRepocs carr = new CarrierRepo();

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                IConfiguration builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
                //string email = adminDefaultSettings.Email;
                //string email2 = "admin@fprojectmanagement.com";
                //string password2 = "admin@@";
                //string password = adminDefaultSettings.Password;
                //string role = adminDefaultSettings.Role;

                var email = builder["AdminAccount:AdminEmail"];
                var password = builder["AdminAccount:AdminPassword"];
                var Carrier = builder["CarrierAccount:CarrierEmail"];
                var CarrierPass = builder["CarrierAccount:CarrierPassword"];
                if (email.Equals(txtPhone.Text) && password.Equals(txtPassword.Text))
                {
                    frmBirdManagement frmBirdManagement = new frmBirdManagement();
                    if (frmBirdManagement != null)
                    {
                        frmLogin loginForm = new frmLogin();
                        loginForm.Close();
                        frmBirdManagement frmBirdManagement1 = new frmBirdManagement();
                        frmBirdManagement1.ShowDialog(); // Show the frmBirdManagement form
                        
                    }
                    else
                    {
                        //throw new Exception("Tài khoản không tồn tại");
                        MessageBox.Show("Phone or password maybe not true, plz enter again");
                    }
                    Close();
                } else if (Carrier.Equals(txtPhone.Text) && CarrierPass.Equals(txtPassword.Text))
                {
                    this.Hide();
                    frmDelivery frmDelivery = new frmDelivery();
                    frmDelivery.ShowDialog();
                }
                else
                {
                    try
                    {
                        string userName = txtPhone.Text;
                        string passWord = txtPassword.Text;
                        //CustomerRepo = new CustomerRepo();
                        Customer c = cus.CheckLogin(userName, passWord);
                        Customer customerProfile = cus.getMemberByPhone(txtPhone.Text);
                        if (c != null)
                        {
                            if (c.Phone != null)
                            {
                                DialogResult dg = MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                frmBird frmBird = new frmBird();

                                frmBird.phone = customerProfile.Phone;
                                frmBird.CustomerID_cus = customerProfile.CustomerId;
                                frmBird.roleCus = customerProfile.Role;
                                frmBird.CustomerName_cus = customerProfile.CustomerName;

                                this.Hide();
                                frmBird.Show();

                                frmBird.Logout += FrmBird_Logout;

                            }
                            else
                            {
                                DialogResult dg = MessageBox.Show("Phone or password maybe not true, plz enter again", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

            }
        }
        private void FrmBird_Logout(object? sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to logout ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                (sender as frmBird).isCancel = false;
                (sender as frmBird).Close();
                ClearLoginFields(); // Xóa dữ liệu đã đăng nhập trước đó
                Show(); // Hiển thị form đăng nhập
            }
        }

        private void FrmBirdManagement_Logout(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                frmBirdManagement.Dispose(); // Dispose the frmBirdManagement instance
                ClearLoginFields(); // Clear login fields
                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();
                // Show the login form
            }
        }

        private void ClearLoginFields()
        {
            txtPhone.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Đóng form đăng nhập (Login)
            // Sử dụng Hide() để ẩn form đăng nhập thay vì Close()
            this.Hide();

            // Tạo một thể hiện của frmCustomer
            frmRegisterCus registerForm = new frmRegisterCus();
            // Hiển thị frmCustomer
            registerForm.Show();
        }

    }

}
