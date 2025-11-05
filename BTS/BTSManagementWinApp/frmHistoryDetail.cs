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
    public partial class frmHistoryDetail : Form
    {
        public int OrderID { get; set; }
        public int TransportID { get; set; }
        public int OrderDetailID { get; set; }
        IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        ITransportRepo transportRepo = new TransportRepo();
        public frmHistoryDetail()
        {
            InitializeComponent();
        }

        public int searchOrderDetaiID()
        {
            OrderDetail orderDetailID = orderDetailRepo.GetOrderDetailbyID(OrderID);
            return orderDetailID.OrderIdetail;
        }
        public void LoadTransportList()
        {
            try
            {
                OrderDetail orderDetailID = orderDetailRepo.GetOrderDetailbyID(OrderID);
                int TransportID = orderDetailID.TransportId;
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
                int OrderDetailID = searchOrderDetaiID();
                var Address = orderDetailRepo.GetOrderDetailbyOrderDetailID(OrderDetailID);
                BindingSource source = new BindingSource();
                source.DataSource = Address;

                txtAddress.DataBindings.Clear();
                txtAddressTo.DataBindings.Add("Text", source, "AddressShip");
                txtAddress.DataBindings.Add("Text", source, "AddressFrom");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load Address Ship");
            }
        }
        private void parseTotalPrice()
        {
            int OrderDetailID = searchOrderDetaiID();
            var orderDetail = orderDetailRepo.GetOrderDetailbyOrderDetailID(OrderDetailID);
            lblTotal.Text = orderDetail.TotalPrice.ToString();
        }

        private void frmHistoryDetail_Load(object sender, EventArgs e)
        {
            LoadTransportList();
            LoadOrderDetail();
            parseTotalPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                frmHistoryOrder frmHistoryOrder = new frmHistoryOrder();
                frmHistoryOrder.ShowDialog();
            }
        }
    }
}
