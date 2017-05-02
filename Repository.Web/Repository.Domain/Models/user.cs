using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class user
    {
        public user()
        {
            this.logins = new List<login>();
            this.messages = new List<message>();
            this.messages1 = new List<message>();
            this.news = new List<news>();
            this.news1 = new List<news>();
            this.newshistories = new List<newshistory>();
            this.newshistories1 = new List<newshistory>();
            this.newshistories2 = new List<newshistory>();
            this.newsstatushistories = new List<newsstatushistory>();
            this.newsviews = new List<newsview>();
            this.newsvotes = new List<newsvote>();
            this.rewardpoints = new List<rewardpoint>();
            this.uservotes = new List<uservote>();
            this.uservotes1 = new List<uservote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? LastSeenDate { get; set; }
        public int? PublishedNewsCount { get; set; }
        public int? TotalNewsCount { get; set; }
        public string VerificationCode { get; set; }
        public string PhotoUrl { get; set; }
        public int? Status { get; set; }
        public int? UserRole { get; set; }
        public string UserGuid { get; set; }
        public sbyte? ShowOnWebSite { get; set; }
        public bool? IsReplacement { get; set; }
        public string AboutUser { get; set; }
        public int? ExtraPoint { get; set; }
        public bool? HasSuperadminPriviligies { get; set; }
        public bool? HasModerationPriviligies { get; set; }
        public bool? IsExTeamMember { get; set; }
        public UserRole? ExUserRole { get; set; }
        public double? TotalPoint { get; set; }
        public virtual ICollection<login> logins { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<message> messages1 { get; set; }
        public virtual ICollection<news> news { get; set; }
        public virtual ICollection<news> news1 { get; set; }
        public virtual ICollection<newshistory> newshistories { get; set; }
        public virtual ICollection<newshistory> newshistories1 { get; set; }
        public virtual ICollection<newshistory> newshistories2 { get; set; }
        public virtual ICollection<newsstatushistory> newsstatushistories { get; set; }
        public virtual ICollection<newsview> newsviews { get; set; }
        public virtual ICollection<newsvote> newsvotes { get; set; }
        public virtual ICollection<rewardpoint> rewardpoints { get; set; }
        public virtual ICollection<uservote> uservotes { get; set; }
        public virtual ICollection<uservote> uservotes1 { get; set; }
    }
}
