using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05DAL.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string CommentText { get; set; }

        public DateTime Time { get; set; }
        [ForeignKey("User")]
        public string CommentedBy { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set;}

        public virtual Post Post { get; set; }

        public virtual User User { get; set; }

       
    }
}
