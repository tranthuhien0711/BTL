using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLQLBHHQ1.Models
{
    [Table("ChatLieus")]
    public class ChatLieu
    {
        [Key]
        public string ChatLieuID { get; set; }
        public string TenChatLieu { get; set; }
        [AllowHtml]
        public string KieuDang { get; set; }
    }
}