using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ShoolJournal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected static NLog.Logger Logger =NLog.LogManager.GetCurrentClassLogger();

        protected void Application_Start()
        {
            Logger.Info(@"Application Start");

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected  void Init()
        {
            Logger.Info(System.Reflection.MethodInfo.GetCurrentMethod().Name);
            //base.Init();
        }

        protected void Dispose()
        {
            Logger.Info(System.Reflection.MethodInfo.GetCurrentMethod().Name);
        }

        protected void Application_Error()
        {
            Logger.Error(@"Application Error occured");
        }
    }
}
