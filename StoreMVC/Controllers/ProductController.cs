using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreDL;
using StoreModels;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly StoreDBContext _context;
        public Location loc;
        private IStrBL _strBL;
        private IMapper _mapper;
        public ProductController(IStrBL strBL, IMapper mapper, StoreDBContext context)
        {
            _strBL = strBL;
            _mapper = mapper;
            _context = context;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //get
        public ActionResult Select()
        {
            int? locid = HttpContext.Session.GetInt32("locationID");
            string locname = HttpContext.Session.GetString("locationName");
            ViewData["Location"] = locname;
            //return View(_strBL.ViewProducts().Select(product => _mapper.cast2ProductVM(product)).ToList());
            return View(_strBL.GetProductByLocID((int)locid).Select(product => _mapper.cast2ProductVM(product)).ToList());
        }

        public ActionResult ProductList()
        {
            int? locid = HttpContext.Session.GetInt32("locationID");
            string locname = HttpContext.Session.GetString("locationName");
            ViewData["Location"] = locname;
            //return View(_strBL.ViewProducts().Select(product => _mapper.cast2ProductVM(product)).ToList());
            return View(_strBL.GetProductByLocID((int)locid).Select(product => _mapper.cast2ProductVM(product)).ToList());
        }

        public ActionResult SelectProduct(int x)
        {
            Debug.WriteLine(x);
            Product p = _strBL.SelectProduct(x);
            HttpContext.Session.SetString("Product name", p.name);
            HttpContext.Session.SetInt32("Product id", p.id);
            HttpContext.Session.SetString("Product price", p.price.ToString());
            decimal pri = Convert.ToDecimal(HttpContext.Session.GetString("Product price"));
            Debug.WriteLine(pri);
            return View(_mapper.cast2ProductVM(p));
        }

        public ActionResult SelectProductInv(int x)
        {
            Debug.WriteLine(x);
            Product p = _strBL.SelectProduct(x);
            HttpContext.Session.SetString("Product name", p.name);
            HttpContext.Session.SetInt32("Product id", p.id);
            HttpContext.Session.SetString("Product price", p.price.ToString());
            decimal pri = Convert.ToDecimal(HttpContext.Session.GetString("Product price"));
            Debug.WriteLine(pri);
            return View(_mapper.cast2ProductVM(p));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SelectProductInv(ProductVM p, int Quantity)
        {
            if (Quantity == 0)
            {
                Quantity = 1;
            }
            int? x = HttpContext.Session.GetInt32("Product id");
            Product p2 = _strBL.SelectProduct((int)x);
            p2.quantity += Quantity;
            int y = p2.quantity;
            Debug.WriteLine(p2.id);
            _strBL.UpdateInventory(p2);
            HttpContext.Session.SetInt32("newQuantity", y);
            HttpContext.Session.SetInt32("oldQuantity", Quantity);
            return View("Updated");
        }

        public ActionResult Updated()
        {
            string name = HttpContext.Session.GetString("Product name");
            ViewData["Name"] = name;
            int ?q = HttpContext.Session.GetInt32("oldQuantity");
            ViewData["Old Quantity"] = (int)q;
            int ?qq = HttpContext.Session.GetInt32("newQuantity");
            ViewData["New Quantity"] = (int)q;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SelectProduct(ProductVM p, int Quantity)
        {
            if (Quantity == 0)
            {
                Quantity = 1;
            }
            decimal pri = Convert.ToDecimal(HttpContext.Session.GetString("Product price"));
            decimal total = pri * Quantity;
            Debug.WriteLine(total);
            string totalstring = Convert.ToString(total);
            Debug.WriteLine(totalstring);
            HttpContext.Session.SetString("Customer Total", totalstring);
            HttpContext.Session.SetInt32("customerQuantity", Quantity);
            return Redirect("../Order/Create");
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
