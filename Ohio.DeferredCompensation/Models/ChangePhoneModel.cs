/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to change phone number.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ChangePhoneModel
    {
        /// <summary>
        /// Gets or sets the access code.
        /// </summary>
        /// <value>
        /// The access code.
        /// </value>
        [Required]
        public string AccessCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [Required]
        public string PhoneNumber { get; set; }
    }
}