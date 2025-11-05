using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTSManagementWinApp
{
    public partial class frmTransport : Form
    {
        ITransportRepo repo = new TransportRepo();
        IOrderRepo orderRepo = new OrderRepo();
        public int OrderID { get; set; }
        public string phone { get; set; }
        public frmTransport()
        {
            InitializeComponent();
        }



        private void frmTransport_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var order = orderRepo.GetOrderByOrderID(OrderID);
            orderRepo.DeleteOrder(order);
            this.Close();//đóng form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textVehicel = "";
            string textBackpack = "";
            double price = 0;
            if (rbCar.Checked == true)
            {
                textVehicel = "Car";
            }
            else if (rbAirplane.Checked == true)
            {
                textVehicel = "Airplane";
            }

            if (rbSoft.Checked == true)
            {
                textBackpack = "A&E Soft-Sided Bird Travel Cage";
                price = 50;
            }
            else if (rbFerplast.Checked == true)
            {
                textBackpack = "Ferplast Rectangular Cage";
                price = 93;
            }
            else if (rbPawhut.Checked == true)
            {
                textBackpack = "Pawhut Backpack Bird Carrier";
                price = 50;
            }

            var transport = new Transport
            {
                //ProductId = int.Parse(txtProductId.Text),
                MethodShip = "",
                Vehicel = textVehicel,
                Backpack = textBackpack,
                Price = price,
            };
            repo.AddTransport(transport);

            btnSave.Text = "Save";
            btnSave.Enabled = false;

            frmCheckout frmCheckout = new frmCheckout();
            frmCheckout.phone = phone;
            frmCheckout.OrderID = OrderID;
            frmCheckout.TransportID = transport.TransportId;

            this.Hide();
            frmCheckout.ShowDialog();

        }
    }
}
