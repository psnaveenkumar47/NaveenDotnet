using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoTableWithEF.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee AddEmployee(Employee emp);
        void Remove(int id);
        bool Update(Employee emp);
        Employee Get(int id);
    }
}