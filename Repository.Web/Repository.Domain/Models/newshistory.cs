using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class newshistory
    {
        public int Id { get; set; }
        public int? News_id { get; set; }
        public string Title { get; set; }
        public string SliderTitle { get; set; }
        public string PhotoUrl { get; set; }
        public string SliderPhotoUrl { get; set; }
        public bool? UseSliderPhoto { get; set; }
        public bool? UseSliderTitle { get; set; }
        public bool? ShowUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Details { get; set; }
        public string FriendlyUrl { get; set; }
        public int? Status { get; set; }
        public sbyte? NewsType { get; set; }
        public sbyte? MediaType { get; set; }
        public sbyte? IsPublishedBefore { get; set; }
        public DateTime? NewsDate { get; set; }
        public DateTime? ActionTime { get; set; }
        public string ActionUserName { get; set; }
        public int? NewsViewCount { get; set; }
        //public int? Replacement_id { get; set; }
        //public int? User_id { get; set; }
        //public int? ActionUser_id { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual user user2 { get; set; }
    }
}
