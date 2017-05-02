using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.Surname)
                .HasMaxLength(255);

            this.Property(t => t.Username)
                .HasMaxLength(255);

            this.Property(t => t.Email)
                .HasMaxLength(255);

            this.Property(t => t.Password)
                .HasMaxLength(255);

            this.Property(t => t.VerificationCode)
                .HasMaxLength(255);

            this.Property(t => t.PhotoUrl)
                .HasMaxLength(255);

            this.Property(t => t.UserGuid)
                .HasMaxLength(100);

            this.Property(t => t.AboutUser)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("user", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
            this.Property(t => t.ApprovedDate).HasColumnName("ApprovedDate");
            this.Property(t => t.LastSeenDate).HasColumnName("LastSeenDate");
            this.Property(t => t.PublishedNewsCount).HasColumnName("PublishedNewsCount");
            this.Property(t => t.TotalNewsCount).HasColumnName("TotalNewsCount");
            this.Property(t => t.VerificationCode).HasColumnName("VerificationCode");
            this.Property(t => t.PhotoUrl).HasColumnName("PhotoUrl");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.UserRole).HasColumnName("UserRole");
            this.Property(t => t.UserGuid).HasColumnName("UserGuid");
            this.Property(t => t.ShowOnWebSite).HasColumnName("ShowOnWebSite");
            this.Property(t => t.IsReplacement).HasColumnName("IsReplacement");
            this.Property(t => t.AboutUser).HasColumnName("AboutUser");
            this.Property(t => t.ExtraPoint).HasColumnName("ExtraPoint");
            this.Property(t => t.HasSuperadminPriviligies).HasColumnName("HasSuperadminPriviligies");
            this.Property(t => t.HasModerationPriviligies).HasColumnName("HasModerationPriviligies");
            this.Property(t => t.IsExTeamMember).HasColumnName("IsExTeamMember");
            this.Property(t => t.ExUserRole).HasColumnName("ExUserRole");
            this.Property(t => t.TotalPoint).HasColumnName("TotalPoint");
        }
    }
}
