using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core;
using DevFramework.Core.DataAccess;

namespace DevFramework.Northwind.Dataccess.Abstract
{
    public interface IProductDal : IEnitityRepository<Product>
    {
    }
}
