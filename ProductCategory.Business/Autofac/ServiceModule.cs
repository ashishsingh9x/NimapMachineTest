using Autofac;
using ProductCategory.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Business.Autofac
{
    public class ServiceModule : Module
    {
        public ServiceModule()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            base.Load(builder);
        }
    }
}
