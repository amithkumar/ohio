/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents a group of contribution stock items.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ContributionStockGroupModel
    {
        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        /// <value>
        /// The name of the group.
        /// </value>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the stocks.
        /// </summary>
        /// <value>
        /// The stocks.
        /// </value>
        public IList<ContributionStockModel> Stocks { get; set; }
    }
}