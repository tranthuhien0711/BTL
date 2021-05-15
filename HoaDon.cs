namespace BTLHtml17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        public string HoaDonID { get; set; }

        [Required]
        [StringLength(128)]
        public string NhanVienID { get; set; }

        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(128)]
        public string KhachHangID { get; set; }

        public double TongTien { get; set; }
    }
}
