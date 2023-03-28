using BusinessLogic01Layer.ModelDTOs;
using DataAccess01Layer.Models;
using DataAccess01Layer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogic01Layer.Services
{
    public class EmployeeService
    {
      public static List<EmployeeDTO> Get()
        {
            var c = EmployeeRepo.Get();
            var list = new List<EmployeeDTO>();
            foreach (var item in c)
            {
                list.Add(new EmployeeDTO()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return list;
        }

        //first 10 employee data extraction
        public static List<Employee> Get10()
        {
            var e = from emp in EmployeeRepo.Get()
                    where emp.Id <= 10
                    select emp;
            return e.ToList();
        }
        public static EmployeeDTO Get(int id)
        {
            var list = Get();
            var emp = (from item in list
                      where item.Id == id
                      select item).SingleOrDefault();
            return emp;
        }

        public static bool Create(EmployeeDTO employeedto)
        {
            var emp = new Employee();
            emp.Id= employeedto.Id;
            emp.Name= employeedto.Name;
            return EmployeeRepo.Create(emp);
            
        }

        public static bool Update(EmployeeDTO employeedto) { 
            var emp = new Employee();
            emp.Id = employeedto.Id;
            emp.Name = employeedto.Name;
            return EmployeeRepo.Update(emp);
        }
        public static bool Delete(int id) {
            return EmployeeRepo.Delete(id);
        }
    }
}
