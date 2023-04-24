using FinaleDemo05DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05DAL.Repos
{
    internal class Repo
    {
        internal PostContext db;

        internal Repo()
        {
            db= new PostContext();
        }
    }
}
