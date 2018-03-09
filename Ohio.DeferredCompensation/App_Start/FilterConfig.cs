/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Web.Mvc;

namespace Ohio.DeferredCompensation
{
    /// <summary>
    /// The Filters Configuration.
    /// </summary>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class FilterConfig
    {
        /// <summary>
        /// Registers the global filters.
        /// </summary>
        /// <param name="filters">The filters.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
