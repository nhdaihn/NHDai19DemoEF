using NHDai19DemoEF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHDai19DemoEF.Web.Areas.Admin.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: Admin/Book
        public ActionResult Index()
        {
            return View(_bookService.GetAll());
        }
    }
}