using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Buy.Models.Repository
{
    public class AllDelete
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Comment> GetComment()
        {
            return context.GComments;
        }
        //返回该商品id所以的评论并按时间先后顺序输出
        public IEnumerable<Comment> GetComment(int commoditysId)
        {
            return context.GComments.OrderByDescending(p => p.User_Id == commoditysId);
        }
        //用于查询恶意评论
        public IEnumerable<Comment> GetSpiteComment(string contexts)
        {
            return context.GComments.Where(p => p.Comment_Content.Contains(contexts));
        }
        //根据商品id添加评论
        public string AddComment(int commoditysId,int userId,string commentcontext)
        {
            var com = new Comment()
            {
                User_Id=userId,
                Commontioys_Id=commoditysId,
                Comment_Content=commentcontext,
                Commtet_Time=DateTime.Now
            };
            try
            {
                context.SaveChanges();
                return "评论成功";
            } catch (Exception)
            {
                return "评论失败";
            }
        }
        //根据评论Id删除评论
        public string RemoveComment(int comment)
        {
            var com = context.GComments.FirstOrDefault(p => p.CommentId == comment);
            if (com != null)
            {
                context.GComments.Remove(com);
                try
                {
                    context.SaveChanges();
                    return "删除评论成功";
                }
                catch (Exception)
                {
                    return "删除评论失败";
                }

            }
            else
            {
                return "该评论不存在";
            }
        }
        
    }
}