using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clickshop.Data.Models.Mapping
{
    public class SettingMap : EntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            // Primary Key
            this.HasKey(t => t.SettingName);

            // Properties
            this.Property(t => t.SettingName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SettingValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Setting");
            this.Property(t => t.SettingName).HasColumnName("SettingName");
            this.Property(t => t.SettingValue).HasColumnName("SettingValue");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
