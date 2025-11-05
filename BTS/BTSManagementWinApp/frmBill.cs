using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTSManagementWinApp
{
    public partial class frmBill : Form
    {
        ICustomerRepo customerRepo = new CustomerRepo();
        IBirdRepo birdRepo = new BirdRepo();
        IOrderRepo orderRepo = new OrderRepo();
        IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        ITransportRepo transportRepo = new TransportRepo();
        public string phone { get; set; }
        public int OrderDetailID { get; set; }
        public int TransportID { get; set; }
        public int OrderID { get; set; }
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadOrderDetail();
            LoadTransportList();
            Order order = orderRepo.GetOrderByOrderID(OrderID);
            DataTable cart = tableCart(order);
            dgvCart.DataSource = cart;
            parseTotalPrice();
        }

        public void LoadCustomer()
        {
            try
            {
                var CustomerInfo = customerRepo.getMemberByPhone(phone);
                BindingSource source = new BindingSource();
                source.DataSource = CustomerInfo;

                txtCustomerName.Text = CustomerInfo.CustomerName;
                txtPhone.Text = CustomerInfo.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error a customer.");
            }
        }
        public void LoadTransportList()
        {
            try
            {
                var TransportList = transportRepo.GetTransportbyID(TransportID);
                BindingSource source = new BindingSource();
                source.DataSource = TransportList;

                txtBackpack.DataBindings.Clear();
                txtVehicel.DataBindings.Clear();


                txtBackpack.DataBindings.Add("Text", source, "Backpack");
                txtVehicel.DataBindings.Add("Text", source, "Vehicel");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Transports");
            }
        }

        public void LoadOrderDetail()
        {
            try
            {
                var Address = orderDetailRepo.GetOrderDetailbyOrderDetailID(OrderDetailID);
                BindingSource source = new BindingSource();
                source.DataSource = Address;

                txtAddress.DataBindings.Clear();
                txtAddress.DataBindings.Add("Text", source, "AddressShip");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load Address Ship");
            }
        }
        private void parseTotalPrice()
        {
            var orderDetail = orderDetailRepo.GetOrderDetailbyOrderDetailID(OrderDetailID);
            lblTotalPrice.Text = orderDetail.TotalPrice.ToString();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmBird frmBird = new frmBird();
            frmBird.ShowDialog();
        }
    }
}
