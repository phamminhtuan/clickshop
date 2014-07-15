using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
