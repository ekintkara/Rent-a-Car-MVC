using Business.Abstract;
using Business.Validation;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Admin.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        
        public IActionResult CList()
        {
            var result = categoryService.GetAll();
            return View(result);
        }
        public IActionResult CAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CAdd(Category category)
        {
            CategoryValidation categoryValidation = new CategoryValidation();
            FluentValidation.Results.ValidationResult results = categoryValidation.Validate(category);
            if (results.IsValid)
            {
                categoryService.add(category);
                return RedirectToAction("CList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult CDelete(int id)
        {
            var result = categoryService.GetById(id);
            categoryService.delete(result);
            return RedirectToAction("CList");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
