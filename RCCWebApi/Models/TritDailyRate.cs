﻿using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritDailyRate
    {
        public int DailyRateId { get; set; }
        public DateTime DailyDate { get; set; }
        public decimal? LiveRate { get; set; }
        public decimal? SkinlessRate { get; set; }
        public decimal? WithSkinRate { get; set; }
        public TimeSpan CutOffTime { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }

        public virtual TritUser? UpdatedByNavigation { get; set; }
    }
}
