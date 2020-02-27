using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookStore.Service;
using BookStore.ViewModels;

using Models.Table;

namespace BookStore.Controllers
{
    public class BulletinController : Controller
    {
        protected Service_BulletinM_Cs BulletinM_P;
        protected Service_BulletinD_Cs BulletinD_P;
        
        public BulletinController() : this(null, null, null) { }

        public BulletinController(Service_BulletinM_Cs BulletinM_Val, Service_BulletinD_Cs BulletinD_Val, Service_Supplier Supplier_Val)
        {
            BulletinM_P = BulletinM_Val ?? new Service_BulletinM_Cs();
            BulletinD_P = BulletinD_Val ?? new Service_BulletinD_Cs();
        }

        // GET: Bulletin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MasterSet()
        {
            BulletinMViewModel data = new BulletinMViewModel();

            data.DataList = BulletinM_P.AllBulletinMFill().ToList();

            return View(data);
        }

        public ActionResult AddBulletinM()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBulletinM(BulletinMViewModel AddData)
        {
            if (!ModelState.IsValid)
            {
                return View(AddData);
            }

            BulletinM Data = new BulletinM();

            Data.Bulletinsno = Guid.NewGuid();
            Data.Name = AddData.Name;
            Data.IsEnable = AddData.IsEnable;
            Data.Sort = BulletinM_P.BulletinMmaxSort() + 1;
            Data.Createdt = DateTime.Now;

            BulletinM_P.InsertBulletinM(Data);

            return RedirectToAction("MasterSet");
        }

        [HttpGet]
        public ActionResult EditMaster(Guid Bulletinsno)
        {
            BulletinM EditData = BulletinM_P.BulletinMFillBy(Bulletinsno);

            BulletinMViewModel data = new BulletinMViewModel();

            data.Name = EditData.Name;
            data.IsEnable = EditData.IsEnable;
            data.Sort = EditData.Sort;

            return View(data);
        }

        [HttpPost]
        public ActionResult EditMaster(Guid Bulletinsno, [Bind(Include = "Name,IsEnable,Sort")]BulletinMViewModel EditData)
        {
            if (!ModelState.IsValid)
            {
                return View(EditData);
            }

            BulletinM Data = new BulletinM();

            Data.Bulletinsno = Bulletinsno;
            Data.Name = EditData.Name;
            Data.IsEnable = EditData.IsEnable;
            Data.Sort = EditData.Sort;

            BulletinM_P.UpdateBulletinMBy(Data);

            return RedirectToAction("MasterSet");
        }

        [HttpGet]
        public ActionResult DeleteMaster(Guid Bulletinsno)
        {
            BulletinM_P.DeleteBulletinMBy(Bulletinsno);

            return RedirectToAction("MasterSet");
        }

        public ActionResult DetailSet()
        {
            BulletinDViewModel data = new BulletinDViewModel();

            data.DataListM = BulletinM_P.AllBulletinMFill().ToList();
            data.DataListD = BulletinD_P.AllBulletinDFill().ToList();

            return View(data);
        }

        public ActionResult AddBulletinD()
        {
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();

            BulletinMViewModel data = new BulletinMViewModel();

            data.DataList = BulletinM_P.AllBulletinMFill().ToList();

            foreach(var Item in data.DataList)
            {
                mySelectItemList.Add(new SelectListItem()
                {
                    Text = Item.Name,
                    Value = Item.Bulletinsno.ToString(),
                });
            }

            ViewBag.BullteinM = mySelectItemList;

            return View(new BulletinDViewModel());
        }

        [HttpPost]
        public ActionResult AddBulletinD(BulletinDViewModel AddData)
        {
            if (!ModelState.IsValid)
            {
                return View(AddData);
            }

            BulletinD Data = new BulletinD();

            Data.Bulletindtsno = Guid.NewGuid();
            Data.Bulletinsno = AddData.Bulletinsno;
            Data.Name = AddData.Name;
            Data.Sort = BulletinD_P.BulletinDmaxSort() + 1;
            Data.IsEnable = AddData.IsEnable;
            Data.IsImage = AddData.IsImage;
            Data.Url = AddData.Url;
            Data.Alt = AddData.Alt;
            Data.Href = AddData.Href;
            Data.Createdt = DateTime.Now;

            BulletinD_P.InsertBulletinD(Data);

            return RedirectToAction("DetailSet"); 
        }
    }
}