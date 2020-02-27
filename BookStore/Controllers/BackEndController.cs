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
    public class BackEndController : Controller
    {
        protected Service_Supplier Supplier_P;
        protected Service_Product Product_P;

        public BackEndController() : this(null, null) { }

        public BackEndController(Service_Supplier Supplier_Val, Service_Product Product_Val)
        {
            Supplier_P = Supplier_Val ?? new Service_Supplier();
            Product_P = Product_P ?? new Service_Product();
        }

        // GET: BackEnd
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SupplierSet()
        {
            SupplierViewModel data = new SupplierViewModel();

            data.DataList = Supplier_P.AllSupplierFill().ToList();

            return View(data);
        }

        public ActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSupplier(SupplierViewModel AddData)
        {
            if (!ModelState.IsValid)
            {
                return View(AddData);
            }

            Supplier Data = new Supplier();

            Data.Suppsno = Guid.NewGuid();
            Data.Name = AddData.Name;
            Data.Email = AddData.Email;
            Data.Phone = AddData.Phone;
            Data.Fax = AddData.Fax;
            Data.Adress = AddData.Adress;
            Data.Createdt = DateTime.Now;

            Supplier_P.InsertSupplier(Data);

            return RedirectToAction("SupplierSet");
        }

        public ActionResult ProductSet()
        {
            ProductViewModel data = new ProductViewModel();

            data.DataList = Product_P.AllProductFill().ToList();

            return View(data);
        }

        public ActionResult AddProduct()
        {
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();

            SupplierViewModel data = new SupplierViewModel();

            data.DataList = Supplier_P.AllSupplierFill().ToList();

            foreach (var Item in data.DataList)
            {
                mySelectItemList.Add(new SelectListItem()
                {
                    Text = Item.Name,
                    Value = Item.Suppsno.ToString(),
                });
            }

            ViewBag.Product = mySelectItemList;

            return View(new ProductViewModel());
        }

        
        [HttpPost]
        public ActionResult InsertProduct(FormCollection AddData)
        {
            if (!ModelState.IsValid)
            {
                return View(AddData);
            }

            Product Data = new Product();

            Data.Productsno = Guid.NewGuid();
            Data.Name = AddData["Name"];//AddData.Name;
            Data.Author = AddData["Author"];//AddData.Author;
            Data.Suppsno = Guid.Parse(AddData["Suppsno"]);//AddData.Suppsno;
            Data.Publish = DateTime.Parse(AddData["Publish"]);//AddData.Publish;
            Data.ActualPrice = double.Parse(AddData["ActualPrice"]);//AddData.ActualPrice;
            Data.UnitPrice = double.Parse(AddData["UnitPrice"]);//AddData.UnitPrice;
            Data.Discount = double.Parse(AddData["Discount"]);//AddData.Discount;
            Data.Language = AddData["Language"];//AddData.Language;
            Data.PageNumber = int.Parse(AddData["PageNumber"]);//AddData.PageNumber;
            Data.ISBN = AddData["ISBN"];//AddData.ISBN;
            Data.Url = AddData["Url"];//AddData.Url;
            Data.Alt = AddData["Alt"];//AddData.Alt;
            Data.Href = AddData["Href"];//AddData.Href;
            Data.Describe = AddData["Describe"];//AddData.Describe;
            Data.Outline = AddData["Outline"];//AddData.Outline;
            Data.Contents = AddData["Contents"];//AddData.Contents;
            Data.Createdt = DateTime.Now;

            Product_P.InsertProduct(Data);
            
            return RedirectToAction("ProductSet");
        }
        
    }
}