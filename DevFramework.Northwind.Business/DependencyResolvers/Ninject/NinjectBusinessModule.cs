using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concrete;
using DevFramework.Northwind.Dataccess.Abstract;
using DevFramework.Northwind.Dataccess.Concrete.EntityFramework;
using DevFramework.Northwind.Dataccess.Concrete.NHibernate.Helper;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class NinjectBusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EFProductDal>();

            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
