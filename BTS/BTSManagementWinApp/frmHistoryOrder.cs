using BusinessObject;
using Microsoft.EntityFrameworkCore.Migrations;
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
    public partial class frmHistoryOrder : Form
    {
        //// Định nghĩa sự kiện Logout
        //public Action<object?, EventArgs> Logout { get; internal set; }
        public event EventHandler Logout;

        IOrderRepo orderRepo = new OrderRepo();
        IBirdRepo birdRepo = new BirdRepo();
        public int CustomerID { get; set; }
        public frmHistoryOrder()
        {
            InitializeComponent();
        }

        private void frmHistoryOrder_Load(object sender, EventArgs e)
        {
            DataTable dataTable = TableHistoryOrder();
            dgvOrder.DataSource = dataTable;
            //dgvOrder.CellDoubleClick += dgvOrder_DoubleClick;
        }
        public DataTable TableHistoryOrder()
        {

            DataTable dt = new DataTable();
            List<Order> orderList = orderRepo.GetOrderByCustomer(CustomerID);
            dt.Columns.Add("Order");
            dt.Columns.Add("BirdName");
            dt.Columns.Add("Origin");
            dt.Columns.Add("Picture");
            dt.Columns.Add("OrderDate");
            dt.Columns.Add("Status");

            txtOrderID.DataBindings.Clear();
            txtOrderID.DataBindings.Add("Text", dt, "Order");

            foreach (Order order in orderList)
            {
                Bird birds = birdRepo.GetBirdById(order.BirdId);
                dt.Rows.Add(order.OrderId, birds.BirdName, birds.Origin, birds.Picture, order.OrderDate, order.Status);
            }

            return dt;

        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmHistoryDetail frmHistoryDetail = new frmHistoryDetail();
            foreach (DataRow row in TableHistoryOrder().Rows)
            {
                //Order orrIDs = (Order)row[0];
                //frmHistoryDetail.OrderID = orrIDs.OrderId;
                int orderID = int.Parse(row[0].ToString()); // Assuming OrderID is stored in the first column
                Order orrIDs = new Order { OrderId = orderID };
                frmHistoryDetail.OrderID = orrIDs.OrderId;

            }
            this.Hide();
            frmHistoryDetail.ShowDialog();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                frmBird frmBird = new frmBird();
                frmBird.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            // Gọi sự kiện Logout để thông báo rằng người dùng đăng xuất
            Logout?.Invoke(this, EventArgs.Empty);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(txtOrderID.Text);
            Order order = orderRepo.GetOrderByOrderID(orderID);
            var orderItem = new Order()
            {
                OrderId = order.OrderId,
                BirdId = order.BirdId,
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                Status = "Cancel",
            };
            orderRepo.UpdateOrder(orderItem);

            DataTable dataTable = TableHistoryOrder();
            dgvOrder.DataSource = dataTable;

        }
    }
}
