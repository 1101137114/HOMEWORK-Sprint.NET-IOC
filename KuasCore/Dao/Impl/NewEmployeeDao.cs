
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : GenericDao<Employee>, IEmployeeDao
    {

        override protected IRowMapper<Employee> GetRowMapper()
        {
            return new EmployeeRowMapper();
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();

            Employee e1 = new Employee();
            e1.Id = "KUAS";
            e1.Name = "高應大";
            e1.Age = 52;
            employees.Add(e1);

            Employee e2 = new Employee();
            e2.Id = "NKFUST ";
            e2.Name = "高第一";
            e2.Age = 20;
            employees.Add(e2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {

            Employee employee = null;

            if ("KUAS".Equals(id))
            {
                employee = new Employee();
                employee.Id = "KUAS";
                employee.Name = "高應大";
                employee.Age = 52;
            }

            return employee;
        }

    }
}
