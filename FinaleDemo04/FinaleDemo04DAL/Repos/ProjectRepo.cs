using FinaleDemo04DAL.Interface;
using FinaleDemo04DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo04DAL.Repos
{
    internal class ProjectRepo : Repo, IRepo<Project, int, bool>
    {
        public bool Create(Project type)
        {
            db.Projects.Add(type);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exeuser = Get(id);
            db.Projects.Remove(exeuser);
            return db.SaveChanges() > 0;
        }

        public List<Project> Get()
        {
            return db.Projects.ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }

        public bool Update(Project type)
        {
            var pro = (from item in db.Projects
                       where item.Id == type.Id
                       select item).SingleOrDefault();
            pro.Id = type.Id;
            pro.Title= type.Title;
            pro.Status= type.Status;
            pro.Startdate = type.Startdate;
            pro.Enddate= type.Enddate;
            return db.SaveChanges() > 0;
        }
    }
}
