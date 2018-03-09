/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
namespace Ohio.DeferredCompensation.Models
{
    public class StockModel
    {
        public string InvestmentOption { get; set; }

        public string CurrentPrice { get; set; }

        public string HalfYearPrice { get; set; }

        public string OneYearValue { get; set; }

        public string ThreeYearValue { get; set; }

        public string FiveYearValue { get; set; }

        public string SinceAdoption { get; set; }

        public string AdoptionDate { get; set; }

        public string ExpenseRatio { get; set; }
    }
}