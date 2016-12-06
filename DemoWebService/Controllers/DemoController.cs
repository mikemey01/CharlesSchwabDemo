using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DemoServiceLayer.Models;
using DemoServiceLayer;
using System.Web.Http;
using DemoDataAccess;

namespace DemoWebService.Controllers
{
    public class DemoController : Controller
    {
        private SupportService SupportService { get; set; }

        public DemoController()
        {
            SupportService = new SupportService();
        }

        // GET: Demo
        public ActionResult Index()
        {
            ViewResult view = View();
            view.ViewName = "Demo";
            return view;
        }

        public ActionResult GetFunds()
        {
            List<FundCollectionDTO> list = new List<FundCollectionDTO>();
            list = SupportService.GetFundCollections();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllFunds()
        {
            SupportService.GetAllFunds();

            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}