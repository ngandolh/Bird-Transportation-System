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
    public partial class frmDeliveryFinished : Form
    {
        IOrderRepo orderRepo = new OrderRepo();
        IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        ITransportRepo TransportRepo = new TransportRepo();
        public frmDeliveryFinished()
        {
            InitializeComponent();
        }

        private void frmDeliveryFinished_Load(object sender, EventArgs e)
        {
            DataTable dataTable = TableHistoryOrder();
            dgvOrderDetail.DataSource = dataTable;
        }

        public DataTable TableHistoryOrder()
        {

            DataTable dt = new DataTable();
            List<Order> orderStatus = orderRepo.GetOrderByStatus("In Processing");
            dt.Columns.Add("OrderDetail");
            dt.Columns.Add("AddressFrom");
            dt.Columns.Add("AddressTo");
            dt.Columns.Add("TotalPrice");
            //dt.Columns.Add("Transport");
            dt.Columns.Add("Vehicel");
            dt.Columns.Add("Backpack");

            txtDelivery.DataBindings.Clear();

            txtDelivery.DataBindings.Add("Text", dt, "OrderDetail");

            foreach (Order order in orderStatus)
            {
                var orderDetailList = orderDetailRepo.GetOrderDetailStatus(order.OrderId);
                foreach (OrderDetail orderDetail in orderDetailList)
                {
                    Transport tran = TransportRepo.GetTransportbyID(orderDetail.TransportId);
                    dt.Rows.Add(orderDetail.OrderIdetail, orderDetail.AddressShip, orderDetail.AddressFrom, orderDetail.TotalPrice,
                        tran.Vehicel, tran.Backpack);
                }
            }



            dgvOrderDetail.DataSource = dt;
            return dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var orderDetail = orderDetailRepo.GetOrderDetailbyOrderDetailID(int.Parse(txtDelivery.Text));
            Order order = orderRepo.GetOrderByOrderID(orderDetail.OrderId);

            var orderU = new Order
            {
                OrderId = order.OrderId,
                BirdId = order.BirdId,
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                Status = "Finished",
            };

            orderRepo.UpdateOrder(orderU);

            btnConfirm.Text = "Confirm";
            btnConfirm.Enabled = false;

            DataTable dataTable = TableHistoryOrder();
            dgvOrderDetail.DataSource = dataTable;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
