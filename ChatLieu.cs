namespace BTLHtml17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChatLieu")]
    public partial class ChatLieu
    {
        public string ChatLieuID { get; set; }

        [Required]
        public string TenChatLieu { get; set; }

        [Required]
        public string KieuDang { get; set; }
    }
}
