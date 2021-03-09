using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLBH.Models
{
    [Table("HoaDonBHs")]
    public class HoaDonBH
    {
        [Key]
        public string HoaDonID { get; set; }
        public string NhanVienID { get; set; }
        public string KhachHangID { get; set; }
        public DateTime NgayBan { get; set; }
        public int TongTien { get; set; }
    }
}