/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to change profile password.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ChangeProfilePasswordModel : ChangePasswordModel
    {
        /// <summary>
        /// Gets or sets the current password.
        /// </summary>
        /// <value>
        /// The current password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
    }
}
