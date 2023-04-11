using FinaleDemo03DAL.Interface;
using FinaleDemo03DAL.Models;
using FinaleDemo03DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Project, int, bool> Projectdata()
        {
            return new ProjectRepo();
        }

        public static IRepo<Member, int, bool> Memberdata()
        {
            return new MemberRepo();
        }
    }
}
