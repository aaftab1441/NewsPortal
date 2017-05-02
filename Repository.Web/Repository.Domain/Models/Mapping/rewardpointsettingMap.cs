using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class rewardpointsettingMap : EntityTypeConfiguration<rewardpointsetting>
    {
        public rewardpointsettingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DisplayName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("rewardpointsettings", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TotalIncome).HasColumnName("TotalIncome");
            this.Property(t => t.TotalOutcome).HasColumnName("TotalOutcome");
            this.Property(t => t.TotalShareOut).HasColumnName("TotalShareOut");
            this.Property(t => t.IsOutcomeIncluded).HasColumnName("IsOutcomeIncluded");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.Period).HasColumnName("Period");
        }
    }
}
