using BusinessObject;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public partial class frmCustomer : Form
    {
        ICustomerRepo customerRepo = new CustomerRepo();
        public ICustomerRepo ICustomerRepository { get; set; }

        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Customer CustomerInfo { get; set; }
        public Action<object?, EventArgs> Logout { get; internal set; }

        //write
        BindingSource source;

        public frmCustomer()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    //ProjectID = int.Parse(txtProjectID.Text),
                    //ProjectName = txtProjectName.Text,
                    //EstimatedStartDate = DateTime.Parse(txtEstimatedStartDate.Text),
                    //EstimatedEndDate = DateTime.Parse(txtEstimatedEndDate.Text),
                    //ProjectAddress = txtProjectAddress.Text,
                    //ProjectDescription = txtProjectDescription.Text,
                    //ProjectSponsor = txtProjectSponsor.Text,
                    //ProjectCity = txtProjectCity.Text,

                    CustomerId = CustomerInfo.CustomerId,
                    CustomerName = CustomerInfo.CustomerName,
                    Password = CustomerInfo.Password,
                    Phone = CustomerInfo.Phone,
                    Address = CustomerInfo.Address,
                };
                if (InsertOrUpdate == false)
                {  // tạo mới
                    ICustomerRepository.SaveCustomer(customer);
                }
                else
                {
                    ICustomerRepository.UpdateCustomer(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new customer" : "Update a customer");
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            txtCustomerID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) //Update mode
            {
                //Show car to perform updating
                txtCustomerID.Text = CustomerInfo.CustomerId.ToString();
                txtCustomerName.Text = CustomerInfo.CustomerName;
                txtPassword.Text = CustomerInfo.Password;
                txtPhone.Text = CustomerInfo.Phone;
                txtAddress.Text = CustomerInfo.Address;

            }
        }//end frmCarDetails_Load

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ? return bird list", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                frmBird birdFrom = new frmBird();
                birdFrom.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtDelAcc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer account? We will close the application", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    customerRepo.DeleteCustomer(CustomerInfo);
                    MessageBox.Show("Customer account has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng ứng dụng sau khi xóa tài khoản thành công
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Kiểm tra dữ liệu nhập vào
                if (!IsValidInput())
                {
                    MessageBox.Show("Please fill in all required fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo một đối tượng Customer mới với thông tin đã được cập nhật từ các controls
                Customer updatedCustomer = new Customer
                {
                    CustomerId = CustomerInfo.CustomerId,
                    CustomerName = txtCustomerName.Text,
                    Password = txtPassword.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text
                };

                if (InsertOrUpdate == false)
                {  // Tạo mới
                    customerRepo.AddNew(updatedCustomer);
                }
                else
                {
                    customerRepo.UpdateCustomer(updatedCustomer);
                }

                MessageBox.Show("Customer information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng Form sau khi cập nhật thành công (tùy vào yêu cầu)
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new customer" : "Update a customer");
            }
        }

        // Phương thức kiểm tra dữ liệu nhập vào
        private bool IsValidInput()
        {
            // Kiểm tra các trường thông tin có được điền đầy đủ hay không
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                return false;
            }

            // Các kiểm tra bổ sung 

            return true;
        }


        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbAddress_Click(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbPhone_Click(object sender, EventArgs e)
        {
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {
        }

        private void lbCustomerName_Click(object sender, EventArgs e)
        {
        }

        private void lbCustomerID_Click(object sender, EventArgs e)
        {
        }
        //------------------------------------------------------
    }
}