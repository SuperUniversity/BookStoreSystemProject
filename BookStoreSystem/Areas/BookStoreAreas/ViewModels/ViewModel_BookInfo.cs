using BookStoreSystem.Areas.BookStoreAreas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreSystem.Areas.BookStoreAreas.ViewModels
{

    //public class ViewModel_BookInfo
    //{

    //    private IRepository_BookStoreSystemModel<Book> db_Book = new Repository_BookStoreSystemModel<Book>();
    //    private IRepository_BookStoreSystemModel<Author> db_Author = new Repository_BookStoreSystemModel<Author>();
    //    private IRepository_BookStoreSystemModel<SubCategory> db_SubCategory = new Repository_BookStoreSystemModel<SubCategory>();
    //    private IRepository_BookStoreSystemModel<Publisher> db_Publisherr = new Repository_BookStoreSystemModel<Publisher>();

    //    //public ViewModel_BookInfo(int id = 1)
    //    //{
    //    //    List<Class_BookInfo> bookinfo = new List<Class_BookInfo>();
    //    //    var book = db_Book.GetByID(id);
    //    //    var publisher = db_Publisherr.GetByID(id);
    //    //    var subCategory = db_SubCategory.GetByID(id);
    //    //    var author = db_Author.GetByID(id);
    //    //    Class_BookInfo bk = new Class_BookInfo()
    //    //    {
    //    //        BookName = book.BookName,
    //    //        ListPrice = book.ListPrice,
    //    //        SalePrice = book.SalePrice,
    //    //        DiscountPrice = book.DiscountPrice,
    //    //        Discount = book.Discount,
    //    //        AuthorName = author.AuthorName,
    //    //        PublisherName = publisher.PublisherName,
    //    //        SubCategoryName = subCategory.SubCategoryName
    //    //    };

    //    //    //List<Class_BookInfo> BookInfo { get; set; }
    //    //}

    //}
    public class ViewModel_BookInfo
    {


        public String BookName { get; set; }
        public String AuthorName { get; set; }
        public String PublisherName { get; set; }
        public decimal ListPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string SubCategoryName { get; set; }



        public IEnumerable<Book> Book { get; set; }

        public IEnumerable<SubCategory> SubCategory { get; set; }
        public IEnumerable<Author> Author { get; set; }
        public IEnumerable<Publisher> Publisher { get; set; }

    }
}
