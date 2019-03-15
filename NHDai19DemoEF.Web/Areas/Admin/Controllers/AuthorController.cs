﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHDai19DemoEF.Service;

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
            return View(listAuthor);
        }
    }
}