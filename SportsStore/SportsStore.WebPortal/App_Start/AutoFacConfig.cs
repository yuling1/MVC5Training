

namespace SportsStore.WebPortal.App_Start
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using SportsStore.DB.Context;
    using SportsStore.Service;
    using SportsStore.Service.Interface;
    using System.Web.Mvc;

    public static class AutoFacConfig
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            var container = RegisterServices(builder);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 注册依赖服务
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<EFDbContext>().As<EFDbContext>().InstancePerRequest();

            builder.RegisterType<ProductService>().As<IProductService>();

            return builder.Build();
        }
    }
}