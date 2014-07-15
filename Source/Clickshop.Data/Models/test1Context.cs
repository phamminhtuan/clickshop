using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Clickshop.Data.Models.Mapping;

namespace Clickshop.Data.Models
{
    public partial class test1Context : DbContext
    {
        static test1Context()
        {
            Database.SetInitializer<test1Context>(null);
        }

        public test1Context()
            : base("Name=test1Context")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<iTable> iTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new iTableMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SettingMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
