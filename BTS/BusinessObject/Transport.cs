using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Transport
    {
        public Transport()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int TransportId { get; set; }
        public string MethodShip { get; set; }
        public string Backpack { get; set; }
        public double? Price { get; set; }
        public string Vehicel { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
