using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLBHHQ1.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string KhachHangID { get; set; }
        public string KhachHangTen { get; set; }
        public string DiaChi { get; set; }
        [AllowHtml]
        public string SDTKH { get; set; }
    }
}