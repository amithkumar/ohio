/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents withdrawals summary.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class WithdrawalSummaryModel
    {
        /// <summary>
        /// Gets or sets the account value.
        /// </summary>
        /// <value>
        /// The account value.
        /// </value>
        public decimal AccountValue { get; set; }

        /// <summary>
        /// Gets or sets the required minimum distribution.
        /// </summary>
        /// <value>
        /// The required minimum distribution.
        /// </value>
        public decimal RequiredMinDistribution { get; set; }

        /// <summary>
        /// Gets or sets the year to date payments.
        /// </summary>
        /// <value>
        /// The year to date payments.
        /// </value>
        public decimal YearToDatePayments { get; set; }

        /// <summary>
        /// Gets or sets the remaining RMD balance.
        /// </summary>
        /// <value>
        /// The remaining RMD balance.
        /// </value>
        public decimal RemainingRMDBalance { get; set; }

        /// <summary>
        /// Gets or sets the current withdrawals.
        /// </summary>
        /// <value>
        /// The current withdrawals.
        /// </value>
        public IList<WithdrawalModel> CurrentWithdrawals { get; set; }

        /// <summary>
        /// Gets or sets the pending withdrawals.
        /// </summary>
        /// <value>
        /// The pending withdrawals.
        /// </value>
        public IList<WithdrawalModel> PendingWithdrawals { get; set; }
    }
}