using HiwDI.Core;
using HiwDI.Samples.Mvc.Repositories.UserRepositories;
using HiwDI.Samples.Mvc.Services.UserServices;
using HiwDI.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HiwDI.Samples.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var diContainer = new HiwDIContainer();
            diContainer.Register<IUserService, UserService>();
            diContainer.Register<IUserRepository, UserRepository>();            

            var diResolver = new HiwDIResolver(diContainer);

            DependencyResolver.SetResolver(diResolver);
        }
    }
}
