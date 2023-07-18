using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.Dataccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Dataccess.Concrete.NHibernate
{
    public class NHCategoryDal : NHEntityRepositoryBase<Category>, ICategoryDal
    {
        
        public NHCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
