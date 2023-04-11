using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03DAL.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Project> projects { get; set; }

        public DbSet<Member> members { get; set; }
    }
}
