/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class CollegeFundingCalculatorModel
    {
        [Required]
        public int YearsUntilCollege { get; set; }

        [Required]
        public decimal CurrentCollegeSavings { get; set; }

        [Required]
        public decimal AnnualCollegeCost { get; set; }

        [Required]
        public int NumberOfYearsEnrolled { get; set; }

        [Required]
        public decimal AccountGivenByOtherSources { get; set; }

        [Required]
        public decimal RateOfReturn { get; set; }

        [Required]
        public decimal CurrentTaxRate { get; set; }

        [Required]
        public decimal CollegeInflationRate { get; set; }
    }
}