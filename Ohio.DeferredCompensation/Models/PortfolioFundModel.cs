/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    public class PortfolioFundModel
    {
        public string FundName { get; set; }

        public int Value { get; set; }

        public IList<string> Items { get; set; }
    }
}