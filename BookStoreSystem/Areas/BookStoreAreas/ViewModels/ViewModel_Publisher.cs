using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BookStoreSystem.Areas.BookStoreAreas.Models;


namespace BookStoreSystem.Areas.BookStoreAreas.ViewModels
{
    public class ViewModel_Publisher
    {
        [DisplayName("編號")]
        public int PublisherID { get; set; }
        [DisplayName("出版社")]
        public string PublisherName { get; set; }
        [DisplayName("廠商帳號")]
        public string PublisherUserName { get; set; }
        [DisplayName("廠商地址")]
        public string PublisherAdress { get; set; }
        [DisplayName("聯絡電話")]
        public string PublisherPhone { get; set; }
        [DisplayName("Email")]
        public string PublisherEmail { get; set; }
    }
}