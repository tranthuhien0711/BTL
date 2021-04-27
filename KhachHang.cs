using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btlquanli.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        [MaxLength(50)]
        [AllowHtml]
        public string SDT { get; set; }
    }
}