using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Quality { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
