using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class newsviewMap : EntityTypeConfiguration<newsview>
    {
        public newsviewMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.IpAddress)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("newsview", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.IpAddress).HasColumnName("IpAddress");
            //this.Property(t => t.User_id).HasColumnName("User_id");
            //this.Property(t => t.News_id).HasColumnName("News_id");

            // Relationships
            this.HasOptional(t => t.news)
                .WithMany(t => t.newsviews)
                .Map(x => x.MapKey("News_id"));
                //.HasForeignKey(d => d.News_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.newsviews)
                .Map(x => x.MapKey("User_id"));
                //.HasForeignKey(d => d.User_id);

        }
    }
}
