using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05BLL.DTOs
{
    public class PostCommentDTO : PostDTO
    {
        public List<CommentDTO> comments { get; set; }    
        public PostCommentDTO() { 
        comments= new List<CommentDTO>();
        } 
    }
}
