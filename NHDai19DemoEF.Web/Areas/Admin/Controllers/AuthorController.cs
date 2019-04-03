using System;
using System.Linq;
using System.Web.Mvc;
using jQueryAjaxInAsp.NETMVC;
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
		[HttpPost]
		public ActionResult Index(string keySearch)
		{
			var listAuthor = _authorService.SearchAuthorByName(keySearch);

			return Json(listAuthor, JsonRequestBehavior.AllowGet);
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
			_authorService.Save();
			return RedirectToAction("Index");
		}
		public ActionResult Delete(int authorId)
		{
			try
			{
				var author = _authorService.GetById(authorId);
				if (author != null)
				{
					_authorService.Delete(author);
					return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "Index", _authorService.GetAll()), message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
				}
				else
				{
					return Json(new { success = false, message = "Something wrong !" }, JsonRequestBehavior.AllowGet);

				}
			}
			catch (Exception e)
			{
				return Json(new { success = false, message = e.Message }, JsonRequestBehavior.AllowGet);

			}

		}
	}
}