﻿using NHDai19DemoEF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHDai19DemoEF.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;

        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public ActionResult Index()
        {
            var book = _bookService.GetAll();
            return View();
        }

    }
}