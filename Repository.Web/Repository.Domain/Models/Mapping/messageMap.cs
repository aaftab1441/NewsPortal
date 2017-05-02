using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Subject)
                .HasMaxLength(255);

            this.Property(t => t.Body)
                .HasMaxLength(2500);

            // Table & Column Mappings
            this.ToTable("message", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.IsFromDeleted).HasColumnName("IsFromDeleted");
            this.Property(t => t.IsToDeleted).HasColumnName("IsToDeleted");
            //this.Property(t => t.ToUser_id).HasColumnName("ToUser_id");
            //this.Property(t => t.FromUser_id).HasColumnName("FromUser_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.messages)
                .Map(x => x.MapKey("ToUser_id"));
            //.HasForeignKey(d => d.ToUser_id);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.messages1)
                .Map(x => x.MapKey("FromUser_id"));
                //.HasForeignKey(d => d.FromUser_id);

        }
    }
}
