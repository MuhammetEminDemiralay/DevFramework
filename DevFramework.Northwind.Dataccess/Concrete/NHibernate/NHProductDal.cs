using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.Dataccess.Abstract;
using DevFramework.Northwind.Entities.ComplexType;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Dataccess.Concrete.NHibernate
{
    public class NHProductDal : NHEntityRepositoryBase<Product>, IProductDal
    {
        NHibernateHelper _nhibernateHelper;
        public NHProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using(var session = _nhibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>()
                             on p.CategoryId equals c.CategoryId

                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };

                return result.ToList();
            }
        }
    }
}
