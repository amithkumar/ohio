/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ohio.DeferredCompensation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
