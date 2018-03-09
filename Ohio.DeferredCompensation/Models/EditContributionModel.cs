/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to edit account contribution.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class EditContributionModel
    {
        /// <summary>
        /// Gets or sets the current deferral amount.
        /// </summary>
        /// <value>
        /// The current deferral amount.
        /// </value>
        public decimal CurrentDeferralAmount { get; set; }

        /// <summary>
        /// Gets or sets the new deferral amount.
        /// </summary>
        /// <value>
        /// The new deferral amount.
        /// </value>
        [Required]
        public decimal? NewDeferralAmount { get; set; }

        /// <summary>
        /// Gets or sets the allocation option.
        /// </summary>
        /// <value>
        /// The allocation option.
        /// </value>
        [Required]
        public string AllocationOption { get; set; }

        /// <summary>
        /// Gets or sets the stock groups.
        /// </summary>
        /// <value>
        /// The stock groups.
        /// </value>
        public IList<ContributionStockGroupModel> StockGroups { get; set; }

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
