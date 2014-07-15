using System;
using System.Collections.Generic;

namespace Clickshop.Data.Models
{
    public partial class User
    {
        public User()
        {
            this.Roles = new List<Role>();
        }

        public System.Guid Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
