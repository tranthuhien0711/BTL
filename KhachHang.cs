﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLBH.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [StringLength(15)]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
    }
}