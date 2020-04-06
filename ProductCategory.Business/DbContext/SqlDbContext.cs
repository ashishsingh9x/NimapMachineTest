using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProductCategory.Business.Models;

namespace ProductCategory.Business.Context
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("SqlContext")
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
