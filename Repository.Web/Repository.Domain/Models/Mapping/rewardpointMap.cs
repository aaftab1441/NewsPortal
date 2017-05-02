using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class rewardpointMap : EntityTypeConfiguration<rewardpoint>
    {
        public rewardpointMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PointHistory)
                .HasMaxLength(1500);

            // Table & Column Mappings
            this.ToTable("rewardpoint", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Point).HasColumnName("Point");
            this.Property(t => t.ExtraPoint).HasColumnName("ExtraPoint");
            this.Property(t => t.TotalPoint).HasColumnName("TotalPoint");
            this.Property(t => t.Paid).HasColumnName("Paid");
            this.Property(t => t.Gain).HasColumnName("Gain");
            this.Property(t => t.PointHistory).HasColumnName("PointHistory");
            this.Property(t => t.CalculationDate).HasColumnName("CalculationDate");
            this.Property(t => t.Period).HasColumnName("Period");
            //this.Property(t => t.User_id).HasColumnName("User_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.rewardpoints)
                .Map(x => x.MapKey("User_id"));
                //.HasForeignKey(d => d.User_id);

        }
    }
}
