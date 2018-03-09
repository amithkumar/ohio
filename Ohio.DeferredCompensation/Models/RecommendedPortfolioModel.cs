/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    public class RecommendedPortfolioModel
    {
        public string RecommendedPortfolio { get; set; }

        public IList<PortfolioModel> PortfolioModels { get; set; }

        public IList<PortfolioFundModel> Funds { get; set; }
    }
}