using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class iTable
    {
        public iTable()
        {
            this.Orders = new List<Order>();
        }

        public int TableId { get; set; }
        public string TableName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
