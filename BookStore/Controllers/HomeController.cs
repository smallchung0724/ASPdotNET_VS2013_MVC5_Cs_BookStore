using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookStore.Service;
using BookStore.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        protected Service_BulletinM_Cs BulletinM_P;
        protected Service_BulletinD_Cs BulletinD_P;
        protected Service_Product Product_P;

        public HomeController() : this(null, null, null) { }

        public HomeController(Service_BulletinM_Cs BulletinM_Val, Service_BulletinD_Cs BulletinD_Val, Service_Product Product_Val)
        {
            BulletinM_P = BulletinM_Val ?? new Service_BulletinM_Cs();
            BulletinD_P = BulletinD_Val ?? new Service_BulletinD_Cs();
            Product_P = Product_Val ?? new Service_Product();
        }

        // GET: Home
        public ActionResult Index()
        {
            ProductViewModel data = new ProductViewModel();

            data.DataList = Product_P.AllProductFill().ToList();

            return View(data);
        }

        public ActionResult Bulletin()
        {
            BulletinDViewModel data = new BulletinDViewModel();

            data.DataListM = BulletinM_P.AllBulletinMFill().ToList();
            data.DataListD = BulletinD_P.AllBulletinDFill().ToList();

            return PartialView("_BulletinPartial", data);
        }
    }
}