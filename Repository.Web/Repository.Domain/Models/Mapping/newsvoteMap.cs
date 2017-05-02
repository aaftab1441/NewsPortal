using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class newsvoteMap : EntityTypeConfiguration<newsvote>
    {
        public newsvoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("newsvote", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Vote).HasColumnName("Vote");
            this.Property(t => t.Date).HasColumnName("Date");
            //this.Property(t => t.User_id).HasColumnName("User_id");
            //this.Property(t => t.News_id).HasColumnName("News_id");

            // Relationships
            this.HasOptional(t => t.news)
                .WithMany(t => t.newsvotes)
                .Map(x => x.MapKey("News_id"));
                //.HasForeignKey(d => d.News_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.newsvotes)
                .Map(x => x.MapKey("User_id"));
                //.HasForeignKey(d => d.User_id);

        }
    }
}
