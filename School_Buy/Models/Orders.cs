using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Buy.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Ordes_Id { set; get; }
        public int Users_Id { set; get; }
        public int Commoditys_Id { set; get; }
        public int Buy_num { set; get; }
        public float Buy_Price { set; get; }
        //订单状态1未发货 2已发货 3未知错误联系商家
        public int Order_state { set; get; }
        public string Customer_Remind { set; get; }
    }
}