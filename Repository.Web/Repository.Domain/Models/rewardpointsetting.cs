using System;
using System.Collections.Generic;

namespace Repository.Domain.Models
{
    public partial class rewardpointsetting
    {
        public int Id { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? TotalOutcome { get; set; }
        public decimal? TotalShareOut { get; set; }
        public bool? IsOutcomeIncluded { get; set; }
        public string DisplayName { get; set; }
        public int? Period { get; set; }
    }
}
