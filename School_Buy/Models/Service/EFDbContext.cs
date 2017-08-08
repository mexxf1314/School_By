using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace School_Buy.Models.Repository
{
    public class EFDbContext:DbContext
    {
        public DbSet<Users_Table> GUsers { set; get; }
        public DbSet<Orders> GOrders { set; get; }
        public DbSet<Order_Car> GOrder_Cars { set; get; }
        public DbSet<Administrator> GAdministrators { set; get; }
        public DbSet<Comment> GComments { set; get; }
        public DbSet<Commoditys> GCommoditys { set; get; }
    }
}