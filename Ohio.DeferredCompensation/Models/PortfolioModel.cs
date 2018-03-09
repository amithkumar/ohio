/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
namespace Ohio.DeferredCompensation.Models
{
    public class PortfolioModel
    {
        public string FundName { get; set; }

        public int Conservative { get; set; }

        public int ModeratelyConservative { get; set; }

        public int Moderate { get; set; }

        public int ModeratelyAggressive { get; set; }

        public int Aggressive { get; set; }
    }
}