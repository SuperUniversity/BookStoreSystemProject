using BookStoreSystem.Areas.BookStoreAreas.Models;
using BookStoreSystem.Areas.BookStoreAreas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreSystem.Areas.BookStoreAreas.Controllers
{
    public class CustomerController : Controller
    {
        // GET: BookStoreAreas/Customer
        //private IRepository_BookStoreSystemModel<ViewModel_BookInformation> db_Book = new Repository_BookStoreSystemModel<ViewModel_BookInformation>();
        private IRepository_BookStoreSystemModel<Author> db_Author = new Repository_BookStoreSystemModel<Author>();
        private IRepository_BookStoreSystemModel<Book> db_Book = new Repository_BookStoreSystemModel<Book>();
        private IRepository_BookStoreSystemModel<SubCategory> db_SubCategory = new Repository_BookStoreSystemModel<SubCategory>();
        private IRepository_BookStoreSystemModel<Publisher> db_Publisher = new Repository_BookStoreSystemModel<Publisher>();
        private IRepository_BookStoreSystemModel<Customer> db_Customer = new Repository_BookStoreSystemModel<Customer>();

        private superuniversityEntities _entity = new superuniversityEntities();

        //test
        public ActionResult Browse(int id = 0)
        {
            ViewModel_BookInfo bookinfo = new ViewModel_BookInfo();

            ViewBag.Message = string.Format("全部商品");
            //bookinfo.Author = db_Author.GetAll();
            //bookinfo.Book = db_Book.GetAll().Where(b => b.SubCategoryID == id).ToList();

            if (id != 0)
            {
                var resultByID = from book in db_Book.GetAll().Where(b => b.SubCategoryID == id)
                                 join author in db_Author.GetAll() on book.AuthorID equals author.AuthorID
                                 join subCategory in db_SubCategory.GetAll() on book.SubCategoryID equals subCategory.SubCategoryID
                                 join publisher in db_Publisher.GetAll() on book.PublisherID equals publisher.PublisherID
                                 select new ViewModel_BookInformation
                                 {
                                     BookName = book.BookName,
                                     AuthorName = author.AuthorName,
                                     SubCategoryName = subCategory.SubCategoryName,
                                     PublisherName = publisher.PublisherName,
                                     ListPrice = book.ListPrice,
                                     SalePrice = book.SalePrice,
                                 };

                return View(resultByID.ToList());

            }

            var result = from book in db_Book.GetAll()
                         join author in db_Author.GetAll() on book.AuthorID equals author.AuthorID
                         join subCategory in db_SubCategory.GetAll() on book.SubCategoryID equals subCategory.SubCategoryID
                         join publisher in db_Publisher.GetAll() on book.PublisherID equals publisher.PublisherID
                         select new ViewModel_BookInformation
                         {
                             BookName = book.BookName,
                             AuthorName = author.AuthorName,
                             SubCategoryName = subCategory.SubCategoryName,
                             PublisherName = publisher.PublisherName,
                             ListPrice = book.ListPrice,
                             SalePrice = book.SalePrice,
                         };

            return View(result.ToList());
        }

        //[HttpPost]
        //public ActionResult Browse(int id=0)
        //{
        //    ViewModel_BookInfo bookinfo = new ViewModel_BookInfo();

        //    ViewBag.Message = string.Format("全部商品");
        //    //bookinfo.Author = db_Author.GetAll();
        //    //bookinfo.Book = db_Book.GetAll().Where(b => b.SubCategoryID == id).ToList();
        //    var result = from book in db_Book.GetAll().Where(b => b.SubCategoryID == id)
        //                 join author in db_Author.GetAll() on book.AuthorID equals author.AuthorID
        //                 join subCategory in db_SubCategory.GetAll() on book.SubCategoryID equals subCategory.SubCategoryID
        //                 join publisher in db_Publisher.GetAll() on book.PublisherID equals publisher.PublisherID
        //                 select new ViewModel_BookInformation
        //                 {
        //                     BookName = book.BookName,
        //                     AuthorName = author.AuthorName,
        //                     SubCategoryName = subCategory.SubCategoryName,
        //                     PublisherName = publisher.PublisherName,
        //                     ListPrice = book.ListPrice,
        //                     SalePrice = book.SalePrice,
        //                     Discount = book.Discount,
        //                     DiscountPrice = book.DiscountPrice,
        //                 };

        //    return View(result.ToList());
        //}

        public ActionResult CustomerProfile()    //顧客會員:管理介面(登入成功後跳轉)
        {
            if (Request.Cookies["CustomerID"] == null)
            {
                return RedirectToAction("CustomerLogin", "Account", new { Area = "BookStoreAreas" });
            }

            int id = int.Parse(Request.Cookies["CustomerID"].Value);
            var result= db_Customer.GetByID(id);
            return View(result);
        }

        public ActionResult CustomerChangePassword()
        {
            return View();
        }
    }
}