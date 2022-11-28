using Business.Abstract;
using Business.Validation;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class ModelController : Controller
    {
        IModelService modelService;

        public ModelController(IModelService modelService)
        {
            this.modelService = modelService;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Model model)
        {
            ModelValidation modelValidation = new ModelValidation();
            FluentValidation.Results.ValidationResult results = modelValidation.Validate(model);
            if (results.IsValid)
            {
                modelService.add(model);
                return RedirectToAction("List");
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
        public IActionResult Delete(int id)
        {
            var result = modelService.GetById(id);
            modelService.delete(result);
            return RedirectToAction("List");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
