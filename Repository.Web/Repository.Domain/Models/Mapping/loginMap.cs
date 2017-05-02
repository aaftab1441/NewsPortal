using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class loginMap : EntityTypeConfiguration<login>
    {
        public loginMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Message)
                .HasMaxLength(255);

            this.Property(t => t.IpAddress)
                .HasMaxLength(255);

            this.Property(t => t.Username)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("login", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.IpAddress).HasColumnName("IpAddress");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.IsSuccess).HasColumnName("IsSuccess");
            //this.Property(t => t.User_id).HasColumnName("User_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.logins)
                .Map(x => x.MapKey("User_id"));
            //.HasForeignKey(d => d.User_id);

        }
    }
}
