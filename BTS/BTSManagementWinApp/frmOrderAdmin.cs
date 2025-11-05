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
    public partial class frmOrderAdmin : Form
    {
        public event EventHandler Logout;
        IOrderRepo orderRepo = new OrderRepo();
        IOrderDetailRepo detailRepo = new OrderDetailRepo();
        IBirdRepo birdRepo = new BirdRepo();
        ICustomerRepo customerRepo = new CustomerRepo();
        public frmOrderAdmin()
        {
            InitializeComponent();
        }
        public DataTable TableHistoryOrder()
        {

            DataTable dt = new DataTable();
            var orderList = orderRepo.GetAllOrder();
            BindingSource source = new BindingSource();
            source.DataSource = orderList;
            dt.Columns.Add("Order");
            dt.Columns.Add("Customer");
            dt.Columns.Add("BirdName");
            dt.Columns.Add("Origin");
            dt.Columns.Add("Picture");
            dt.Columns.Add("OrderDate");
            dt.Columns.Add("Status");

            txtOrderID.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtOrderStatus.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", dt, "Order");
            txtCustomerName.DataBindings.Add("Text", dt, "Customer");
            txtOrderDate.DataBindings.Add("Text", dt, "OrderDate");
            txtOrderStatus.DataBindings.Add("Text", dt, "Status");

            foreach (Order order in orderList)
            {
                Bird birds = birdRepo.GetBirdById(order.BirdId);
                Customer customer = customerRepo.GetCustomerById(order.CustomerId);
                dt.Rows.Add(order.OrderId, order.Customer.CustomerName, birds.BirdName, birds.Origin, birds.Picture, order.OrderDate, order.Status);
            }

            return dt;

        }

        private void frmOrderAdmin_Load(object sender, EventArgs e)
        {
            DataTable dataTable = TableHistoryOrder();
            dgvOrder.DataSource = dataTable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
            this.Close();
            frmBirdManagement frmBirdManagement = new frmBirdManagement();
            frmBirdManagement.ShowDialog();
        }

        private void frmOrderAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Order order = orderRepo.GetOrderByOrderID(int.Parse(txtOrderID.Text));
            var orderProcessing = new Order
            {
                OrderId = order.OrderId,
                BirdId = order.BirdId,
                CustomerId = order.CustomerId,
                Status = "In Processing",
                OrderDate = order.OrderDate,
            };
            orderRepo.UpdateOrder(orderProcessing);
            btnStart.Text = "Start";
            btnStart.Enabled = false;

            DataTable dataTable = TableHistoryOrder();
            dgvOrder.DataSource = dataTable;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide(); // Hide the frmOrderAdmin form

                // Trigger the Logout event
                Logout?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
