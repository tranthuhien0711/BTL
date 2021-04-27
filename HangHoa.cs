using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace btlquanli.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        public string HangHoaID { get; set; }
        public string TenHangHoa { get; set; }
        public string SoLuong { get; set; }
        [AllowHtml]
        public string DonGia { get; set; }
    }
}