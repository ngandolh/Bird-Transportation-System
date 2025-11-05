using BusinessObject;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTSManagementWinApp
{
    public partial class frmBird : Form
    {
        // Định nghĩa sự kiện Logout
        public event EventHandler Logout;

        public bool isCancel = true;

        IBirdRepo birdRepo = new BirdRepo();
        IOrderRepo orderRepo = new OrderRepo();
        IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        ICustomerRepo customerRepo = new CustomerRepo();

        public string? phone { get; set; }

        public string roleCus { get; set; }
        public string CustomerName_cus { get; set; }
        public int CustomerID_cus { get; set; }

        public frmBird()
        {
            InitializeComponent();
            dgvBird.CellFormatting += dgvBird_CellFormatting;
            txtPicture.TextChanged += txtPicture_TextChanged;
        }
        private void dgvBird_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBird.Columns[e.ColumnIndex].Name == "Picture" && e.Value != null)
            {
                DataGridViewImageCell imageCell = dgvBird.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                imageCell.ImageLayout = DataGridViewImageCellLayout.Stretch; // Chỉnh cỡ hình ảnh về 100%
            }
            // Chỉnh chiều rộng của cột theo tên cột
            string columnName = "Picture"; // Thay thế bằng tên thực tế của cột
            int newWidth = 200; // Chiều rộng mới

            if (dgvBird.Columns.Contains(columnName))
            {
                dgvBird.Columns[columnName].Width = newWidth;
            }
            foreach (DataGridViewColumn column in dgvBird.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Vô hiệu hóa tự động điều chỉnh chiều rộng
                column.Width = newWidth; // Đặt chiều rộng mới cho tất cả các cột
            }

            int newHeight = 100; // Chiều cao mới

            foreach (DataGridViewRow row in dgvBird.Rows)
            {
                row.Height = newHeight;
            }
        }

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {
            string picturePath = txtPicture.Text;
            if (File.Exists(picturePath))
            {
                Image picture = Image.FromFile(picturePath);
                txtPicture.Image = picture;
            }
            else
            {
                txtPicture.Image = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (isCancel)
                    Application.Exit();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var birdID = birdRepo.GetBirdById(int.Parse(txtBirdID.Text));
            //var order = GetOrderByPhone(phone);
            var itemOrder = new Order
            {
                //OrderId = CreateOrderID(),
                CustomerId = customerRepo.getMemberByPhone(phone).CustomerId,
                BirdId = int.Parse(txtBirdID.Text),
                OrderDate = DateTime.Now,
                Status = "Not Done",
            };
            orderRepo.CreateOder(itemOrder);

            frmTransport frmTransport = new frmTransport();
            frmTransport.OrderID = itemOrder.OrderId;
            frmTransport.phone = phone;
            frmTransport.ShowDialog();
            MessageBox.Show("Order successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void AddOrUpdateOrderDetail(Order order, Bird bird, OrderDetail orderDetail)
        {
            OrderDetail orderDetail1 = orderDetailRepo.GetOrderDetailByOrderId(order);
            if (orderDetail1 == null) { orderDetailRepo.AddOrderDetail(orderDetail); }
            else orderDetailRepo.UpdateOrderDetail(orderDetail);
        }

        public List<Order> GetOrderByPhone(string phone)
        {
            var customer = customerRepo.getMemberByPhone(phone);
            List<Order> order = orderRepo.GetOrderByCustomer(customer.CustomerId);
            return order;
        }

        public int CreateOrderID()
        {
            int id = 0;
            var order = orderRepo.GetAllOrder().OrderByDescending(o => o.OrderId).FirstOrDefault();
            id = order.OrderId + 1;
            return id;
        }

        public void LoadBirdList()
        {
            try
            {
                var BirdList = birdRepo.GetBirds();
                BindingSource source = new BindingSource();
                source.DataSource = BirdList;
                DataTable dt = new DataTable();
                dt.Columns.Add("BirdId");
                dt.Columns.Add("BirdName");
                dt.Columns.Add("Origin");
                dt.Columns.Add("Price");
                dt.Columns.Add("Picture", typeof(Image));

                txtBirdID.DataBindings.Clear();
                txtBirdName.DataBindings.Clear();
                txtOrigin.DataBindings.Clear();
                txtPicture.DataBindings.Clear();

                txtBirdID.DataBindings.Add("Text", dt, "BirdId");
                txtBirdName.DataBindings.Add("Text", dt, "BirdName");
                txtOrigin.DataBindings.Add("Text", dt, "Origin");
                txtPrice.DataBindings.Add("Text", dt, "Price");
                txtPicture.DataBindings.Add("Image", dt, "Picture");

                foreach (var bird in BirdList)
                {
                    // Convert the image path to a byte array
                    byte[] imageBytes = File.ReadAllBytes(bird.Picture);
                    // Create an Image object from the byte array
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        dt.Rows.Add(bird.BirdId, bird.BirdName, bird.Origin, bird.Price, image);
                    }
                }

                dgvBird.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Birds");
            }
        }

        private void frmBird_Load(object sender, EventArgs e)
        {
            LoadBirdList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHistoryOrder frmHistoryOrder = new frmHistoryOrder();
            frmHistoryOrder.CustomerID = CustomerID_cus;

            // Handle the Logout event from frmHistoryOrder
            frmHistoryOrder.Logout += FrmHistoryOrder_Logout;

            frmHistoryOrder.ShowDialog();
        }
        private void FrmHistoryOrder_Logout(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Are you sure to logout ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                (sender as frmHistoryOrder).Close();
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện Logout để thông báo rằng người dùng đăng xuất
            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void CustomerForm_Logout(object? sender, EventArgs e)
        {
            // Hiển thị form đăng nhập khi người dùng đăng xuất
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            frmLogin loginForm = new frmLogin();

            // Đăng ký sự kiện Logout để biết khi nào người dùng đăng xuất
            loginForm.Logout += LoginForm_Logout;

            this.Close();
            loginForm.ShowDialog();
            this.Show();
        }

        private void LoginForm_Logout(object? sender, EventArgs e)
        {
            // Hiển thị form đăng nhập khi người dùng đăng xuất
            ShowLoginForm();
        }


        private void FrmBird_Logout(object? sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to logout ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                (sender as frmBird).isCancel = false;
                (sender as frmBird).Close();
                this.Show();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            // Tạo một thể hiện của frmCustomer
            frmCustomer customerForm = new frmCustomer();

            // Truyền thông tin khách hàng từ Form frmBird sang frmCustomer
            customerForm.CustomerInfo = customerRepo.getMemberByPhone(phone);
            customerForm.InsertOrUpdate = true; // Đặt cờ này là true nếu muốn hiển thị thông tin đã có sẵn và cho phép cập nhật

            // Đăng ký sự kiện Logout để biết khi nào người dùng đăng xuất
            customerForm.Logout += CustomerForm_Logout;
            // Hiển thị frmCustomer
            customerForm.ShowDialog();
        }
        private void ClearText()
        {
            txtBirdID.Text = "";
            txtBirdName.Text = "";
            txtOrigin.Text = "";
            txtPicture.Text = "";
            txtPrice.Text = "";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            frmBirdCustomer frmBirdDetail = new frmBirdCustomer
            {
                Text = "Add bird",
                InsertOrUpdate = false,
                IBirdRepository = birdRepo
            };
            if (frmBirdDetail.ShowDialog() == DialogResult.OK)
            {

                frmCheckout frmCheckout = new frmCheckout();

                //LoadBirdList();
                //Set focus car inserted 
                //source.Position = source.Count - 1;
            }
        }
    }
}
