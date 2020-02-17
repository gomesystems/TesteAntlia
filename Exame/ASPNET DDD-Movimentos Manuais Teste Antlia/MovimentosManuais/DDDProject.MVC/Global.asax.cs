using DDDProject.Application;
using DDDProject.Application.Interface;
using DDDProject.Domain.Interfaces.Repositories;
using DDDProject.Domain.Interfaces.Services;
using DDDProject.Domain.Services;
using DDDProject.Infra.Data.Repositories;
using DDDProject.MVC.AutoMapper;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DDDProject.MVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
