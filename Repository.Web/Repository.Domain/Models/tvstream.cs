using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class tvstream
    {
        public int Id { get; set; }
        public string StreamHour { get; set; }
        public string Title { get; set; }
        public bool? Status { get; set; }
        //public int? News_id { get; set; }
        public virtual news news { get; set; }
    }
}
