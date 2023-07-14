using DevFramework.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Dataccess.Concrete.EntityFramework.Context
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
    }
}
