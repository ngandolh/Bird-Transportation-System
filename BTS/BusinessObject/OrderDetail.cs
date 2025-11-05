using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class OrderDetail
    {
        public int OrderIdetail { get; set; }
        public int OrderId { get; set; }
        public string AddressShip { get; set; }
        public string Phone { get; set; }
        public string Pay { get; set; }
        public int TransportId { get; set; }
        public double? TotalPrice { get; set; }
        public string AddressFrom { get; set; }

        public virtual Order Order { get; set; }
        public virtual Transport Transport { get; set; }
    }
}
