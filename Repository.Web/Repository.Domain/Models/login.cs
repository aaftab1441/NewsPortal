using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class login
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Message { get; set; }
        public string IpAddress { get; set; }
        public string Username { get; set; }
        public bool? IsSuccess { get; set; }
        //public int? User_id { get; set; }
        public virtual user user { get; set; }
    }
}
