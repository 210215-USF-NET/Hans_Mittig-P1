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
    public class ManagerController : Controller
    {
        private IStrBL _strBL;
        private IMapper _mapper;
        public Manager _manager;
        public ManagerController(IStrBL strBL, IMapper mapper)
        {
            _strBL = strBL;
            _mapper = mapper;
        }
        // GET: ManagerController
        public ActionResult SignIn()
        {
            return View("SignIn");
        }

        // post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(Manager man)
        {

            if (ModelState.IsValid)
            {
                _manager = _strBL.ManagerSignInName(man.managerName);
                if (_manager != null)
                {
                    _manager = _strBL.ManagerSignInPassword(man.managerPassword);
                    if (_manager != null)
                    {
                        ViewData["Name"] = man.managerName;
                        //ViewData["Pass"] = cust.customerPassword;
                        //return View("Menu");
                        HttpContext.Session.SetString("managerName", _manager.managerName);
                        // for future reference when trying to get session info
                        //string name = HttpContext.Session.GetString("customerName");
                        HttpContext.Session.SetInt32("managerId", _manager.id);
                        return View("Menu");
                    }
                    else
                    {
                        return Redirect("../Home/Invalid");
                    }
                }
                else
                {
                    return Redirect("../Home/Invalid");
                }

            }
            return BadRequest("Invalid model state");

        }

        // GET: ManagerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManagerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManagerController/Create
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

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManagerController/Edit/5
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

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManagerController/Delete/5
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
