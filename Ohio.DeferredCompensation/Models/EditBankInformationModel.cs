/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that is used to add or edit profile bank information.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class EditBankInformationModel : BankInformationModel
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
        /// Gets or sets the confirm routing number.
        /// </summary>
        /// <value>
        /// The confirm routing number.
        /// </value>
        [Required]
        public string ConfirmRoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets the confirm account number.
        /// </summary>
        /// <value>
        /// The confirm account number.
        /// </value>
        [Required]
        public string ConfirmAccountNumber { get; set; }
    }
}