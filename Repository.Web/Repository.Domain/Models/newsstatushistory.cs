using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class newsstatushistory
    {
        public int Id { get; set; }
        public DateTime? ActionTime { get; set; }
        public int? NewsStatus { get; set; }
        //public int? ActionUser_id { get; set; }
        //public int? News_id { get; set; }
        public virtual news news { get; set; }
        public virtual user user { get; set; }
    }
}
