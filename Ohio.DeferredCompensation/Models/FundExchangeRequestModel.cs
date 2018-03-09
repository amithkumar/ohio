/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents fund exchange request.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class FundExchangeRequestModel
    {
        /// <summary>
        /// Gets or sets the exchange from.
        /// </summary>
        /// <value>
        /// The exchange from.
        /// </value>
        [Required]
        public string ExchangeFrom { get; set; }

        /// <summary>
        /// Gets or sets the exchange percentage.
        /// </summary>
        /// <value>
        /// The exchange percentage.
        /// </value>
        public decimal? ExchangePercentage { get; set; }

        /// <summary>
        /// Gets or sets the templeton foreign value.
        /// </summary>
        /// <value>
        /// The templeton foreign value.
        /// </value>
        public decimal? TempletonForeign { get; set; }

        /// <summary>
        /// Gets or sets the small cap Ohio DC large cap growth value.
        /// </summary>
        /// <value>
        /// The small cap Ohio DC large cap growth value.
        /// </value>
        public decimal? SmallCapOhioDCLargeCapGrowth { get; set; }

        /// <summary>
        /// Gets or sets the mid cap Ohio DC large cap growth value.
        /// </summary>
        /// <value>
        /// The mid cap Ohio DC large cap growth value.
        /// </value>
        public decimal? MidCapOhioDCLargeCapGrowth { get; set; }

        /// <summary>
        /// Gets or sets the dodge and cox stocks value.
        /// </summary>
        /// <value>
        /// The dodge and cox stocks value.
        /// </value>
        public decimal? DodgeAndCoxStocks { get; set; }

        /// <summary>
        /// Gets or sets the fidelity contrafund value.
        /// </summary>
        /// <value>
        /// The fidelity contrafund value.
        /// </value>
        public decimal? FidelityContrafund { get; set; }

        /// <summary>
        /// Gets or sets the fidelity growth company value.
        /// </summary>
        /// <value>
        /// The fidelity growth company value.
        /// </value>
        public decimal? FidelityGrowthCompany { get; set; }

        /// <summary>
        /// Gets or sets the large cap Ohio DC large cap growth value.
        /// </summary>
        /// <value>
        /// The large cap Ohio DC large cap growth value.
        /// </value>
        public decimal? LargeCapOhioDCLargeCapGrowth { get; set; }

        /// <summary>
        /// Gets or sets the Lifepath2020 value.
        /// </summary>
        /// <value>
        /// The Lifepath2020 value.
        /// </value>
        public decimal? Lifepath2020 { get; set; }

        /// <summary>
        /// Gets or sets the Ohio DC intermediate bond value.
        /// </summary>
        /// <value>
        /// The Ohio DC intermediate bond value.
        /// </value>
        public decimal? OhioDCIntermediateBond { get; set; }

        /// <summary>
        /// Gets or sets the index of the vanguard total bond market value.
        /// </summary>
        /// <value>
        /// The index of the vanguard total bond market value.
        /// </value>
        public decimal? VanguardTotalBondMarketIndex { get; set; }
    }
}