/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class AssetAllocationToolModel
    {
        [Required]
        public string InvestmentStyle { get; set; }

        [Required]
        public string AgeRange { get; set; }

        [Required]
        public string WithdrawingFromRetirementBegin { get; set; }

        [Required]
        public bool HaveOtherRetirementSavings { get; set; }

        [Required]
        public string RiskTolerance { get; set; }

        [Required]
        public string InvestmentFeeling { get; set; }

        [Required]
        public string SelectedPortfolio { get; set; }
    }
}