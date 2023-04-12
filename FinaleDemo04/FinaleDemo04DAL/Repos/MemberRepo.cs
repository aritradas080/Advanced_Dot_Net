using FinaleDemo04DAL.Interface;
using FinaleDemo04DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo04DAL.Repos
{
    internal class MemberRepo : Repo, IRepo<Member, int, bool>
    {
        public bool Create(Member type)
        {
            db.Members.Add(type);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exmem = Get(id);
            db.Members.Remove(exmem);
            return db.SaveChanges() > 0;
        }

        public List<Member> Get()
        {
            return db.Members.ToList();
        }

        public Member Get(int id)
        {
            return db.Members.Find(id);
        }

        public bool Update(Member type)
        {
            var exmem = Get(type.Id);
            db.Entry(exmem).CurrentValues.SetValues(exmem);
            return db.SaveChanges() > 0;
        }
    }
}
