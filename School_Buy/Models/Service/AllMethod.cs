using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Buy.Models.Repository
{
    public class AllMethod
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Administrator> GetAllAdministrator()
        {
            return context.GAdministrators;
        }
        public IEnumerable<Administrator> GetAdministrator(int id)
        {
            return context.GAdministrators.Where(p=>p.Adminis_Id==id);
        }
        public IEnumerable<Comment> GetAllComment()
        {
            return context.GComments;
        }
        public IEnumerable<Comment> GetAComment(int id)
        {
            return context.GComments.Where(p=>p.CommentId==id);
        }
        public IEnumerable<Commoditys> GetAllCommoditys()
        {
            return context.GCommoditys;
        }
        public IEnumerable<Commoditys> GetCommoditys(int id)
        {
            return context.GCommoditys.Where(p=>p.Commoditys_Id==id);
        }
        public IEnumerable<Orders> GetAllOrders()
        {
            return context.GOrders;
        }
        public IEnumerable<Orders> GetOrders(int id)
        {
            return context.GOrders.Where(p=>p.Ordes_Id==id);
        }
        public IEnumerable<Order_Car> GetAllOrder_Car()
        {
            return context.GOrder_Cars;
        }
        public IEnumerable<Order_Car> GetOrder_Car(int id)
        {
            return context.GOrder_Cars.Where(p => p.Order_CarId == id);
        }
        public IEnumerable<Users_Table> GetAllUsers_Table()
        {
            return context.GUsers;
        }

        public IEnumerable<Users_Table> GetUsers_Table(int id)
        {
            return context.GUsers.Where(p => p.Users_Id == id);
        }
    }
}