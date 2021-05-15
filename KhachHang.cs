namespace BTLHtml17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        public string KhachHangID { get; set; }

        [Required]
        public string TenKhachHang { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public string SDTKH { get; set; }
    }
}
