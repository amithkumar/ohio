/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/

namespace Ohio.DeferredCompensation.Models
{
    /// <summary>
    /// A model class that represents Completed step data in My Profile pages.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable, so it is not thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class MyProfileCompletedStepModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the redirect action.
        /// </summary>
        /// <value>
        /// The redirect action.
        /// </value>
        public string RedirectAction { get; set; }

        /// <summary>
        /// Gets or sets the redirect label.
        /// </summary>
        /// <value>
        /// The redirect label.
        /// </value>
        public string RedirectLabel { get; set; }

        /// <summary>
        /// Gets or sets the redirect CSS class.
        /// </summary>
        /// <value>
        /// The redirect CSS class.
        /// </value>
        public string RedirectClass { get; set; }
    }
}