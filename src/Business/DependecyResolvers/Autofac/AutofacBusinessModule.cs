using System;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DeliveryManager>().As<IDeliveryService>();
            builder.RegisterType<EfDeliveryDal>().As<IDeliveryDal>();

        }
    }
}
