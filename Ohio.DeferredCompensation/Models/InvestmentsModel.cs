/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    public class InvestmentsModel
    {
        public IList<FeeReimbursementRateModel> ReimbursementRates { get; set; }

        public DateTime Date { get; set; }

        public decimal CurrentQuarterYield { get; set; }

        public decimal PreviousQuarterYield { get; set; }

        public IList<StockModel> InternationalStocks { get; set; }

        public IList<StockModel> SmallCapStocks { get; set; }

        public IList<StockModel> MidCapStocks { get; set; }

        public IList<StockModel> LargeCapStocks { get; set; }
    }
}