using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Buy.Models
{
    [Table("Users_Table")]
    public class Users_Table
    {
        [Key]
        public int Users_Id { set; get; }
        public string Users_Name { set; get; }
        public string Users_Phone { set; get; }
        public string Users_Password { set; get; }
        public string Users_Email { set; get; }
        public string Users_Location { set; get; }
        public int Usets_Star { set; get; }
    }
}