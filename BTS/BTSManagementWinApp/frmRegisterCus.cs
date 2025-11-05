using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTSManagementWinApp
{
    public partial class frmRegisterCus : Form
    {
        public frmRegisterCus()
        {
            InitializeComponent();
        }

        ICustomerRepo customerRepo = new CustomerRepo();
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Customer CustomerInfo { get; set; }
        public ICustomerRepo ICustomerRepository { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string filePath = txtFile.Text;
                // Lấy đường dẫn tệp tin từ pictureBoxBird

                var customer = new Customer
                {
                    // Lấy thông tin customer từ các ô văn bản
                    //BirdName = txtBirdName.Text,
                    //Origin = txtOrigin.Text,
                    CustomerName = txtCustomerName.Text,
                    Password = txtPassword.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Role = "user",

                    // Gán tên tệp tin vào cột Picture
                    //Picture = filePath, 
                };

                if (InsertOrUpdate == false)
                {  // Tạo một customer moi
                    var customerRepo = new CustomerRepo();
                    customerRepo.AddNew(customer);
                }
                else
                {
                    // Cập nhật cusromer đã info
                    var customerRepo = new CustomerRepo();
                    customerRepo.UpdateCustomer(customer);
                }

                MessageBox.Show(InsertOrUpdate == false ? "Register successfully" : "Customer's info updated successfully");
                //LoadDataFromDatabase();


                // Đóng form hiện tại và hiển thị lại form frmLogin
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Register Customer" : "Update Customer Infomation");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Đóng form đăng nhập (Login)
            // Sử dụng Hide() để ẩn form đăng nhập thay vì Close()
            this.Hide();

            // Tạo một thể hiện của frmCustomer
            frmLogin loginForm = new frmLogin();
            // Hiển thị 
            loginForm.Show();
        }
    }
}
