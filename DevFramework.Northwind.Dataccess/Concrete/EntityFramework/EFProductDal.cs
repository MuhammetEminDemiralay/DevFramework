﻿using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.Dataccess.Abstract;
using DevFramework.Northwind.Dataccess.Concrete.EntityFramework.Context;
using DevFramework.Northwind.Entities.ComplexType;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Dataccess.Concrete.EntityFramework
{
    public class EFProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using(var context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
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
