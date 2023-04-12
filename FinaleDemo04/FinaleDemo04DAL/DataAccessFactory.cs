using FinaleDemo04DAL.Interface;
using FinaleDemo04DAL.Models;
using FinaleDemo04DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo04DAL
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
