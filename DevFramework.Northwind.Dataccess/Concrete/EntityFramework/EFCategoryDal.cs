using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.Dataccess.Abstract;
using DevFramework.Northwind.Dataccess.Concrete.EntityFramework.Context;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Dataccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
