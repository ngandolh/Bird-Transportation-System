using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTSManagementWinApp
{
    public partial class frmCheckout : Form
    {
        ITransportRepo transport = new TransportRepo();
        IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        IOrderRepo orderRepo = new OrderRepo();
        IBirdRepo birdRepo = new BirdRepo();
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        Transport tran = new Transport();

        public int OrderID { get; set; }
        public int TransportID { get; set; }

        public string phone { get; set; }

        public frmCheckout()
        {
            InitializeComponent();
        }

        public void LoadTransportList()
        {
            try
            {
                var TransportList = transport.GetTransportbyID(TransportID);
                BindingSource source = new BindingSource();
                source.DataSource = TransportList;

                txtBackpack.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtPrice.DataBindings.Clear();


                txtBackpack.DataBindings.Add("Text", source, "Backpack");
                txtVehicel.DataBindings.Add("Text", source, "Vehicel");
                txtPrice.DataBindings.Add("Text", source, "Price");

                //dgvTransports.DataSource = null;
                //dgvTransports.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Transports");
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to stop checkout?", "Check Out Manage",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            var order = orderRepo.GetOrderByOrderID(OrderID);
            var trans = transport.GetTransportbyID(TransportID);
            orderRepo.DeleteOrder(order);
            transport.Remove(TransportID);

            this.Hide();
            frmBird frmBird = new frmBird();
            frmBird.ShowDialog();

            //if (d == DialogResult.OK)
            //{
            //    var p = new OrderDetail
            //    {
            //        OrderId = int.Parse(),
            //    };
            //    orderDetailRepo.Remove(p);
            //    Application.Exit();
            //}
        }

        private double CalculateTotal()
        {
            double total = 0;
            //orderDetails.ForEach(od => total += (double)od.TotalPrice);
            //total = 50;
            Order order = orderRepo.GetOrderByOrderID(OrderID);
            Bird bird = birdRepo.GetBirdById(order.BirdId);
            var Transport = transport.GetTransportbyID(TransportID);
            total = (double)( Transport.Price +  bird.Price);
            return total;
        }

        private void parseAllText()
        {
            //lblOrderIdValue.Text = orderDetails.First().OrderId.ToString();
            //lblTotalValue.Text = CalculateTotal().ToString();

            //lblCustomerName.Text = customerName;
            //lblDateValue.Text = order.Date.ToString();
            lblTotalPrice.Text = CalculateTotal().ToString();


        }
        public DataTable tableCart(Order order)
        {
            DataTable dt = new DataTable();
            order = orderRepo.GetOrderByOrderID(OrderID);
            Bird bird = birdRepo.GetBirdById(order.BirdId);
            dt.Columns.Add("Bird");
            dt.Columns.Add("Orgin");
            dt.Columns.Add("Picture");
            dt.Rows.Add(bird.BirdName, bird.Origin, bird.Picture);
            return dt;
        }
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            parseAllText();
            LoadTransportList();
            Order order = orderRepo.GetOrderByOrderID(OrderID);
            DataTable cart = tableCart(order);
            dgvCart.DataSource = cart;
        }

        public OrderDetail GetNewOrderDetails(Order order, Transport Transport)
        {
            OrderDetail orderDetail = orderDetailRepo.GetOrderDetailByOrderId(order);
            if (orderDetail == null)
            {
                double price = CalculateTotal();
                orderDetail = new OrderDetail
                {
                    OrderId = OrderID,
                    TransportId = TransportID,
                    AddressShip = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Pay = cboCOD.Text,
                    TotalPrice = price,
                };
            }
            //else { orderDetail.Quantity += 1; }
            return orderDetail;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double price = CalculateTotal();
            var orderDetail = new OrderDetail
            {
                //ProductId = int.Parse(txtProductId.Text),
                OrderId = OrderID,
                AddressFrom = txtAddressFrom.Text,
                AddressShip = txtAddress.Text,
                Phone = txtPhone.Text,
                Pay = cboCOD.Text,
                TransportId = TransportID,
                TotalPrice = price,
            };

            orderDetailRepo.AddOrderDetail(orderDetail);

            btnConfirm.Text = "Confirm";
            btnConfirm.Enabled = false;

            frmBill frmBill = new frmBill();
            frmBill.phone = phone;
            frmBill.OrderDetailID = orderDetail.OrderIdetail;
            frmBill.TransportID = TransportID;
            frmBill.OrderID = OrderID;
            this.Hide();
            frmBill.ShowDialog();
        }
    }
}
