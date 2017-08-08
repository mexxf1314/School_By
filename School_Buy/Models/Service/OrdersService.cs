using School_Buy.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Buy.Models.Service
{
    public class OrdersService
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Orders> GetOrders()
        {
            return context.GOrders;
        }
        public IEnumerable<Orders> GetOrders(int id)
        {
            return context.GOrders.Where(p=>p.Ordes_Id==id);
        }
        public IEnumerable<Orders> GetOrderForUserId(int userId)
        {
            return context.GOrders.Where(p=>p.Users_Id==userId);
        }
        //根据订单Id更新订单状态
        public string UpdateOrders(int orderId,int state)
        {
            var order = context.GOrders.FirstOrDefault(p => p.Ordes_Id == orderId);
            if (order != null)
            {
                order.Order_state = state;
               
                try
                {
                    context.SaveChanges();
                    return "success";
                }
                catch (Exception)
                {
                    return "fals";
                }
            }
            else
            {
                return "订单不存在";
            }
        }
    }
}