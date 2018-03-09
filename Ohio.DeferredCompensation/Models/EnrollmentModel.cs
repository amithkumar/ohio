/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class EnrollmentModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Initial { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string PersonalPhone { get; set; }

        [Required]
        public string EmailId { get; set; }

        [Required]
        public string Employer { get; set; }

        [Required]
        public string RetirementPlan { get; set; }

        [Required]
        public decimal AmountToContribute { get; set; }

        [Required]
        public string PayFrequency { get; set; }

        [Required]
        public string EnrollPlan { get; set; }

        [Required]
        public string InvestOption { get; set; }

        [Required]
        public string AllocationOption { get; set; }

        [Required]
        public decimal TempletonForeign { get; set; }

        [Required]
        public decimal VanguardInternationalGrowth { get; set; }

        [Required]
        public decimal VanguardTotalInternationalStockIndex { get; set; }

        [Required]
        public decimal OhioDCSmallCapValue { get; set; }

        [Required]
        public decimal VanguardSmallCapIndex { get; set; }

        [Required]
        public decimal VangaurdCapitalOpportunity { get; set; }

        [Required]
        public decimal DodgeAndCoxStocks { get; set; }

        [Required]
        public decimal FidelityContrafund { get; set; }

        [Required]
        public decimal FidelityGrowthCompany { get; set; }

        [Required]
        public decimal OhioDCLargeCapGrowth { get; set; }

        [Required]
        public decimal Lifepath2020 { get; set; }

        [Required]
        public decimal Lifepath2025 { get; set; }

        [Required]
        public decimal Lifepath2030 { get; set; }

        [Required]
        public decimal LifepathRetirement { get; set; }

        [Required]
        public decimal OhioDCIntermediateBond { get; set; }

        [Required]
        public decimal VanguardTotalBondMarketIndex { get; set; }

        [Required]
        public string SmartPlanOption { get; set; }

        public string SmartPlanAmount { get; set; }

        public string StartingMonth { get; set; }

        public string StartingYear { get; set; }

        [Required]
        public string PrimaryBeneficientName { get; set; }

        [Required]
        public string PrimaryBeneficientSSN { get; set; }

        [Required]
        public DateTime PrimaryBeneficientDateOfBirth { get; set; }

        [Required]
        public string PrimaryBeneficientRelation { get; set; }

        [Required]
        public int PrimaryBeneficientPercent { get; set; }

        [Required]
        public string ContingentBeneficientName { get; set; }

        [Required]
        public string ContingentBeneficientSSN { get; set; }

        [Required]
        public DateTime ContingentBeneficientDateOfBirth { get; set; }

        [Required]
        public string ContingentBeneficientRelation { get; set; }

        [Required]
        public int ContingentBeneficientPercent { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool AgreementAccepted { get; set; }
    }
}