using FinaleDemo03BLL.ModelDTO;
using FinaleDemo03DAL;
using FinaleDemo03DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03BLL.Services
{
    public class MemberService
    {
        public static List<MemberDTO> Get()
        {
            var list1 = DataAccessFactory.Memberdata().Get();
            var list2 = new List<MemberDTO>();
            foreach(var item in list1)
            {
                var project = (from i in DataAccessFactory.Projectdata().Get()
                               where item.Pid==i.Id
                               select i).SingleOrDefault();
                var pro = new ProjectDTO()
                {

                    Id = project.Id,
                    Title = project.Title,
                    Status = project.Status,
                    Startdate = project.Startdate,
                    Enddate = project.Enddate
                };
                list2.Add(new MemberDTO()
                {
                    Id = item.Id,
                    Pid = item.Pid,
                    Role = item.Role,
                    Name = item.Name,
                    Projectdto = pro
                }) ;
            }
            return list2;
        }

        public static MemberDTO Get(int id) {
            var allmember = Get();
            var mem = (from item in allmember
                       where item.Id == id
                       select item).SingleOrDefault();
            return mem;
        }

        public static bool Create(MemberDTO memberdto) {
            var mem = new Member();
            mem.Id = memberdto.Id;
            mem.Pid = memberdto.Pid;
            mem.Role = memberdto.Role;
            mem.Name = memberdto.Name;
            return DataAccessFactory.Memberdata().Create(mem);
        }

        public static bool Update(MemberDTO memberdto)
        {
            var mem = new Member();
            mem.Id = memberdto.Id;
            mem.Pid = memberdto.Pid;
            mem.Role = memberdto.Role;
            mem.Name = memberdto.Name;
            return DataAccessFactory.Memberdata().Update(mem);
        }

        public static bool Delete(int id ) 
        {
            return DataAccessFactory.Memberdata().Delete(id);
        }
    }
}
