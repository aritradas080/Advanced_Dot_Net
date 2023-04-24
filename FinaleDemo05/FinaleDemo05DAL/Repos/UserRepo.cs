using FinaleDemo05DAL.Interfaces;
using FinaleDemo05DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, string, User>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Users.FirstOrDefault(u=> u.Uname.Equals(username) &&
            u.Password.Equals(password));
            if(data != null) { return true; }
            return false;
        }

        public User Create(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0) { return obj; }
            return null;
        }

        public bool Delete(string uname)
        {
            var ex = Read(uname);
            db.Users.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(string uname)
        {
            return db.Users.Find(uname);
        }

        public User Update(User obj)
        {
            var ex = Read(obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) { return obj; }
            return null;
        }
    }
}
