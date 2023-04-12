using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo04DAL.Models
{
    public class Member
    {
        public int Id { get; set; }
        [ForeignKey("Project")]
        public int Pid { get; set; }

        public string Role { get; set; }

        public string Name { get; set; }

        public Project Project { get; set; }
    }
}
