using Autofac;
using ProductCategory.Business.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac.Integration.Mvc;

namespace ProductCategoryWebApp.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            
            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

            //Register our Service dependencies
            builder.RegisterModule(new ServiceModule());

            var container = builder.Build();
                       
            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}