using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LightInject;
using IsaacBroyles.Utilities;
using IsaacBroyles.Repositories;

namespace IsaacBroyles
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new ServiceContainer();

            container.RegisterControllers();
            container.Register<IFormatter, MarkdownUtility>();
            container.Register<PostRepository>();

            container.EnableMvc();
        }
    }
}
