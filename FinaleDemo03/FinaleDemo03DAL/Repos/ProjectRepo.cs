using FinaleDemo03DAL.Interface;
using FinaleDemo03DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03DAL.Repos
{
    internal class ProjectRepo : Repo, IRepo<Project, int, bool>
    {
        public bool Create(Project type)
        {
           db.projects.Add(type);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exeuser = Get(id);
            db.projects.Remove(exeuser);
            return db.SaveChanges() > 0;
        }

        public List<Project> Get()
        {
            return db.projects.ToList();
        }

        public Project Get(int id)
        {
            return db.projects.Find(id);
        }

        public bool Update(Project type)
        {
            var exeuser = Get(type.Id);
            db.Entry(exeuser).CurrentValues.SetValues(exeuser);
            return db.SaveChanges() > 0;
        }

      

        
    }
}
