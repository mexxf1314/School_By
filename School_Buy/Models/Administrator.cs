using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Buy.Models
{
    [Table("Administrator")]
    public class Administrator
    {
        [Key]
        public int Adminis_Id { set; get; }
        public string Adminis_Name { set; get; }
        public string Adminis_Password { set; get; }
        public string Adminis_Phone { set; get; }
        public int Adminis_Level { set; get; }
    }
}