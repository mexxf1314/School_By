using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Buy.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int CommentId { set; get; }
        public int User_Id { set; get; }
        public int Commontioys_Id { set; get; }
        public string Comment_Content { set; get; }
        public DateTime Commtet_Time { set; get; }
    }
}