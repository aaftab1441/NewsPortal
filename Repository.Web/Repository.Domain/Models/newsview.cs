using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class newsview
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string IpAddress { get; set; }
        //public int? User_id { get; set; }
        //public int? News_id { get; set; }
        public virtual news news { get; set; }
        public virtual user user { get; set; }
    }
}
