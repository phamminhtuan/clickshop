using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public Nullable<int> Price { get; set; }
        public string Unit { get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
