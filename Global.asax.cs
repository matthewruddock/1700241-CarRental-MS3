﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace _1700241_CarRental_MS2
{
    public class Global : HttpApplication
    {
        /*
        void Application_Error(object sender, EventArgs e)
        {
            //Exception ex = Server.GetLastError();
            //Server.ClearError();
            //Response.Redirect("ErrorPage.aspx");
        }*/
        
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}