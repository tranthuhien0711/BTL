using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btlquanli.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string HoaDonID { get; set; }
        public string NgayBan { get; set; }
        [AllowHtml]
        public float TongTien { get; set; }
    }
}