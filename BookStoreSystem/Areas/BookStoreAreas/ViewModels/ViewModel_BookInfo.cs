using BookStoreSystem.Areas.BookStoreAreas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        [DisplayName("編號")]
        public int BookID { get; set; }
        [DisplayName("商品名稱")]
        [Required(ErrorMessage = "請填寫商品名稱")]
        public string BookName { get; set; }
        public int SubCategoryID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        [DisplayName("出版日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> PublishDate { get; set; }
        [DisplayName("上架日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> OnShelfDate { get; set; }
        [DisplayName("語言")]
        public string Language { get; set; }
        [DisplayName("原價")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal ListPrice { get; set; }
        [DisplayName("售價")]
        [Required(ErrorMessage = "請填寫售價")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal SalePrice { get; set; }
        [DisplayName("內容簡介")]
        [DataType(DataType.MultilineText)]
        public string BookDescription { get; set; }
        [DisplayName("作者簡介")]
        [DataType(DataType.MultilineText)]
        public string AuthorDescription { get; set; }
        [DisplayName("其他資訊")]
        [DataType(DataType.MultilineText)]
        public string OtherImformation { get; set; }
        [DisplayName("圖片1")]
        public string Image1 { get; set; }
        public byte[] BytesImage1 { get; set; }
        [DisplayName("圖片2")]
        public string Image2 { get; set; }
        public byte[] BytesImage2 { get; set; }
        [DisplayName("圖片3")]
        public string Image3 { get; set; }
        public byte[] BytesImage3 { get; set; }


        // 來自 Table_Author
        [DisplayName("作者")]
        public string AuthorName { get; set; }

        // 來自 Table_Publisher
        [DisplayName("出版社")]
        public string PublisherName { get; set; }

        // 來自 Table_SubCategory
        [DisplayName("次分類")]
        [Required(ErrorMessage = "請選擇次分類")]
        public string SubCategoryName { get; set; }

        // 來自 Table_MainCategory
        [DisplayName("主分類")]
        [Required(ErrorMessage = "請選擇主分類")]
        public string MainCategoryName { get; set; }
        public int MainCategoryID { get; set; }


        //public IEnumerable<Book> Book { get; set; }

        //public IEnumerable<SubCategory> SubCategory { get; set; }
        //public IEnumerable<Author> Author { get; set; }
        //public IEnumerable<Publisher> Publisher { get; set; }

    }
}
