using FinaleDemo03BLL.ModelDTO;
using FinaleDemo03DAL;
using FinaleDemo03DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo03BLL.Services
{
    public class ProjectService
    {
        public static List<ProjectDTO> Get()
        {
            var list1 = DataAccessFactory.Projectdata().Get();
            var list2 = new List<ProjectDTO>();
            foreach(var item in list1)
            {
                list2.Add(new ProjectDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Status = item.Status,
                    Startdate = item.Startdate,
                    Enddate = item.Enddate
                });

            }return list2;
        }
            
        public static ProjectDTO Get(int id) {
            var allprojects = Get();
            var pt = (from item in allprojects
                      where item.Id == id
                      select item).SingleOrDefault();
            return pt;
        }

        public static bool Create(ProjectDTO projectdto) {
            var project = new Project();
            project.Id = projectdto.Id;
            project.Title = projectdto.Title;
            project.Status = projectdto.Status;
            project.Startdate = projectdto.Startdate;
            project.Enddate = projectdto.Enddate;
            return DataAccessFactory.Projectdata().Create(project);
        }

        public static bool Update(ProjectDTO projectdto)
        {
            var project = new Project();
            project.Id = projectdto.Id;
            project.Title = projectdto.Title;
            project.Status = projectdto.Status;
            project.Startdate = projectdto.Startdate;
            project.Enddate = projectdto.Enddate;
            return DataAccessFactory.Projectdata().Update(project);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.Projectdata().Delete(id);
        }

        public static List<ProjectDTO> GetStatusProject(string status)
        {
            var list1 = Get();
            var list2 = (from item in list1
                         where status == item.Status
                         select item).ToList();
            var list3 = new List<ProjectDTO>();
            foreach(var item in list2)
            {
                list3.Add(new ProjectDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Status = item.Status,
                    Startdate= item.Startdate,
                    Enddate= item.Enddate
                });
            }
            return list3;   

        }

        public static List<ProjectDTO> GetStatusDateProject(string status, DateTime date)
        {
            var list1 = Get();
            var list2 = (from item in list1
                         where status == item.Status
                         && date.Date == item.Startdate.Date
                         && date.TimeOfDay == item.Startdate.TimeOfDay
                         select item).ToList();
            var list3 = new List<ProjectDTO>();
            foreach (var item in list2)
            {
                list3.Add(new ProjectDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Status = item.Status,
                    Startdate = item.Startdate,
                    Enddate = item.Enddate
                });
            }
            return list3;

        }

    }
}
