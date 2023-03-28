using DataAccess01Layer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess01Layer
{
    public class EMPContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
