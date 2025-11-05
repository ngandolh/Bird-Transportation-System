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
    public partial class frmDelivery : Form
    {
        public event EventHandler Logout;

        IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        IOrderRepo orderRepo = new OrderRepo();
        IDeliveryRepo DeliveryRepo = new DeliveryRepo();
        ITransportRepo TransportRepo = new TransportRepo();
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            DataTable dataTable = TableHistoryOrder();
            dgvOrderDetail.DataSource = dataTable;
        }

        public DataTable TableHistoryOrder()
        {

            DataTable dt = new DataTable();
            List<OrderDetail> orderList = orderDetailRepo.GetAllOrderDetail();
            List<Order> orderStatus = orderRepo.GetOrderByStatus("In Processing");
            dt.Columns.Add("OrderDetail");
            dt.Columns.Add("AddressFrom");
            dt.Columns.Add("AddressTo");
            dt.Columns.Add("TotalPrice");
            //dt.Columns.Add("Transport");
            dt.Columns.Add("Vehicel");
            dt.Columns.Add("Backpack");

            txtOrderDetailID.DataBindings.Clear();
            txtAddressFrom.DataBindings.Clear();
            txtAddressTo.DataBindings.Clear();


            txtOrderDetailID.DataBindings.Add("Text", dt, "OrderDetail");
            txtAddressFrom.DataBindings.Add("Text", dt, "AddressFrom");
            txtAddressTo.DataBindings.Add("Text", dt, "AddressTo");

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            string AddressFrom = txtAddressFrom.Text;
            string AddressTo = txtAddressTo.Text;
            var DeliveryItem = new Delivery
            {
                DeliveryName = AddressFrom + AddressTo,
                OrderIdetail = int.Parse(txtOrderDetailID.Text),
            };
            DeliveryRepo.AddDelivery(DeliveryItem);

            btnStart.Text = "Go";
            btnStart.Enabled = false;
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


        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeliveryFinished frmDeliveryFinished = new frmDeliveryFinished();
            frmDeliveryFinished.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
