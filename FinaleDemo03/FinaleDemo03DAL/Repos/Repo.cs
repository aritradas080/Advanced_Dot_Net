using FinaleDemo03DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03DAL.Repos
{
    internal class Repo
    {
        internal static DemoContext db;
        
        internal Repo() { db = new DemoContext(); }
    }
}
