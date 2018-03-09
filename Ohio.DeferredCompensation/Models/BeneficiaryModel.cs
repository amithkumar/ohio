/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class BeneficiaryModel
    {
        [Required]
        public bool IsPrimary { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Relation { get; set; }

        [Required]
        public int Percent { get; set; }
    }
}