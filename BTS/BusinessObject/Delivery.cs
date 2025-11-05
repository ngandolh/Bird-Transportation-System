using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Delivery
    {
        public int DeliveryId { get; set; }
        public string DeliveryName { get; set; }
        public int OrderIdetail { get; set; }

        public virtual OrderDetail OrderIdetailNavigation { get; set; }
    }
}
