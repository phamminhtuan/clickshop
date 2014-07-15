using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clickshop.Data.Models.Mapping
{
    public class iTableMap : EntityTypeConfiguration<iTable>
    {
        public iTableMap()
        {
            // Primary Key
            this.HasKey(t => t.TableId);

            // Properties
            this.Property(t => t.TableId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("iTable");
            this.Property(t => t.TableId).HasColumnName("TableId");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
