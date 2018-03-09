/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents contribution stock item.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ContributionStockModel
    {
        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the allocation amount.
        /// </summary>
        /// <value>
        /// The allocation amount.
        /// </value>
        public decimal AllocationAmount { get; set; }

        /// <summary>
        /// Gets or sets the allocation percentage.
        /// </summary>
        /// <value>
        /// The allocation percentage.
        /// </value>
        public decimal AllocationPercentage { get; set; }

        /// <summary>
        /// Gets or sets the pending allocation amount.
        /// </summary>
        /// <value>
        /// The pending allocation amount.
        /// </value>
        public decimal PendingAllocationAmount { get; set; }

        /// <summary>
        /// Gets or sets the pending allocation percentage.
        /// </summary>
        /// <value>
        /// The pending allocation percentage.
        /// </value>
        public decimal PendingAllocationPercentage { get; set; }

        /// <summary>
        /// Gets or sets the new allocation amount.
        /// </summary>
        /// <value>
        /// The new allocation amount.
        /// </value>
        [Required]
        public decimal NewAllocationAmount { get; set; }
    }
}