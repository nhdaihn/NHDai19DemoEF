using System.Linq;
using System.Web.Mvc;
using NHDai19DemoEF.Model;
using NHDai19DemoEF.Service;
using NHDai19DemoEF.Web.Areas.Admin.ViewModel;

namespace NHDai19DemoEF.Web.Areas.Admin.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        // GET: Admin/Author
        public ActionResult Index()
        {
            var listAuthor = _authorService.GetAll();
            return View(listAuthor.AsEnumerable());
        }
        public ActionResult Create()
        {
            var author = new AuthorEditViewModel();
            return View(author);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(AuthorEditViewModel authorEditViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var author = new Author()
            {
                AuthorName = authorEditViewModel.AuthorName,
                History = authorEditViewModel.History
            };
            _authorService.Add(author);
            _authorService.SaveDkm();
            return RedirectToAction("Index");
        }
    }
}