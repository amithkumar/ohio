/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    public class AccountSummaryModel
    {
        public string AccountNumber { get; set; }

        public string Location { get; set; }

        public string AccountHolder { get; set; }

        public DateTime EnrolledSince { get; set; }

        public string EnrolledSinceDescription { get; set; }

        public bool HasSmartPlan { get; set; }

        public bool HasAutoRebalancing { get; set; }

        public decimal FirstYearPerformance { get; set; }

        public decimal ThirdYearPerformance { get; set; }

        public decimal FivthYearPerformance { get; set; }

        public decimal TenthYearPerformance { get; set; }

        public IList<AccountSummaryFundModel> FundAssets { get; set; }

        public IList<AccountSummaryFundModel> FundClassifications { get; set; }

        public decimal PreTaxContribution { get; set; }

        public decimal YTDContribution { get; set; }

        public IList<AccountSummaryFundModel> PreTaxContributions { get; set; }
    }
}