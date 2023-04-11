using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03DAL.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Status { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }

        public virtual ICollection<Member> Members { get; set; }

        public Project() {
            Members = new List<Member>();
        }
    }
}
