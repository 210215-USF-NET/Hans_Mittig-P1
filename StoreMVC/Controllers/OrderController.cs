using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreModels;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    public class OrderController : Controller
    {
        private IStrBL _strBL;
        private IMapper _mapper;
        public Customer _customer;
        public Location location;
        public Product product;
        //public InventoryController inv;
        public Orders ord;
        public OrderItems oritems;
        public OrderController(IStrBL strBL, IMapper mapper)
        {
            _strBL = strBL;
            _mapper = mapper;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            return View(_strBL.AllOrders().Select(order => _mapper.ParseOrders(order)).ToList());
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult PlaceOrder()
        {
            
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            int? qt = HttpContext.Session.GetInt32("customerQuantity");
            ViewData["Quantity"] = qt;
            decimal totalprice = Convert.ToDecimal(HttpContext.Session.GetString("Customer Total"));
            ViewData["Total"] = totalprice;
            String pname = HttpContext.Session.GetString("Product name");
            ViewData["Product"] = pname;
            Orders ord = new Orders();
            ord.total = totalprice;
            ord.orderdate = DateTime.Now;
            ord.customerid = HttpContext.Session.GetInt32("customerId");
            ord.locationid = HttpContext.Session.GetInt32("locationID");
            _strBL.AddOrder(ord);
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            return Redirect("../Customer/Menu");
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult CustomerOrders()
        {
            int? cid = HttpContext.Session.GetInt32("customerId");
            return View(_strBL.GetOrdersByCustID((int)cid).Select(customer => _mapper.ParseOrders(customer)).ToList());
        }

        public ActionResult LocationOrders()
        {
            int? lid = HttpContext.Session.GetInt32("locationID");
            return View(_strBL.GetOrdersByLocID((int)lid).Select(location => _mapper.ParseOrders(location)).ToList());
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
