using ProductCategory.Business.Context;
using ProductCategory.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Business.Services
{
    public class ProductService : IProductService
    {
        public List<Product> All()
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    return context.Products.Include("Category").OrderBy(x => x.Name).ToList();
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return null;
            }
        }

        
        public Product GetProductById(int productId)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    return context.Products.Include("Category").FirstOrDefault(x => x.Id == productId);
                }
            }
            catch(Exception ex)
            {
                // Log exception
                return null;
            }
        }

        public bool Add(Product product)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public bool Update(Product product)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    context.Products.AddOrUpdate(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public bool Delete(int productId)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    var dbProduct = context.Products.FirstOrDefault(x => x.Id == productId);
                    context.Products.Remove(dbProduct);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public ProductModel GetProducts(int currentPage)
        {
            int maxRows = 10;
            using (SqlDbContext entities = new SqlDbContext())
            {
                ProductModel customerModel = new ProductModel();

                customerModel.Products = (from customer in entities.Products.Include("Category")
                                           select customer)
                            .OrderBy(customer => customer.Id)
                            .Skip((currentPage - 1) * maxRows)
                            .Take(maxRows).ToList();

                double pageCount = (double)((decimal)entities.Products.Count() / Convert.ToDecimal(maxRows));
                customerModel.PageCount = (int)Math.Ceiling(pageCount);

                customerModel.CurrentPageIndex = currentPage;

                return customerModel;
            }
        }
    }
}
