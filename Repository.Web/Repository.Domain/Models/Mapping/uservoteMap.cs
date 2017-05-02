using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class uservoteMap : EntityTypeConfiguration<uservote>
    {
        public uservoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("uservote", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.IsVoted).HasColumnName("IsVoted");
            //this.Property(t => t.ToUser_id).HasColumnName("ToUser_id");
            //this.Property(t => t.FromUser_id).HasColumnName("FromUser_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.uservotes)
                .Map(x => x.MapKey("ToUser_id"));
                //.HasForeignKey(d => d.ToUser_id);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.uservotes1)
                .Map(x => x.MapKey("FromUser_id"));
                //.HasForeignKey(d => d.FromUser_id);

        }
    }
}
