﻿using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using DidYouFall.App_Start;
using DidYouFall.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DidYouFall
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Type[] types = {
                              typeof(User),
                               typeof(Server),
                };

            if (!ActiveRecordStarter.IsInitialized)
                ActiveRecordStarter.Initialize(ActiveRecordSectionHandler.Instance, types);
        }
    }
}