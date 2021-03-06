﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStoreSystem.Areas.BookStoreAreas.Models  //命名空間必須與另一個同名partial class相同
{

    [MetadataType(typeof(PublisherMetaData))]
    public partial class Publisher
    {
        public class PublisherMetaData
        {
            [DisplayName("編號")]
            public int PublisherID { get; set; }
            [DisplayName("出版社")]
            [Required(ErrorMessage = "請輸入廠商名稱")]
            public string PublisherName { get; set; }
            [DisplayName("帳號")]
            [Required(ErrorMessage = "請輸入帳號")]
            public string PublisherUserName { get; set; }
            [DataType(DataType.Password)]
            [Required(ErrorMessage = "請輸入密碼")]
            public string PublisherPassword { get; set; }
            [DisplayName("廠商地址")]
            public string PublisherAdress { get; set; }
            [DisplayName("聯絡電話")]
            public string PublisherPhone { get; set; }
            [DisplayName("Email")]
            [EmailAddress(ErrorMessage = "電子信箱格式錯誤")]
            public string PublisherEmail { get; set; }

        }

    }
}