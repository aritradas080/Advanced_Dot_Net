using FinaleDemo05DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05BLL.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public string CommentText { get; set; }

        public DateTime Time { get; set; }
        
        public string CommentedBy { get; set; }
       
        public int PostId { get; set; }

       
    }
}
