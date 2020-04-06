using ProductCategory.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Business.Services
{
    public interface ICategoryService
    {
        List<Category> All();
        Category GetCategoryById(int caregoryId);
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(int categoryId);

    }
}
