/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents fund exchange.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class FundExchangeModel
    {
        /// <summary>
        /// Gets or sets the exchange from.
        /// </summary>
        /// <value>
        /// The exchange from.
        /// </value>
        public string ExchangeFrom { get; set; }

        /// <summary>
        /// Gets or sets the exchange from value.
        /// </summary>
        /// <value>
        /// The exchange from value.
        /// </value>
        public decimal ExchangeFromValue { get; set; }

        /// <summary>
        /// Gets or sets the exchange to.
        /// </summary>
        /// <value>
        /// The exchange to.
        /// </value>
        public IList<string> ExchangeTo { get; set; }

        /// <summary>
        /// Gets or sets the exchange to value.
        /// </summary>
        /// <value>
        /// The exchange to value.
        /// </value>
        public decimal ExchangeToValue { get; set; }
    }
}