using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class rewardpoint
    {
        public int Id { get; set; }
        public decimal? Point { get; set; }
        public decimal? ExtraPoint { get; set; }
        public decimal? TotalPoint { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Gain { get; set; }
        public string PointHistory { get; set; }
        public DateTime? CalculationDate { get; set; }
        public int? Period { get; set; }
        //public int? User_id { get; set; }
        public virtual user user { get; set; }
    }
}
