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
    public class CategoryService : ICategoryService
    {
        public List<Category> All()
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    return context.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                // Log Exception
                return null;
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    return context.Categories.FirstOrDefault(x => x.Id == categoryId);
                }
            }
            catch (Exception ex)
            {
                // Log Exception
                return null;
            }
        }

        public bool Add(Category category)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    context.Categories.Add(category);
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

        public bool Update(Category category)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    context.Categories.AddOrUpdate(category);
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

        public bool Delete(int categoryId)
        {
            try
            {
                using (var context = new SqlDbContext())
                {
                    var dbCategory = context.Categories.FirstOrDefault(x => x.Id == categoryId);
                    context.Categories.Remove(dbCategory);
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
    }
}
