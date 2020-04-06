using ProductCategory.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductCategory.Business.Services;
using PagedList;

namespace ProductCategoryWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController()
        { }

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult Index(String successNotification)
        {
            if (!string.IsNullOrEmpty(successNotification))
            {
                ViewBag.Success = successNotification;
            }
            List<Category> categories = _categoryService.All();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoryService.Add(category);
                    string successMessage = string.Format("Category <b>{0}</b> created successfully", category.Name);
                    return RedirectToAction("Index", "Category", new { successNotification = Url.Encode(successMessage) });
                }
                else
                {
                    return View(category);
                }
            }
            catch (Exception ex)
            {
                return View(category);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category dbCategory = _categoryService.GetCategoryById(id);
            return View(dbCategory);
        }

        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Category dbCategory = _categoryService.GetCategoryById(id);
                    dbCategory.Name = category.Name;
                    bool result = _categoryService.Update(dbCategory);
                    string successMessage = string.Format("Category <b>{0}</b> updated successfully", category.Name);
                    return RedirectToAction("Index", "Category", new { successNotification = Url.Encode(successMessage) });
                }
                else
                {
                    return View(category);
                }
            }
            catch(Exception ex)
            {
                return View(category);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Category dbCategory = _categoryService.GetCategoryById(id);
            return View(dbCategory);
        }

        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                _categoryService.Delete(id);
                string successMessage = string.Format("Category <b>{0}</b> deleted successfully", category.Name);
                return RedirectToAction("Index", "Category", new { successNotification = Url.Encode(successMessage) });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}