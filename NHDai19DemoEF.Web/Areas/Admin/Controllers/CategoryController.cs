using NHDai19DemoEF.Service;
using System.Web.Mvc;

namespace NHDai19DemoEF.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Admin/Category
        public ActionResult Index()
        {
            return View(_categoryService.GetAll());
        }
    }
}