using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Dataccess.Concrete.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");

            Id(p => p.ProductId).Column("ProductId");
            Map(p => p.CategoryId).Column("CategoryID");
            Map(p => p.ProductName).Column("ProductName");
            Map(p => p.UnitPrice).Column("UnitPrice");
            Map(p => p.UnitsInStock).Column("UnitsInStock");
        }
    }
}
