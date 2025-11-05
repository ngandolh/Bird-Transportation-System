using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Bird
    {
        public Bird()
        {
            Orders = new HashSet<Order>();
        }

        public int BirdId { get; set; }
        public string BirdName { get; set; }
        public string Origin { get; set; }
        public string Picture { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
