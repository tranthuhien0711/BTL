using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btlquanli.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        [AllowHtml]
        public string SDTNV { get; set; }
    }
}