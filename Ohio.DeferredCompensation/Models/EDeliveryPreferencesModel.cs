/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to change E-Delivery preferences.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class EDeliveryPreferencesModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether quarterly statement and focus news letter should be enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if quarterly statement and focus news letter should be enabled; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool QuarterlyStatementAndFocusNewsLetter { get; set; }
    }
}
