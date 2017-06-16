using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStoreSystem.Areas.BookStoreAreas.Models
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {
        public class CustomerMetaData
        {
            [DisplayName("會員編號")]
            public int CustomerID { get; set; }
            [DisplayName("姓名")]
            [Required(ErrorMessage = "請輸入姓名")]
            public string FullName { get; set; }
            [DisplayName("暱稱")]
            [Required(ErrorMessage = "請輸入姓名暱稱")]
            public string NickName { get; set; }
            [DisplayName("帳號")]
            [Required(ErrorMessage = "請輸入姓名帳號")]
            public string Account { get; set; }
            [DisplayName("密碼")]
            [DataType(DataType.Password)]
            [Required(ErrorMessage = "請輸入姓名密碼")]
            public string Password { get; set; }
            [DisplayName("Email")]
            [DataType(DataType.EmailAddress)]
            [EmailAddress(ErrorMessage = "電子信箱格式錯誤")]
            [Required(ErrorMessage = "請輸入電子信箱")]
            public string EmailAddress { get; set; }
            [DisplayName("電話")]
            public string Phone { get; set; }
            [DisplayName("性別")]
            public string Gender { get; set; }
            [DisplayName("身分證字號")]
            public string IdentityCard { get; set; }
            [DisplayName("出生年月日")]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> BirthDay { get; set; }
            [DisplayName("地址")]
            public string Address { get; set; }
        }
    }
}