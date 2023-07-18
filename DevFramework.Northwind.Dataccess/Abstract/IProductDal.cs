using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core;
using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.ComplexType;

namespace DevFramework.Northwind.Dataccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
        {

        }
    }
}
