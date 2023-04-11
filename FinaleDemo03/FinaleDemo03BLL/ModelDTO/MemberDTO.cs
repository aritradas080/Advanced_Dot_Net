using FinaleDemo03DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03BLL.ModelDTO
{
    public class MemberDTO
    {
        public int Id { get; set; }
        [ForeignKey("Project")]
        public int Pid { get; set; }

        public string Role { get; set; }

        public string Name { get; set; }

        public ProjectDTO Projectdto { get; set; }
    }
}
