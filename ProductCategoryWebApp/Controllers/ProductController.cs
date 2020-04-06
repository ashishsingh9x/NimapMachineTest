using PagedList;
using ProductCategory.Business.Models;
using ProductCategory.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCategoryWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult Index(String successNotification)
        {
            if (!string.IsNullOrEmpty(successNotification))
            {
                ViewBag.Success = successNotification;
            }
            var dbProducts = _productService.GetProducts(1);
            return View(dbProducts);
        }

        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(_productService.GetProducts(currentPageIndex));
        }

        [HttpGet]
        public ActionResult Create()
        {
            CreateCategoryDropDown();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CreateCategoryDropDown();
                    _productService.Add(product);
                    string successMessage = string.Format("Product <b>{0}</b> created successfully", product.Name);
                    return RedirectToAction("Index", "Product", new { successNotification = Url.Encode(successMessage) });
                }
                else
                {
                    CreateCategoryDropDown();
                    return View(product);
                }
            }
            catch (Exception ex)
            {
                CreateCategoryDropDown();
                return View(product);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product dbProduct = _productService.GetProductById(id);
            return View(dbProduct);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Product dbProduct = _productService.GetProductById(id);
                    dbProduct.Name = product.Name;
                    _productService.Update(dbProduct);
                    string successMessage = string.Format("Product <b>{0}</b> updated successfully", product.Name);
                    return RedirectToAction("Index", "Product", new { successNotification = Url.Encode(successMessage) });
                }
                else
                {
                    return View(product);
                }
            }
            catch (Exception ex)
            {
                return View(product);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product dbProduct = _productService.GetProductById(id);
            return View(dbProduct);
        }

        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                _productService.Delete(id);
                string successMessage = string.Format("Product <b>{0}</b> deleted successfully", product.Name);
                return RedirectToAction("Index", "Product", new { successNotification = Url.Encode(successMessage) });
            }
            catch (Exception ex)
            {
                return View(product);
            }
        }

        private void CreateCategoryDropDown()
        {
            ViewBag.CategorySelectList = new SelectList(_categoryService.All().Select(x => new { Text = x.Name, Value = x.Id }).ToList(), "Value", "Text");
        }
    }
}