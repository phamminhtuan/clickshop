using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clickshop.Data.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderId);

            // Properties
            this.Property(t => t.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.TableId).HasColumnName("TableId");
            this.Property(t => t.DateCreate).HasColumnName("DateCreate");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.IsPaid).HasColumnName("IsPaid");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Promotion).HasColumnName("Promotion");

            // Relationships
            this.HasRequired(t => t.iTable)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.TableId);

        }
    }
}
