using BookStoreSystem.Areas.BookStoreAreas.Models;
using BookStoreSystem.Areas.BookStoreAreas.ViewModels;
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
                return RedirectToAction("CustomerLogin", "Account", new { Area = "BookStoreAreas" });
            }
            return View();
        }

        [HttpGet]
        public ActionResult CustomerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerLogin(ViewModel_CustomerLogin vm_CustomerLogin)
        {
            if (ModelState.IsValid)
            {
                var LoginUser = db_Customer.GetAll().FirstOrDefault(customer => customer.Account == vm_CustomerLogin.Account && customer.Password == vm_CustomerLogin.Password);
                if (LoginUser != null)
                {
                    Response.Cookies["Account"].Value = LoginUser.Account;
                    Response.Cookies["FullName"].Value = HttpUtility.UrlEncode(LoginUser.FullName);
                    Response.Cookies["CustomerID"].Value = LoginUser.CustomerID.ToString();
                    Response.Cookies["NickName"].Value = HttpUtility.UrlEncode(LoginUser.NickName);
                    if (vm_CustomerLogin.RememberMe)
                    {
                        Response.Cookies["Account"].Expires = DateTime.Now.AddDays(3);
                        Response.Cookies["FullName"].Expires = DateTime.Now.AddDays(3);
                        Response.Cookies["CustomerID"].Expires = DateTime.Now.AddDays(3);
                        Response.Cookies["NickName"].Expires = DateTime.Now.AddDays(3);

                    }
                    return RedirectToAction("CustomerProfile", "Customer", new { Area = "BookStoreAreas" });
                }
            }
            ViewBag.error = "帳號或密碼錯誤";
            return View();////
        }

    }
}