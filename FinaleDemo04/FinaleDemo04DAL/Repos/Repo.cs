using FinaleDemo04DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo04DAL.Repos
{
    internal class Repo
    {
        internal static ProjectContext db;
        internal Repo()
        {
            db = new ProjectContext();
        }
    }
}
