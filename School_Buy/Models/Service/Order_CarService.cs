using School_Buy.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Buy.Models.Service
{
    public class Order_CarService
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Order_Car> GetOrder_Car(int userid)
        {
            return context.GOrder_Cars.Where(p => p.Users_Id == userid);

        }
        public string RemoveOrder_Car(int order_Carid)
        {
            var car = context.GOrder_Cars.FirstOrDefault(p => p.Order_CarId == order_Carid);
            if (car != null)
            {

                try
                {
                    context.GOrder_Cars.Remove(car);
                    context.SaveChanges();
                    return "delete Order_Cat Success";
                }
                catch (Exception)
                {
                    return "derlete Order_Car false";
                }
            }
            else
            {
                return "this Order is not exist";
            }

        }
    }
}