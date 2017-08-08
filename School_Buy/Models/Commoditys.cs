using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Buy.Models
{
    [Table("Commoditys")]
    public class Commoditys
    {
        [Key]
        public int Commoditys_Id { set; get; }
        public int Commoditys_GroupId { set; get; }
        public int Commoditys_merchantId { set; get; }
        public string Commoditys_Category { set; get; }
        public string Commoditys_Name { set;get;}
        public float Commoditys_Price { set; get; }
        public int Commoditys_Store { set; get; }
        public string Commoditys_Descript { set; get; }
        public string Commoditys_Image { set; get; }
        //商品状态只能为123中的一种1代表在销售2代表停售，三代表下架
        public int Commoditys_State { set; get; }
        public string Commodity_Color { set; get; }
        public string Commodity_Size { set; get; }
        public string Commodity_Material { set; get; }
        public string Commodity_Weight { set; get; }

    }
}