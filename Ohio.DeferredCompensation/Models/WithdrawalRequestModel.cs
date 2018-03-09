/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents withdrawal request.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class WithdrawalRequestModel
    {
        /// <summary>
        /// Gets or sets the access code.
        /// </summary>
        /// <value>
        /// The access code.
        /// </value>
        [Required]
        public string AccessCode { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        /// <value>
        /// The plan.
        /// </value>
        [Required]
        public string Plan { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        [Required]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the payment frequency.
        /// </summary>
        /// <value>
        /// The payment frequency.
        /// </value>
        public string PaymentFrequency { get; set; }

        /// <summary>
        /// Gets or sets the payment option.
        /// </summary>
        /// <value>
        /// The payment option.
        /// </value>
        [Required]
        public string PaymentOption { get; set; }

        /// <summary>
        /// Gets or sets the payment option dollar amount.
        /// </summary>
        /// <value>
        /// The payment option dollar amount.
        /// </value>
        public decimal? PaymentOptionDollarAmount { get; set; }

        /// <summary>
        /// Gets or sets the percent to withdraw.
        /// </summary>
        /// <value>
        /// The percent to withdraw.
        /// </value>
        public decimal? PaymentOptionPercentToWithdraw { get; set; }

        /// <summary>
        /// Gets or sets the time period.
        /// </summary>
        /// <value>
        /// The time period.
        /// </value>
        public decimal? PaymentOptionTimePeriod { get; set; }

        /// <summary>
        /// Gets or sets the fund selection option.
        /// </summary>
        /// <value>
        /// The fund selection option.
        /// </value>
        [Required]
        public string FundSelectionOption { get; set; }

        /// <summary>
        /// Gets or sets the fund selection selected fund.
        /// </summary>
        /// <value>
        /// The fund selection selected fund.
        /// </value>
        public string FundSelectionSelectedFund { get; set; }

        /// <summary>
        /// Gets or sets the deposit option.
        /// </summary>
        /// <value>
        /// The deposit option.
        /// </value>
        [Required]
        public string DepositOption { get; set; }

        /// <summary>
        /// Gets or sets the deposit routing number.
        /// </summary>
        /// <value>
        /// The deposit routing number.
        /// </value>
        public string DepositRoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets the new deposit routing number.
        /// </summary>
        /// <value>
        /// The new deposit routing number.
        /// </value>
        public string NewDepositRoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets the deposit bank account.
        /// </summary>
        /// <value>
        /// The deposit bank account.
        /// </value>
        public string DepositBankAccount { get; set; }

        /// <summary>
        /// Gets or sets the new deposit bank account.
        /// </summary>
        /// <value>
        /// The new deposit bank account.
        /// </value>
        public string NewDepositBankAccount { get; set; }

        /// <summary>
        /// Gets or sets the name of the deposit bank.
        /// </summary>
        /// <value>
        /// The name of the deposit bank.
        /// </value>
        public string DepositBankName { get; set; }

        /// <summary>
        /// Gets or sets the deposit type or account.
        /// </summary>
        /// <value>
        /// The deposit type or account.
        /// </value>
        [Required]
        public string DepositTypeOrAccount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether federal tax exempt is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if federal tax exempt is enabled; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool FederalTaxExempt { get; set; }

        /// <summary>
        /// Gets or sets the federal tax withholding percentage.
        /// </summary>
        /// <value>
        /// The federal tax withholding percentage.
        /// </value>
        public decimal? FederalTaxWithholdingPercentage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether account is married.
        /// </summary>
        /// <value>
        ///   <c>true</c> if account is married; otherwise, <c>false</c>.
        /// </value>
        public bool MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the federal tax number of allowances.
        /// </summary>
        /// <value>
        /// The federal tax number of allowances.
        /// </value>
        public int? FederalTaxNumberOfAllowances { get; set; }

        /// <summary>
        /// Gets or sets the federal tax additional withholding.
        /// </summary>
        /// <value>
        /// The federal tax additional withholding.
        /// </value>
        public decimal? FederalTaxAdditionalWithholding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether state tax exempt is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if state tax exempt is enabled; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool StateTaxExempt { get; set; }

        /// <summary>
        /// Gets or sets the state tax option.
        /// </summary>
        /// <value>
        /// The state tax option.
        /// </value>
        [Required]
        public string StateTaxOption { get; set; }

        /// <summary>
        /// Gets or sets the state tax number of allowances.
        /// </summary>
        /// <value>
        /// The state tax number of allowances.
        /// </value>
        public int? StateTaxNumberOfAllowances { get; set; }

        /// <summary>
        /// Gets or sets the state tax withholding amount.
        /// </summary>
        /// <value>
        /// The state tax withholding amount.
        /// </value>
        public decimal? StateTaxWithholdingAmount { get; set; }

        /// <summary>
        /// Gets or sets the state tax withholding percentage.
        /// </summary>
        /// <value>
        /// The state tax withholding percentage.
        /// </value>
        public decimal? StateTaxWithholdingPercentage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether agreement is accepted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if agreement is accepted; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool AgreementAccepted { get; set; }
    }
}