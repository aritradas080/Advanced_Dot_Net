using DataAccess01Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess01Layer.Repos
{
    public class EmployeeRepo
    {
        static EMPContext db;
        static EmployeeRepo()
        {
            db = new EMPContext();
        }

        public static List<Employee> Get()
        {
          return db.Employees.ToList();   
           /*List<Employee> emps = new List<Employee>();
        for(int i = 1; i<=12; i++) { 
            emps.Add(new Employee() { Id= i , Name="E-"+i});
            }*/
        //return emps;
        }

        public static Employee Get(int id)
        {
            return db.Employees.Find(id);

        }
        public static bool Create(Employee employee)
        {
            db.Employees.Add(employee);
            return db.SaveChanges() > 0;
        }

        public static bool Update(Employee employee)
        {
            var existingEmp = Get(employee.Id); 
            db.Entry(existingEmp).CurrentValues.SetValues(employee);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var existingEmp = Get(id);
            db.Employees.Remove(existingEmp);
            return db.SaveChanges() > 0;
        }
        }
    }

