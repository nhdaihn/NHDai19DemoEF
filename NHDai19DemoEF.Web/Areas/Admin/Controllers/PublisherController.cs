using NHDai19DemoEF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHDai19DemoEF.Web.Areas.Admin.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherService _publisherService;
        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        // GET: Admin/Publisher
        public ActionResult Index()
        {
            return View(_publisherService.GetAll());
        }
    }
}