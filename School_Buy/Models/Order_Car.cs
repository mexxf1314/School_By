using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Buy.Models
{
    [Table("Order_Car")]
    public class Order_Car
    {
        [Key]
        public int Order_CarId { set; get; }
        public int Users_Id { set; get; }
        public int Commoditys_Id { set; get; }
        public string Commoditys_Name { set; get; }
        public int Commoditys_num { set; get; }
        public float Commoditys_Price { set; get; }

    }
}