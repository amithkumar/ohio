/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents contribution.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ContributionModel
    {
        /// <summary>
        /// Gets or sets the current contribution amount.
        /// </summary>
        /// <value>
        /// The current contribution amount.
        /// </value>
        public decimal CurrentContributionAmount { get; set; }

        /// <summary>
        /// Gets or sets the new contribution amount.
        /// </summary>
        /// <value>
        /// The new contribution amount.
        /// </value>
        public decimal NewContributionAmount { get; set; }

        /// <summary>
        /// Gets or sets the new contribution effective date.
        /// </summary>
        /// <value>
        /// The new contribution effective date.
        /// </value>
        public DateTime? NewContributionEffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets the stock groups.
        /// </summary>
        /// <value>
        /// The stock groups.
        /// </value>
        public IList<ContributionStockGroupModel> StockGroups { get; set; }

        /// <summary>
        /// Gets or sets the pending contributions.
        /// </summary>
        /// <value>
        /// The pending contributions.
        /// </value>
        public IList<ContributionStockModel> PendingContributions { get; set; }

        /// <summary>
        /// Gets or sets the total amount.
        /// </summary>
        /// <value>
        /// The total amount.
        /// </value>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the total percentage.
        /// </summary>
        /// <value>
        /// The total percentage.
        /// </value>
        public decimal TotalPercentage { get; set; }
    }
}