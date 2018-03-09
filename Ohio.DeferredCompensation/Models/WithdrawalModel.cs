/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents withdrawal.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class WithdrawalModel
    {
        /// <summary>
        /// Gets or sets the request number.
        /// </summary>
        /// <value>
        /// The request number.
        /// </value>
        public string RequestNumber { get; set; }

        /// <summary>
        /// Gets or sets the entry date.
        /// </summary>
        /// <value>
        /// The entry date.
        /// </value>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the account value.
        /// </summary>
        /// <value>
        /// The account value.
        /// </value>
        public decimal AccountValue { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the stop date.
        /// </summary>
        /// <value>
        /// The stop date.
        /// </value>
        public DateTime StopDate { get; set; }

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
        public decimal PaymentOption { get; set; }

        /// <summary>
        /// Gets or sets the gross amount.
        /// </summary>
        /// <value>
        /// The gross amount.
        /// </value>
        public decimal GrossAmount { get; set; }

        /// <summary>
        /// Gets or sets the net amount.
        /// </summary>
        /// <value>
        /// The net amount.
        /// </value>
        public decimal NetAmount { get; set; }

        /// <summary>
        /// Gets or sets the fund selection.
        /// </summary>
        /// <value>
        /// The fund selection.
        /// </value>
        public string FundSelection { get; set; }

        /// <summary>
        /// Gets or sets the deposit option.
        /// </summary>
        /// <value>
        /// The deposit option.
        /// </value>
        public string DepositOption { get; set; }

        /// <summary>
        /// Gets or sets the routing number.
        /// </summary>
        /// <value>
        /// The routing number.
        /// </value>
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets the bank account number.
        /// </summary>
        /// <value>
        /// The bank account number.
        /// </value>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank.
        /// </summary>
        /// <value>
        /// The name of the bank.
        /// </value>
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets the type of the account.
        /// </summary>
        /// <value>
        /// The type of the account.
        /// </value>
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether federal tax exempt is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if federal tax exempt is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool FederalTaxExempt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether account is married.
        /// </summary>
        /// <value>
        ///   <c>true</c> if account is married; otherwise, <c>false</c>.
        /// </value>
        public bool MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the federal number of allowances.
        /// </summary>
        /// <value>
        /// The federal number of allowances.
        /// </value>
        public int FederalNumberOfAllowances { get; set; }

        /// <summary>
        /// Gets or sets the federal additional withholding.
        /// </summary>
        /// <value>
        /// The federal additional withholding.
        /// </value>
        public decimal FederalAdditionalWithholding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether state tax exempt is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if state tax exempt is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool StateTaxExempt { get; set; }

        /// <summary>
        /// Gets or sets the state number of allowances.
        /// </summary>
        /// <value>
        /// The state number of allowances.
        /// </value>
        public int StateNumberOfAllowances { get; set; }

        /// <summary>
        /// Gets or sets the state additional withholding.
        /// </summary>
        /// <value>
        /// The state additional withholding.
        /// </value>
        public decimal StateAdditionalWithholding { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the next payment date.
        /// </summary>
        /// <value>
        /// The next payment date.
        /// </value>
        public DateTime NextPaymentDate { get; set; }
    }
}