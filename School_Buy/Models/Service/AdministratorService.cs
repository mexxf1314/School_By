using School_Buy.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace School_Buy.Models.Service
{
    public class AdministratorService
    {
        EFDbContext context = new EFDbContext();
        private object p;

        /// <summary>
        /// 添加管理员信息
        /// </summary>
        /// <param name="administrator"></param>
        /// <returns></returns>
        public string AddAdministrator(Administrator administrator)
        {
            int phone = context.GAdministrators.Where(p => p.Adminis_Phone == administrator.Adminis_Phone).Count();
            if (phone > 0)
            {
                return "该电话号码已经存在";
            }
            else
            {
                var admin = new Administrator()
                {
                    Adminis_Name = administrator.Adminis_Name,
                    Adminis_Phone = administrator.Adminis_Phone,
                    Adminis_Password = administrator.Adminis_Password,
                    Adminis_Level = administrator.Adminis_Level
                };
                context.Set<Administrator>().Add(admin);
                try
                {
                    context.SaveChanges();
                    return "保存成功";
                }
                catch (Exception)
                {
                    return "保存失败";
                }
            }
        }
        /// <summary>
        /// 编辑管理员的信息
        /// </summary>
        /// <param name="administrator"></param>
        /// <returns></returns>
        public String updateadmin(Administrator administrator)
        {
            var re=context.GAdministrators.FirstOrDefault(p => p.Adminis_Id==administrator.Adminis_Id);
            if(re!=null)
            {
                re.Adminis_Name = administrator.Adminis_Name;
                re.Adminis_Password = administrator.Adminis_Password;
                re.Adminis_Phone = administrator.Adminis_Phone;
                re.Adminis_Level = administrator.Adminis_Level;
                try {
                    context.SaveChanges();
                    return "更改成功";
                } catch (Exception)
                {
                    return "更改失败";
                }
            }
            else
            {
                return "该管理员不存在";
            }

           
        }
        public string RemoveAdmin(int id)
        {
            var ad = context.GAdministrators.FirstOrDefault(p => p.Adminis_Id == id);
            if (ad != null)
            {
                context.GAdministrators.Remove(ad);
                try
                {
                    context.SaveChanges();
                    return "删除成功";
                }
                catch (Exception)
                {
                    return "删除失败";
                }

            }
            else
            {
                return "该管理员不存在";
            }
            
        }
        //返回所以管理员
        public IEnumerable<Administrator> GetAdministrator()
        {
            return context.GAdministrators;
        }
        //返回某个id的管理员
        public IEnumerable<Administrator> GetAdministrator(int id)
        {
            return context.GAdministrators.Where(p=>p.Adminis_Id==id);
        }
        //返回一个名字中含有name的所以管理员类似于模糊查询
        public IEnumerable<Administrator> GetAdministrator(string name)
        {
            return context.GAdministrators.Where(p=>p.Adminis_Name.Contains(name));
        }
    }
}