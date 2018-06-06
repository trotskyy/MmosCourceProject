using Autofac;
using Autofac.Integration.WebApi;
using MmosCourseProject.BLL.Services;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;
using MmosCourseProject.DAL.EfProviders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace MmosCourseProject.WebApi.IoC
{
    public class AutofacConfiguration
    {
        public static void Initialize(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            var container = RegisterDependencies(builder);
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<MyTrelloContext>().As<DbContext>().InstancePerRequest();
            builder.RegisterType<EfUnitOfWorkFactory>().As<IUnitOfWorkFactory>().InstancePerRequest();

            builder.RegisterType<ChannelService>().As<IChannelService>().InstancePerRequest();

            return builder.Build();
        }
    }
}