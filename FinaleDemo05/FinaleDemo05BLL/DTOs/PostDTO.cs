using FinaleDemo05DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05BLL.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]  
        public string Postedby { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
