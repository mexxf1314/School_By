using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Buy.Models.Repository
{
    public class AllUpdate
    {
        EFDbContext context = new EFDbContext();
        //根据类别返回所以相同类别的商品
        public IEnumerable<Commoditys> GetCommoditys(string category)
        {
            return context.GCommoditys.Where(p => (p.Commoditys_Category == category) );
        }
        //根据商品名称返回名称相同的商品
        public IEnumerable<Commoditys> GetCommodityForName(string name)
        {
            return context.GCommoditys.Where(p => p.Commoditys_Name.Contains(name));
        }
        public string AddCommoditys(Commoditys commodity)
        {
            var newcommodity = new Commoditys()
            {
                Commoditys_GroupId=commodity.Commoditys_GroupId,
                Commoditys_merchantId
            };
        }
    }
}