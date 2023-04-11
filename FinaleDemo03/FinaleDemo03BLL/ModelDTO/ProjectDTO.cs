using FinaleDemo03DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03BLL.ModelDTO
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Status { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }

        public virtual ICollection<MemberDTO> Membersdto { get; set; }

        public ProjectDTO()
        {
            Membersdto = new List<MemberDTO>();
        }
    }
}
