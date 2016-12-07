using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebService.Controllers
{
    public class DemoUIController : Controller
    {
        // GET: DemoUI
        public ActionResult Index()
        {
            ViewResult view = View();
            view.ViewName = "DemoUI";

            return view;
        }
    }
}