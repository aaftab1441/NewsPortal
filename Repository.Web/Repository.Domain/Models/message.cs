using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class message
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsRead { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? IsFromDeleted { get; set; }
        public bool? IsToDeleted { get; set; }
        //public int? ToUser_id { get; set; }
        //public int? FromUser_id { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
