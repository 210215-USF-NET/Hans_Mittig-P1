using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreDL;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreModels;
using StoreBL;
using System.Diagnostics;

namespace StoreMVC.Controllers
{
    public class LocationController : Controller
    {
        private readonly StoreDBContext _context;
        public Location loc;
        private IStrBL _strBL;
        private IMapper _mapper;
        public LocationController(IStrBL strBL, IMapper mapper, StoreDBContext context)
        {
            _strBL = strBL;
            _mapper = mapper;
            _context = context;
        }
        //public LocationController()
        //{
        //    _context = context;
        //}
        // GET: LocationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LocationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocationController/Create
        public IActionResult Select()
        {
            LocationVM objItemView = new LocationVM();
            objItemView.LocationList = (from objCat in _context.Locations
            select new SelectListItem()
            {
             Text = objCat.locationName,
                Value = objCat.id.ToString(),
                Selected = true
            });
            return View(objItemView);
        }

        // POST: LocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Select(LocationVM loc)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(loc.id);
                Location loc2 = _strBL.ChooseLocById(int.Parse(loc.locationName));
                if (loc == null)
                {
                    return NotFound();
                }
                ViewBag.LocationName = loc2.locationName;
                //ViewData["Pass"] = cust.customerPassword;
                //return View("Menu");
                HttpContext.Session.SetInt32("locationID", loc2.id);
                // for future reference when trying to get session info
                //string name = HttpContext.Session.GetString("customerName");
                HttpContext.Session.SetString("locationName", loc2.locationName);
                return Redirect("../Product/Select");
            }
            return BadRequest("Invalid model state");
        }


        public IActionResult SelectLoc()
        {
            LocationVM objItemView = new LocationVM();
            objItemView.LocationList = (from objCat in _context.Locations
            select new SelectListItem()
             {
             Text = objCat.locationName,
             Value = objCat.id.ToString(),
             Selected = true
             });
            return View(objItemView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SelectLoc(LocationVM loc)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(loc.id);
                Location loc2 = _strBL.ChooseLocById(int.Parse(loc.locationName));
                if (loc == null)
                {
                    return NotFound();
                }
                ViewBag.LocationName = loc2.locationName;
                //ViewData["Pass"] = cust.customerPassword;
                //return View("Menu");
                HttpContext.Session.SetInt32("locationID", loc2.id);
                // for future reference when trying to get session info
                //string name = HttpContext.Session.GetString("customerName");
                HttpContext.Session.SetString("locationName", loc2.locationName);
                return Redirect("../Order/LocationOrders");
            }
            return BadRequest("Invalid model state");
        }

        public IActionResult SelectInventory()
        {
            LocationVM objItemView = new LocationVM();
            objItemView.LocationList = (from objCat in _context.Locations
            select new SelectListItem()
             {
             Text = objCat.locationName,
             Value = objCat.id.ToString(),
             Selected = true
             });
            return View(objItemView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SelectInventory(LocationVM loc)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(loc.id);
                Location loc2 = _strBL.ChooseLocById(int.Parse(loc.locationName));
                if (loc == null)
                {
                    return NotFound();
                }
                ViewBag.LocationName = loc2.locationName;
                //ViewData["Pass"] = cust.customerPassword;
                //return View("Menu");
                HttpContext.Session.SetInt32("locationID", loc2.id);
                // for future reference when trying to get session info
                //string name = HttpContext.Session.GetString("customerName");
                HttpContext.Session.SetString("locationName", loc2.locationName);
                return Redirect("../Product/ProductList");
            }
            return BadRequest("Invalid model state");
        }


        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationController/Edit/5
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

        // GET: LocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationController/Delete/5
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
