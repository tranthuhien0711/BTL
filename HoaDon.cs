﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLBHHQ1.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string HoaDonID { get; set; }
        public string NhanVienID { get; set; }
        public string KhachHangID { get; set; }
        public string HangHoaID { get; set; }
        public string ChatLieuID { get; set; }
        public string NgayBan { get; set; }
        [AllowHtml]
        public string TongTien { get; set; }
    }
}