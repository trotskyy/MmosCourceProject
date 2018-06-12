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

            #region Register UOW

            builder.RegisterType<MyTrelloContext>().As<DbContext>();
            builder.RegisterType<UnitOfWorkFactory>().As<IUnitOfWorkFactory>().SingleInstance();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.Register<Func<IUnitOfWork>>(
                c =>
                {
                    var context = c.Resolve<IComponentContext>();
                    return () => context.Resolve<IUnitOfWork>();
                })
            .SingleInstance();

            #endregion

            #region Register Repositories

            builder.RegisterType<ChannelRepository>().As<IChannelRepository>();
            builder.Register<Func<IRepository>>(
                 c =>
                 {
                     var context = c.Resolve<IComponentContext>();
                     return () => context.Resolve<IChannelRepository>();
                 })
             .WithMetadata<RepositoryMetadata>(m => m.For(p => p.TargetType, typeof(IChannelRepository)))
             .SingleInstance();

            #endregion

            #region Register Services

            builder.RegisterType<ChannelService>().As<IChannelService>().InstancePerRequest();

            #endregion

            return builder.Build();
        }
    }
}