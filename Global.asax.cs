using DIMVCPracticeUpdated.Interfaces;
using DIMVCPracticeUpdated.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace DIMVCPracticeUpdated
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IUnityContainer container = new UnityContainer();

            container.RegisterType<IUserSession, UserSession>();

            DependencyResolver.SetResolver(new PracticeDependencyResolver(container));
        }
    }
}
