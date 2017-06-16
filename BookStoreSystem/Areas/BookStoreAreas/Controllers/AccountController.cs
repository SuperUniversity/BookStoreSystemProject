using BookStoreSystem.Areas.BookStoreAreas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreSystem.Areas.BookStoreAreas.Controllers
{
    public class AccountController : Controller
    {
        // GET: BookStoreAreas/Account
        private IRepository_BookStoreSystemModel<Customer> db_Customer = new Repository_BookStoreSystemModel<Customer>();


        [HttpGet]
        public ActionResult CustomerRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerRegister(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db_Customer.Create(customer);
                return RedirectToAction("BookStoreLogin", "Account", new { Area = "BookStoreAreas" });
            }
            return View();
        }

        [HttpGet]
        public ActionResult CustomerLogin()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult CustomerLogin(Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var LoginUser =db_Customer.GetAll().FirstOrDefault(user)
        //    }
        //    return View();
        //}

    }
}