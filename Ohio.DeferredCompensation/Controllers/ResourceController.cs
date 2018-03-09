/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Web.Mvc;

namespace Ohio.DeferredCompensation.Controllers
{
    /// <summary>
    /// The controller to expose the actions related to resources.
    /// </summary>
    ///
    /// <threadsafety>
    /// This class is mutable but effectively thread-safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class ResourceController : Controller
    {
        /// <summary>
        /// Returns the main page.
        /// </summary>
        /// <returns>Action result.</returns>
        [Route("Resources")]
        public ActionResult Index()
        {
            return View();
        }
    }
}