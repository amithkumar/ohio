/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;

namespace Ohio.DeferredCompensation.Models
{
    public class EnableSummaryModel
    {
        public string Frequency { get; set; }

        public DateTime NextRebalancingDate { get; set; }

        public DateTime LastUpdate { get; set; }

        public decimal TempletonForeign { get; set; }

        public decimal SmallCapOhioGrowth { get; set; }

        public decimal MidCapOhioGrowth { get; set; }
    }
}