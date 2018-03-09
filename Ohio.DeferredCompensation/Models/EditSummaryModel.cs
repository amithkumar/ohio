/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class EditSummaryModel
    {
        [Required]
        public string Frequency { get; set; }

        [Required]
        public decimal TempletonForeign { get; set; }

        [Required]
        public decimal SmallOhioDCLargeCapGrowth { get; set; }

        [Required]
        public decimal MidOhioDCLargeCapGrowth { get; set; }

        [Required]
        public decimal DodgeAndCoxStocks { get; set; }

        [Required]
        public decimal FidelityContrafund { get; set; }

        [Required]
        public decimal FidelityGrowthCompany { get; set; }

        [Required]
        public decimal Lifepath2020 { get; set; }

        [Required]
        public decimal OhioDCIntermediateBond { get; set; }

        [Required]
        public decimal VanguardTotalBondMarketIndex { get; set; }
    }
}