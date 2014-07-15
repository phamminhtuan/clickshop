using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        public int OrderId { get; set; }
        public System.Guid UserId { get; set; }
        public int TableId { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> Total { get; set; }
        public bool IsPaid { get; set; }
        public string Note { get; set; }
        public Nullable<int> Promotion { get; set; }
        public virtual iTable iTable { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
