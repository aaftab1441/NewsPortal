using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class newsstatushistoryMap : EntityTypeConfiguration<newsstatushistory>
    {
        public newsstatushistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("newsstatushistory", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ActionTime).HasColumnName("ActionTime");
            this.Property(t => t.NewsStatus).HasColumnName("NewsStatus");
            //this.Property(t => t.ActionUser_id).HasColumnName("ActionUser_id");
            //this.Property(t => t.News_id).HasColumnName("News_id");

            // Relationships
            this.HasOptional(t => t.news)
                .WithMany(t => t.newsstatushistories)
                .Map(x => x.MapKey("News_id"));
                //.HasForeignKey(d => d.News_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.newsstatushistories)
                .Map(x => x.MapKey("ActionUser_id"));
                //.HasForeignKey(d => d.ActionUser_id);

        }
    }
}
