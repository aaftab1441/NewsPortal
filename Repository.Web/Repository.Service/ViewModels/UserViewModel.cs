using Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service.ViewModels
{
    public class UserViewModel
    {
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
    }
}
