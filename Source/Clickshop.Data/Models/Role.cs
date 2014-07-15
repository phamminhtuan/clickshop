using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public System.Guid RoleID { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
