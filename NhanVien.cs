namespace BTLHtml17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public string NhanVienID { get; set; }

        [Required]
        public string TenNhanVien { get; set; }

        [Required]
        public string GioiTinh { get; set; }

        [Required]
        public string DiaChiNV { get; set; }

        [Required]
        [StringLength(50)]
        public string SDTNV { get; set; }
    }
}
