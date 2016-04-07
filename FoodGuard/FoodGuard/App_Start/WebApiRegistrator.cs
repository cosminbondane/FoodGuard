using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Hosting;

namespace FoodGuard.App_Start
{
    public class WebApiRegistrator
    {
        public static void Register()
        {
            BuildManager.AddReferencedAssembly(Assembly.LoadFrom(HostingEnvironment.MapPath("~/bin/FoodGuard.WebApi.dll")));
        }
    }
}