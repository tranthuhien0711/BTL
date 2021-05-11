using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLBHHQ1.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string SDTNV { get; set; }
        [AllowHtml]
        public string GioiTinh { get; set; }
    }
}