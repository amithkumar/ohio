/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to change email.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ChangeEmailModel
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
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the confirm email address.
        /// </summary>
        /// <value>
        /// The confirm email address.
        /// </value>
        [Required]
        public string ConfirmEmailAddress { get; set; }
    }
}
