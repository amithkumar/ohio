/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to change profile phone number.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ChangeProfilePhoneModel : ChangePhoneModel
    {
        /// <summary>
        /// Gets or sets the confirm phone number.
        /// </summary>
        /// <value>
        /// The confirm phone number.
        /// </value>
        [Required]
        public string ConfirmPhoneNumber { get; set; }
    }
}