﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace TypeScriptHTMLApp1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            int i = 0;
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}