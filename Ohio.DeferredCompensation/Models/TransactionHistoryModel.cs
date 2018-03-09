/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/

using System;
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents transaction.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class TransactionHistoryModel
    {
        /// <summary>
        /// Gets or sets the filter start date.
        /// </summary>
        /// <value>
        /// The name filter start date.
        /// </value>
        public DateTime? FilterStartDate { get; set; }

        /// <summary>
        /// Gets or sets the filter end date.
        /// </summary>
        /// <value>
        /// The name filter end date.
        /// </value>
        public DateTime? FilterEndDate { get; set; }

        /// <summary>
        /// Gets or sets the list of transaction records.
        /// </summary>
        /// <value>
        /// The name list of transaction records.
        /// </value>
        public List<TransactionModel> Records { get; set; }        
        
    }
}