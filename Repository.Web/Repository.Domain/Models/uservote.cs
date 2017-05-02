using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class uservote
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsVoted { get; set; }
        //public int? ToUser_id { get; set; }
        //public int? FromUser_id { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
