using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using System.Diagnostics;

namespace StoreMVC.Controllers
{
    public class CustomerController : Controller
    {
        private IStrBL _strBL;
        private IMapper _mapper;
        public Customer _customer;
        //public Customer _customer2;
        public CustomerController(IStrBL strBL, IMapper mapper)
        {
            _strBL = strBL;
            _mapper = mapper;
        }
        // GET: CustomerController

        public ActionResult Register()
        {
            return View("CustomerCreate");
        }

        //get
        public ActionResult SignIn()
        {
                return View("SignIn");
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(Customer cust)
        {
            
                if (ModelState.IsValid)
                {
                    _customer = _strBL.GetCustomerName(cust.customerName);
                if (_customer != null)
                {
                    _customer = _strBL.GetCustomerPassword(cust.customerPassword);
                    if (_customer != null)
                    {
                        ViewData["Name"] = cust.customerName;
                        //ViewData["Pass"] = cust.customerPassword;
                        //return View("Menu");
                        HttpContext.Session.SetString("customerName", _customer.customerName);
                        // for future reference when trying to get session info
                        //string name = HttpContext.Session.GetString("customerName");
                        HttpContext.Session.SetInt32("customerId", _customer.id);
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

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(Customer cust)
        {
            if (ModelState.IsValid)
            {
                _customer = _strBL.GetCustomerName(cust.customerName);
                if (_customer != null)
                {

                    ViewData["Name"] = cust.customerName;
                    //ViewData["Pass"] = cust.customerPassword;
                    //return View("Menu");
                    HttpContext.Session.SetString("customerName", _customer.customerName);
                    // for future reference when trying to get session info
                    //string name = HttpContext.Session.GetString("customerName");
                    HttpContext.Session.SetInt32("customerId", _customer.id);
                    return View("Success");
                }
                else
                {
                    return Redirect("../Home/Invalid");
                }
            }

         return BadRequest("Invalid model state");

        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(_strBL.GetCustomers().Select(customer => _mapper.cast2CustomerIndexVM(customer)).ToList());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2CustomerCRVM(_strBL.GetCustomerName(name)));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View("CustomerCreate");
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCRVM newCustomer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _strBL.AddCustomer(_mapper.cast2Customer(newCustomer));
                    return Redirect("../Home/Index");
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(string name)
        {
            //_strBL.DeleteCustomer(_strBL.GetCustomerName(name));
            return RedirectToAction(nameof(Index));
        }

        // POST: CustomerController/Delete/5
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
