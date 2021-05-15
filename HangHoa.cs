namespace BTLHtml17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        public string HangHoaID { get; set; }

        [Required]
        public string TenHangHoa { get; set; }

        [Required]
        [StringLength(128)]
        public string ChatLieuID { get; set; }

        public double SoLuong { get; set; }

        public double DonGiaNhap { get; set; }

        public double DonGiaBan { get; set; }
    }
}
