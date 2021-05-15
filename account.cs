using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLHtml17.Models
{
    [Table("Accounts")]
    public class account
    {
        [Key]
        [Required(ErrorMessage = "Username is Required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "PassWord is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(20)]
        public string RoleId { get; set; }
    }
}