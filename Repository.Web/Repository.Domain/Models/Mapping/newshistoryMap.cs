using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Domain.Models.Mapping
{
    public class newshistoryMap : EntityTypeConfiguration<newshistory>
    {
        public newshistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(500);

            this.Property(t => t.SliderTitle)
                .HasMaxLength(255);

            this.Property(t => t.PhotoUrl)
                .HasMaxLength(500);

            this.Property(t => t.SliderPhotoUrl)
                .HasMaxLength(255);

            this.Property(t => t.Details)
                .HasMaxLength(65535);

            this.Property(t => t.FriendlyUrl)
                .HasMaxLength(255);

            this.Property(t => t.ActionUserName)
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("newshistory", "repository");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.News_id).HasColumnName("News_id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.SliderTitle).HasColumnName("SliderTitle");
            this.Property(t => t.PhotoUrl).HasColumnName("PhotoUrl");
            this.Property(t => t.SliderPhotoUrl).HasColumnName("SliderPhotoUrl");
            this.Property(t => t.UseSliderPhoto).HasColumnName("UseSliderPhoto");
            this.Property(t => t.UseSliderTitle).HasColumnName("UseSliderTitle");
            this.Property(t => t.ShowUserName).HasColumnName("ShowUserName");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.PublishDate).HasColumnName("PublishDate");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.FriendlyUrl).HasColumnName("FriendlyUrl");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NewsType).HasColumnName("NewsType");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.IsPublishedBefore).HasColumnName("IsPublishedBefore");
            this.Property(t => t.NewsDate).HasColumnName("NewsDate");
            this.Property(t => t.ActionTime).HasColumnName("ActionTime");
            this.Property(t => t.ActionUserName).HasColumnName("ActionUserName");
            this.Property(t => t.NewsViewCount).HasColumnName("NewsViewCount");
            //this.Property(t => t.Replacement_id).HasColumnName("Replacement_id");
            //this.Property(t => t.User_id).HasColumnName("User_id");
            //this.Property(t => t.ActionUser_id).HasColumnName("ActionUser_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.newshistories)
                .Map(x => x.MapKey("ActionUser_id"));
                //.HasForeignKey(d => d.ActionUser_id);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.newshistories1)
                .Map(x => x.MapKey("Replacement_id"));
            //.HasForeignKey(d => d.Replacement_id);
            this.HasOptional(t => t.user2)
                .WithMany(t => t.newshistories2)
                .Map(x => x.MapKey("User_id"));
                //.HasForeignKey(d => d.User_id);

        }
    }
}
