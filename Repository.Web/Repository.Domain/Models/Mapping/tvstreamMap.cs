using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class tvstreamMap : EntityTypeConfiguration<tvstream>
    {
        public tvstreamMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StreamHour)
                .HasMaxLength(255);

            this.Property(t => t.Title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tvstream", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StreamHour).HasColumnName("StreamHour");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Status).HasColumnName("Status");
            //this.Property(t => t.News_id).HasColumnName("News_id");

            // Relationships
            this.HasOptional(t => t.news)
                .WithMany(t => t.tvstreams)
                .Map(x => x.MapKey("News_id"));
                //.HasForeignKey(d => d.News_id);

        }
    }
}
